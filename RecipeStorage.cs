using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp {
  internal class RecipeStorage {
    private List<Recipe> _recipes = new List<Recipe>();
    private int _nextId = 1;

    public void AddRecipe(Recipe recipe) {
      recipe.Id = _nextId++;
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
