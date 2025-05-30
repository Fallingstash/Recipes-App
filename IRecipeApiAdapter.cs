using RecipesApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Adapter {
  public interface IRecipeApiAdapter {
    Task<List<Recipe>> SearchRecipesAsync(string query);
    Task<Recipe> GetRecipeDetailsAsync(int recipeId);
  }
}
