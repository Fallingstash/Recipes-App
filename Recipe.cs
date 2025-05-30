using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RecipesApp {
  public class Recipe {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public string Steps { get; set; }
    public string ImageUrl { get; set; }
    public bool IsFromApi { get; set; }

    public Recipe(string name, List<Ingredient> ingredients, string steps) {
      Name = name;
      Ingredients = ingredients;
      Steps = steps;
    }

    [JsonConstructor]
    public Recipe(int id, string name, string imageUrl,  List<Ingredient> ingredients, string steps, bool isFromApi) {
      Id = id;
      Name = name;
      ImageUrl = imageUrl;
      Ingredients = ingredients;
      Steps = steps;
      IsFromApi = isFromApi;
    }
  }
}
