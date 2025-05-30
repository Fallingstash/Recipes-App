using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp {
  public class RecipeController {
    private RecipeStorage _storage;
    private CommandManager _commandManager;

    public RecipeController(RecipeStorage storage, CommandManager commandManager) {
      _storage = storage;
      _commandManager = commandManager;
    }

    public void AddRecipe(Recipe recipe) {
      var command = new CreateRecipeCommand(_storage, recipe);
      _commandManager.Execute(command);
    }

    public void Undo() => _commandManager.Undo();
    public void Redo() => _commandManager.Redo();

    public IEnumerable<Recipe> GetAllRecipes() {
      return _storage.GetAllRecipes();
    }

    public void SaveChanges() => _storage.SaveChanges();
  }
}
