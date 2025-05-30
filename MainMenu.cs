using RecipeApp.Adapter;

namespace RecipesApp {
  public partial class MainMenu : Form {
    private readonly IRecipeApiAdapter _apiAdapter;
    private RecipeController _controller;
    public RecipeStorage storage;
    public CommandManager commandManager;
    private List<Recipe> _allRecipes = new List<Recipe>();



    public MainMenu() {
      InitializeComponent();
      _apiAdapter = new SpoonacularAdapter();
      storage = new RecipeStorage();
      commandManager = new CommandManager();
      _controller = new RecipeController(storage, commandManager);
      UpdateRecipesList();
    }

    private void AddRecipeMenuBtn_Click(object sender, EventArgs e) {
      using (AddRecipeMenu addRecipeMenu = new AddRecipeMenu(_controller)) {
        if (addRecipeMenu.ShowDialog() == DialogResult.OK) {
          // Обновляем интерфейс
          UpdateRecipesList();

          MessageBox.Show("Рецепт успешно сохранен!");
        }
      }
    }

    private void SaveToFile(Recipe recipe) {
      string filePath = "Рецепты.txt";

      try {
        using (StreamWriter sw = File.AppendText(filePath)) {
          sw.WriteLine($"Название: {recipe.Name}");
          sw.WriteLine("Ингредиенты:");
          foreach (var ingredient in recipe.Ingredients) {
            sw.WriteLine($"- {ingredient}");
          }
          sw.WriteLine($"Инструкции: {recipe.Steps}");
          sw.WriteLine(new string('-', 30));
        }
      }
      catch (Exception ex) {
        MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
      }
    }

    private void UpdateRecipesList() {
      RecipeList.Items.Clear();
      _allRecipes = _controller.GetAllRecipes().ToList(); // Явное преобразование
      foreach (var recipe in _allRecipes) {
        RecipeList.Items.Add(recipe.Name);
      }
    }

    private void findByIngredients_Click(object sender, EventArgs e) {
      // Проверяем инициализацию адаптера
      if (_apiAdapter == null) {
        MessageBox.Show("API адаптер не инициализирован");
        return;
      }

      // Проверяем список рецептов
      if (_allRecipes == null) {
        MessageBox.Show("Список рецептов не инициализирован");
        return;
      }

      try {
        using (var apiForm = new ApiRecipeMenu(_apiAdapter, _allRecipes, _controller)) {
          if (apiForm.ShowDialog() == DialogResult.OK) {
            MessageBox.Show("Рецепт добавлен в коллекцию.");
          }
        }
      }
      catch (Exception ex) {
        MessageBox.Show($"Ошибка при работе с API: {ex.Message}");
      }
    }

    private void Redo_Click(object sender, EventArgs e) {
      _controller.Redo();
      UpdateRecipesList();
    }

    private void Undo_Click(object sender, EventArgs e) {
      _controller.Undo();
      UpdateRecipesList();
    }
  }
}
