namespace RecipesApp {
  partial class IngredientRow {
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      numQuantity = new TextBox();
      cmbUnit = new ComboBox();
      txtName = new TextBox();
      DeleteRow = new Button();
      SuspendLayout();
      // 
      // numQuantity
      // 
      numQuantity.AcceptsReturn = true;
      numQuantity.AcceptsTab = true;
      numQuantity.Location = new Point(314, 3);
      numQuantity.Name = "numQuantity";
      numQuantity.PlaceholderText = "введите еденицы..";
      numQuantity.RightToLeft = RightToLeft.No;
      numQuantity.Size = new Size(120, 23);
      numQuantity.TabIndex = 31;
      // 
      // cmbUnit
      // 
      cmbUnit.FormattingEnabled = true;
      cmbUnit.Items.AddRange(new object[] { "гр", "кг", "мл", "л", "шт" });
      cmbUnit.Location = new Point(440, 3);
      cmbUnit.Name = "cmbUnit";
      cmbUnit.Size = new Size(132, 23);
      cmbUnit.TabIndex = 30;
      cmbUnit.Text = "Выберите метрику";
      // 
      // txtName
      // 
      txtName.AcceptsReturn = true;
      txtName.AcceptsTab = true;
      txtName.Location = new Point(22, 2);
      txtName.Name = "txtName";
      txtName.PlaceholderText = "введите ингредиент..";
      txtName.RightToLeft = RightToLeft.No;
      txtName.Size = new Size(286, 23);
      txtName.TabIndex = 29;
      txtName.TextChanged += txtIngredient1_TextChanged;
      // 
      // DeleteRow
      // 
      DeleteRow.Location = new Point(258, 32);
      DeleteRow.Name = "DeleteRow";
      DeleteRow.Size = new Size(115, 24);
      DeleteRow.TabIndex = 32;
      DeleteRow.Text = "Удалить строку";
      DeleteRow.UseVisualStyleBackColor = true;
      DeleteRow.Click += DeleteRow_Click;
      // 
      // IngredientRow
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(DeleteRow);
      Controls.Add(numQuantity);
      Controls.Add(cmbUnit);
      Controls.Add(txtName);
      Name = "IngredientRow";
      Size = new Size(583, 73);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox numQuantity;
    private ComboBox cmbUnit;
    private TextBox txtName;
    private Button DeleteRow;
  }
}
