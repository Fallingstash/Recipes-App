using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace RecipeApp.Adapter
{    
    public class SpoonacularAdapter : IRecipeApiAdapter
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "91760ad879504b1895c1feb1b330e175";
        private const string BaseUrl = "https://api.spoonacular.com/";

        public SpoonacularAdapter()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(BaseUrl) };
        }

        public async Task<List<Recipe>> SearchRecipesAsync(string query)
        {
            try
            {
                var requestUrl = $"recipes/complexSearch?query={query}&apiKey={ApiKey}";
                Console.WriteLine($"Sending request to: {requestUrl}"); // Логирование

                var response = await _httpClient.GetAsync(requestUrl);
                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API response: {responseContent}"); // Логирование

                response.EnsureSuccessStatusCode();

                using var doc = JsonDocument.Parse(responseContent);
                var results = doc.RootElement.GetProperty("results");

                return doc.RootElement
                    .GetProperty("results")
                    .EnumerateArray()
                    .Select(item => new Recipe(
                        item.GetProperty("id").GetInt32(),
                        item.GetProperty("title").GetString(),
                        item.GetProperty("image").GetString(),
                        new List<string>(),
                        "",
                        true))
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Full error: {ex.ToString()}"); // Детальное логирование
                MessageBox.Show($"Ошибка поиска: {ex.Message}");
                return new List<Recipe>();
            }
        }

        public async Task<Recipe> GetRecipeDetailsAsync(int recipeId)
        {
            try
            {
                var response = await _httpClient.GetAsync(
                    $"recipes/{recipeId}/information?apiKey={ApiKey}");

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                using JsonDocument doc = JsonDocument.Parse(json);
                JsonElement data = doc.RootElement;

                // Получаем список ингредиентов
                var ingredients = new List<string>();
                if (data.TryGetProperty("extendedIngredients", out JsonElement ingredientsElement))
                {
                    ingredients = ingredientsElement.EnumerateArray()
                        .Select(ing =>
                        {
                            double amount = ing.TryGetProperty("amount", out JsonElement amountElement)
                                ? amountElement.GetDouble() : 0;
                            string unit = ing.TryGetProperty("unit", out JsonElement unitElement)
                                ? unitElement.GetString() ?? "" : "";
                            string name = ing.TryGetProperty("name", out JsonElement nameElement)
                                ? nameElement.GetString() ?? "" : "";

                            string formattedAmount = amount % 1 == 0 ? amount.ToString("0") : amount.ToString("0.##");

                            unit = unit.ToLower() switch
                            {
                                "servings" => "порций",
                                "tablespoon" => "ст. ложка",
                                "cup" => "стакан",
                                "cups " => "стакана(ов)",
                                "teaspoon" => "ч. ложка",
                                "ounce" => "унция",
                                "teaspoons " => "ч. ложки",
                                "bunch " => "кусочек",
                                "pounds" => "фунты",
                                "pound" => "фунт",
                                "inch" => "дюйм",

                                _ => unit
                            };

                            return $" - {formattedAmount} {(string.IsNullOrEmpty(unit) ? "" : unit + " ")}{name}";
                        })
                        .ToList();
                }

                // Получаем остальные данные
                string title = data.TryGetProperty("title", out JsonElement titleElement)
                    ? titleElement.GetString() ?? "Без названия" : "Без названия";

                string imageUrl = data.TryGetProperty("image", out JsonElement imageElement)
                    ? imageElement.GetString() ?? "" : "";

                string instructions = data.TryGetProperty("instructions", out JsonElement instructionsElement)
                    ? instructionsElement.GetString() ?? "" : "";

                return new Recipe(
                    recipeId,
                    title,
                    imageUrl,
                    ingredients,
                    instructions,
                    true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки деталей: {ex.Message}");
                return null;
            }
        }


    }
}
