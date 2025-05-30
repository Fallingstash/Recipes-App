using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp {
  public class CreateRecipeCommand : ICommand {
    private RecipeStorage _storage { get; set; }
    private Recipe _recipe { get; set; }

    public CreateRecipeCommand(RecipeStorage storage, Recipe recipe) {
      _storage = storage;
      _recipe = recipe;
    }

    public void Execute() => _storage.AddRecipe(_recipe);

    public void Undo() => _storage.RemoveRecipe(_recipe.Id);
  }
}
