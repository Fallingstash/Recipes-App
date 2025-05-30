namespace RecipesApp {
  partial class MainMenu {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      AddRecipeMenuBtn = new Button();
      RecipeList = new ListBox();
      label1 = new Label();
      label2 = new Label();
      findByIngredients = new Button();
      Undo = new Button();
      Redo = new Button();
      SuspendLayout();
      // 
      // AddRecipeMenuBtn
      // 
      AddRecipeMenuBtn.Location = new Point(648, 61);
      AddRecipeMenuBtn.Name = "AddRecipeMenuBtn";
      AddRecipeMenuBtn.Size = new Size(140, 57);
      AddRecipeMenuBtn.TabIndex = 0;
      AddRecipeMenuBtn.Text = "Добавить рецепт";
      AddRecipeMenuBtn.UseVisualStyleBackColor = true;
      AddRecipeMenuBtn.Click += AddRecipeMenuBtn_Click;
      // 
      // RecipeList
      // 
      RecipeList.BackColor = SystemColors.ButtonHighlight;
      RecipeList.FormattingEnabled = true;
      RecipeList.ItemHeight = 15;
      RecipeList.Location = new Point(167, 154);
      RecipeList.Name = "RecipeList";
      RecipeList.Size = new Size(432, 109);
      RecipeList.TabIndex = 1;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 20F);
      label1.Location = new Point(266, 12);
      label1.Name = "label1";
      label1.Size = new Size(274, 37);
      label1.TabIndex = 2;
      label1.Text = "Менеджер рецептов";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 20F);
      label2.Location = new Point(167, 98);
      label2.Name = "label2";
      label2.Size = new Size(290, 37);
      label2.TabIndex = 3;
      label2.Text = "Список всех рецептов";
      // 
      // findByIngredients
      // 
      findByIngredients.Location = new Point(12, 61);
      findByIngredients.Name = "findByIngredients";
      findByIngredients.Size = new Size(140, 57);
      findByIngredients.TabIndex = 4;
      findByIngredients.Text = "Найти по ингредиентам..";
      findByIngredients.UseVisualStyleBackColor = true;
      findByIngredients.Click += findByIngredients_Click;
      // 
      // Undo
      // 
      Undo.BackColor = Color.Red;
      Undo.Location = new Point(11, 5);
      Undo.Name = "Undo";
      Undo.Size = new Size(26, 23);
      Undo.TabIndex = 5;
      Undo.UseVisualStyleBackColor = false;
      Undo.Click += Undo_Click;
      // 
      // Redo
      // 
      Redo.BackColor = Color.DarkGreen;
      Redo.Location = new Point(43, 5);
      Redo.Name = "Redo";
      Redo.Size = new Size(26, 23);
      Redo.TabIndex = 6;
      Redo.UseVisualStyleBackColor = false;
      Redo.Click += Redo_Click;
      // 
      // MainMenu
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.GradientActiveCaption;
      ClientSize = new Size(800, 450);
      Controls.Add(Redo);
      Controls.Add(Undo);
      Controls.Add(findByIngredients);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(RecipeList);
      Controls.Add(AddRecipeMenuBtn);
      Name = "MainMenu";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button AddRecipeMenuBtn;
    private ListBox RecipeList;
    private Label label1;
    private Label label2;
    private Button findByIngredients;
    private Button Undo;
    private Button Redo;
  }
}
