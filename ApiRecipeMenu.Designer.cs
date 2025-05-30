namespace RecipesApp {
  partial class ApiRecipeMenu {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      btnSearch = new Button();
      txtSearch = new TextBox();
      SearchLabel = new Label();
      listResults = new ListBox();
      pictureBox = new PictureBox();
      SelectedRecipeLabel = new Label();
      txtTitle = new TextBox();
      TitleLabel = new Label();
      txtIngredients = new TextBox();
      label1 = new Label();
      txtInstructions = new TextBox();
      label2 = new Label();
      btnAdd = new Button();
      ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
      SuspendLayout();
      // 
      // btnSearch
      // 
      btnSearch.Location = new Point(314, 24);
      btnSearch.Name = "btnSearch";
      btnSearch.Size = new Size(97, 34);
      btnSearch.TabIndex = 0;
      btnSearch.Text = "Поиск";
      btnSearch.UseVisualStyleBackColor = true;
      btnSearch.Click += btnSearch_Click;
      // 
      // txtSearch
      // 
      txtSearch.Location = new Point(12, 31);
      txtSearch.Name = "txtSearch";
      txtSearch.Size = new Size(281, 23);
      txtSearch.TabIndex = 1;
      // 
      // SearchLabel
      // 
      SearchLabel.AutoSize = true;
      SearchLabel.Font = new Font("Segoe UI", 10F);
      SearchLabel.Location = new Point(12, 9);
      SearchLabel.Name = "SearchLabel";
      SearchLabel.Size = new Size(179, 19);
      SearchLabel.TabIndex = 2;
      SearchLabel.Text = "Введите поисковой запрос";
      // 
      // listResults
      // 
      listResults.FormattingEnabled = true;
      listResults.ItemHeight = 15;
      listResults.Location = new Point(12, 64);
      listResults.Name = "listResults";
      listResults.Size = new Size(339, 154);
      listResults.TabIndex = 3;
      listResults.Click += listResults_SelectedIndexChanged;
      // 
      // pictureBox
      // 
      pictureBox.Location = new Point(12, 268);
      pictureBox.Name = "pictureBox";
      pictureBox.Size = new Size(399, 368);
      pictureBox.TabIndex = 4;
      pictureBox.TabStop = false;
      // 
      // SelectedRecipeLabel
      // 
      SelectedRecipeLabel.AutoSize = true;
      SelectedRecipeLabel.Font = new Font("Segoe UI", 10F);
      SelectedRecipeLabel.Location = new Point(15, 246);
      SelectedRecipeLabel.Name = "SelectedRecipeLabel";
      SelectedRecipeLabel.Size = new Size(177, 19);
      SelectedRecipeLabel.TabIndex = 5;
      SelectedRecipeLabel.Text = "Фото выбранного рецепта";
      // 
      // txtTitle
      // 
      txtTitle.Location = new Point(676, 130);
      txtTitle.Name = "txtTitle";
      txtTitle.Size = new Size(256, 23);
      txtTitle.TabIndex = 6;
      // 
      // TitleLabel
      // 
      TitleLabel.AutoSize = true;
      TitleLabel.Font = new Font("Segoe UI", 10F);
      TitleLabel.Location = new Point(676, 108);
      TitleLabel.Name = "TitleLabel";
      TitleLabel.Size = new Size(77, 19);
      TitleLabel.TabIndex = 7;
      TitleLabel.Text = "Названиие";
      // 
      // txtIngredients
      // 
      txtIngredients.Location = new Point(676, 178);
      txtIngredients.Multiline = true;
      txtIngredients.Name = "txtIngredients";
      txtIngredients.ScrollBars = ScrollBars.Vertical;
      txtIngredients.Size = new Size(256, 159);
      txtIngredients.TabIndex = 8;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 10F);
      label1.Location = new Point(676, 156);
      label1.Name = "label1";
      label1.Size = new Size(102, 19);
      label1.TabIndex = 9;
      label1.Text = "Ингдредиенты";
      // 
      // txtInstructions
      // 
      txtInstructions.Location = new Point(676, 371);
      txtInstructions.Multiline = true;
      txtInstructions.Name = "txtInstructions";
      txtInstructions.ScrollBars = ScrollBars.Vertical;
      txtInstructions.Size = new Size(255, 160);
      txtInstructions.TabIndex = 10;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 10F);
      label2.Location = new Point(676, 340);
      label2.Name = "label2";
      label2.Size = new Size(85, 19);
      label2.TabIndex = 11;
      label2.Text = "Инструкции";
      // 
      // btnAdd
      // 
      btnAdd.Location = new Point(1003, 295);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(92, 42);
      btnAdd.TabIndex = 12;
      btnAdd.Text = "Добавить";
      btnAdd.UseVisualStyleBackColor = true;
      btnAdd.Click += btnAdd_Click;
      // 
      // ApiRecipeMenu
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.GradientActiveCaption;
      ClientSize = new Size(1184, 640);
      Controls.Add(btnAdd);
      Controls.Add(label2);
      Controls.Add(txtInstructions);
      Controls.Add(label1);
      Controls.Add(txtIngredients);
      Controls.Add(TitleLabel);
      Controls.Add(txtTitle);
      Controls.Add(SelectedRecipeLabel);
      Controls.Add(pictureBox);
      Controls.Add(listResults);
      Controls.Add(SearchLabel);
      Controls.Add(txtSearch);
      Controls.Add(btnSearch);
      Name = "ApiRecipeMenu";
      StartPosition = FormStartPosition.Manual;
      Text = "Поиск рецептов с помощью API Spoonacular";
      ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnSearch;
    private TextBox txtSearch;
    private Label SearchLabel;
    private ListBox listResults;
    private PictureBox pictureBox;
    private Label SelectedRecipeLabel;
    private TextBox txtTitle;
    private Label TitleLabel;
    private TextBox txtIngredients;
    private Label label1;
    private TextBox txtInstructions;
    private Label label2;
    private Button btnAdd;
  }
}