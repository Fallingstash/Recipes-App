using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace RecipesApp {
  public partial class AddRecipeMenu : Form {
    private RecipeController _controller;
    public Recipe SavedRecipe { get; private set; }

    public AddRecipeMenu(RecipeController controller) {
      InitializeComponent();
      _controller = controller;
    }

    private void SaveButton_Click(object sender, EventArgs e) {
      if (string.IsNullOrEmpty(NameBox.Text)) {
        MessageBox.Show("Введите название рецепта!");
        return;
      }

      var ingredients = new List<Ingredient>();
      foreach (var control in flowIngredients.Controls) {
        if (control is IngredientRow row) {
          var ingredient = row.GetIngredient();
          if (!string.IsNullOrEmpty(ingredient.Name)) {
            ingredients.Add(ingredient);
          }
        }
      }

      if (ingredients.Count == 0) {
        MessageBox.Show("Добавьте хотя бы один ингредиент!");
        return;
      }

      var newRecipe = new Recipe(NameBox.Text, ingredients, InstructionsBox.Text);
      _controller.AddRecipe(newRecipe);
      _controller.SaveChanges();


      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void CancelButton_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void AddRecipeMenu_Load(object sender, EventArgs e) {
      AddIngredientRow();
    }

    private void AddIngredient_Click(object sender, EventArgs e) {
      AddIngredientRow();
    }

    private void AddIngredientRow() {
      var row = new IngredientRow();
      row.RemoveClicked += (s, args) => flowIngredients.Controls.Remove(row);
      flowIngredients.Controls.Add(row);
      row.Focus();
    }

    private void label3_Click(object sender, EventArgs e) {

    }
  }
}
