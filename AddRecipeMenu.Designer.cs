namespace RecipesApp
{
    partial class AddRecipeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
      InstructionsBox = new TextBox();
      NameBox = new TextBox();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      label1 = new Label();
      SaveButton = new Button();
      CancelButton = new Button();
      flowIngredients = new FlowLayoutPanel();
      AddIngredient = new Button();
      SuspendLayout();
      // 
      // InstructionsBox
      // 
      InstructionsBox.Location = new Point(243, 358);
      InstructionsBox.Multiline = true;
      InstructionsBox.Name = "InstructionsBox";
      InstructionsBox.Size = new Size(315, 23);
      InstructionsBox.TabIndex = 4;
      // 
      // NameBox
      // 
      NameBox.Location = new Point(243, 76);
      NameBox.Name = "NameBox";
      NameBox.Size = new Size(315, 23);
      NameBox.TabIndex = 6;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(178, 79);
      label2.Name = "label2";
      label2.Size = new Size(59, 15);
      label2.TabIndex = 8;
      label2.Text = "Название";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(156, 114);
      label3.Name = "label3";
      label3.Size = new Size(81, 15);
      label3.TabIndex = 9;
      label3.Text = "Ингредиенты";
      label3.Click += label3_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(138, 358);
      label4.Name = "label4";
      label4.Size = new Size(74, 15);
      label4.TabIndex = 10;
      label4.Text = "Инструкции";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 20F);
      label1.Location = new Point(283, 36);
      label1.Name = "label1";
      label1.Size = new Size(231, 37);
      label1.TabIndex = 20;
      label1.Text = "Добавить рецепт";
      // 
      // SaveButton
      // 
      SaveButton.Location = new Point(640, 400);
      SaveButton.Margin = new Padding(3, 2, 3, 2);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(149, 41);
      SaveButton.TabIndex = 26;
      SaveButton.Text = "Сохранить";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // CancelButton
      // 
      CancelButton.Location = new Point(487, 400);
      CancelButton.Margin = new Padding(3, 2, 3, 2);
      CancelButton.Name = "CancelButton";
      CancelButton.Size = new Size(129, 41);
      CancelButton.TabIndex = 27;
      CancelButton.Text = "Отмена";
      CancelButton.UseVisualStyleBackColor = true;
      CancelButton.Click += CancelButton_Click;
      // 
      // flowIngredients
      // 
      flowIngredients.AutoScroll = true;
      flowIngredients.Location = new Point(0, 132);
      flowIngredients.Name = "flowIngredients";
      flowIngredients.Size = new Size(804, 198);
      flowIngredients.TabIndex = 33;
      // 
      // AddIngredient
      // 
      AddIngredient.Location = new Point(321, 105);
      AddIngredient.Name = "AddIngredient";
      AddIngredient.Size = new Size(146, 23);
      AddIngredient.TabIndex = 34;
      AddIngredient.Text = "Добавить ингредиент..";
      AddIngredient.UseVisualStyleBackColor = true;
      AddIngredient.Click += AddIngredient_Click;
      // 
      // AddRecipeMenu
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = SystemColors.GradientActiveCaption;
      ClientSize = new Size(800, 450);
      Controls.Add(AddIngredient);
      Controls.Add(flowIngredients);
      Controls.Add(CancelButton);
      Controls.Add(SaveButton);
      Controls.Add(label1);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(NameBox);
      Controls.Add(InstructionsBox);
      Name = "AddRecipeMenu";
      Text = "AddRecipeMenu";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox InstructionsBox;
        private TextBox NameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SaveButton;
        private Button CancelButton;
    private FlowLayoutPanel flowIngredients;
    private Button AddIngredient;
  }
}