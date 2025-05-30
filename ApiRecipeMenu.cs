using RecipeApp.Adapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesApp {
  public partial class ApiRecipeMenu : Form {
    private RecipeController _controller;
    private readonly IRecipeApiAdapter _apiAdapter;
    private readonly List<Recipe> _existingRecipes;
    private List<Recipe> _foundRecipes = new List<Recipe>();

    public ApiRecipeMenu(IRecipeApiAdapter apiAdapter, List<Recipe> existingRecipes, RecipeController controller) {
      InitializeComponent();
      _controller = controller;
      _apiAdapter = apiAdapter;
      _existingRecipes = existingRecipes;

    }

    private async void btnSearch_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
        MessageBox.Show("Введите поисковый запрос");
        return;
      }

      btnSearch.Enabled = false;
      listResults.Items.Clear();
      _foundRecipes.Clear();

      try {
        _foundRecipes = await _apiAdapter.SearchRecipesAsync(txtSearch.Text);
        listResults.Items.AddRange(_foundRecipes.Select(r => r.Name).ToArray());
      }
      finally {
        btnSearch.Enabled = true;
      }
    }

    private async void listResults_SelectedIndexChanged(object sender, EventArgs e) {
      if (listResults.SelectedIndex < 0)
        return;

      var selectedRecipe = _foundRecipes[listResults.SelectedIndex];
      var fullRecipe = await _apiAdapter.GetRecipeDetailsAsync(selectedRecipe.Id);

      if (fullRecipe != null) {
        txtTitle.Text = fullRecipe.Name;
        txtIngredients.Text = string.Join("\n", fullRecipe.Ingredients);
        txtInstructions.Text = fullRecipe.Steps;

        try {
          if (!string.IsNullOrEmpty(fullRecipe.ImageUrl))
            pictureBox.LoadAsync(fullRecipe.ImageUrl);
          else
            pictureBox.Image = null;
        }
        catch {
          pictureBox.Image = null;
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      if (listResults.SelectedIndex < 0) {
        MessageBox.Show("Выберите рецепт из списка");
        return;
      }

      var selectedRecipe = _foundRecipes[listResults.SelectedIndex];

      if (_existingRecipes.Any(r => r.Id == selectedRecipe.Id)) {
        MessageBox.Show("Этот рецепт уже есть в вашей коллекции");
        return;
      }

      MessageBox.Show("Рецепт добавлен в коллекцию");
      _controller.AddRecipe(selectedRecipe);
      _controller.SaveChanges();
    }
  }
}