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

namespace RecipesApp {
  public partial class IngredientRow : UserControl {
    public event EventHandler RemoveClicked;

    public IngredientRow() {
      InitializeComponent();
      cmbUnit.Items.AddRange(new[] { "г", "кг", "мл", "л", "шт" });
      cmbUnit.SelectedIndex = 0;
    }

    public Ingredient GetIngredient() {
      return new Ingredient(
          txtName.Text,
          Convert.ToInt32(numQuantity.Text),
          cmbUnit.SelectedItem.ToString()
      );
    }

    private void IngredientRow_Load(object sender, EventArgs e) {

    }

    private void DeleteRow_Click(object sender, EventArgs e) {
      RemoveClicked?.Invoke(this, EventArgs.Empty);
    }

    private void txtIngredient1_TextChanged(object sender, EventArgs e) {

    }
  }
}