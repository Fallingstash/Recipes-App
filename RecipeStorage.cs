using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp {
  public class RecipeStorage {
    private List<Recipe> _recipes;
    private int _nextId;
    public RecipeStorage() {
      _recipes = JsonRecipeStorage.Load() ?? new List<Recipe>(); // Защита от null
      _nextId = _recipes.Count;
    }

    public void SaveChanges() {
      JsonRecipeStorage.Save(_recipes);
    }

    public void AddRecipe(Recipe recipe) {
      recipe.Id = ++_nextId;
      _recipes.Add(recipe);
    }

    public bool RemoveRecipe(int id) {
      var recipe = _recipes.FirstOrDefault(r => r.Id == id);
      return _recipes.Remove(recipe);
    }

    public IEnumerable<Recipe> GetAllRecipes() => _recipes; // Для Iterator

    public List<Recipe> SearchRecipes(string name) {
      return null;
    }
  }
}
