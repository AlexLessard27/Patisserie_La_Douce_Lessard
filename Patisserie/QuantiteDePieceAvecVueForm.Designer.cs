namespace Patisserie
{
    partial class QuantiteDePieceAvecVueForm
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
        private void InitializeComponent()
        {
            enregistrerButton = new Button();
            nomCommandeLabel = new Label();
            nomCommandeComboBox = new ComboBox();
            ingredientLabel = new Label();
            ingredientsVueDGV = new DataGridView();
            detruireCommandeButton = new Button();
            nomCommandeGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ingredientsVueDGV).BeginInit();
            nomCommandeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // enregistrerButton
            // 
            enregistrerButton.Font = new Font("Segoe UI", 12F);
            enregistrerButton.Location = new Point(506, 484);
            enregistrerButton.Margin = new Padding(3, 4, 3, 4);
            enregistrerButton.Name = "enregistrerButton";
            enregistrerButton.Size = new Size(139, 51);
            enregistrerButton.TabIndex = 0;
            enregistrerButton.Text = "Enregistrer";
            enregistrerButton.UseVisualStyleBackColor = true;
            // 
            // nomCommandeLabel
            // 
            nomCommandeLabel.AutoSize = true;
            nomCommandeLabel.Font = new Font("Segoe UI", 12F);
            nomCommandeLabel.Location = new Point(18, 41);
            nomCommandeLabel.Name = "nomCommandeLabel";
            nomCommandeLabel.Size = new Size(215, 28);
            nomCommandeLabel.TabIndex = 1;
            nomCommandeLabel.Text = "Nom de la commande :";
            // 
            // nomCommandeComboBox
            // 
            nomCommandeComboBox.FormattingEnabled = true;
            nomCommandeComboBox.Location = new Point(18, 73);
            nomCommandeComboBox.Margin = new Padding(3, 4, 3, 4);
            nomCommandeComboBox.Name = "nomCommandeComboBox";
            nomCommandeComboBox.Size = new Size(606, 28);
            nomCommandeComboBox.TabIndex = 2;
            nomCommandeComboBox.SelectedIndexChanged += nomCommandeComboBox_SelectedIndexChanged;
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingredientLabel.Location = new Point(14, 192);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new Size(145, 32);
            ingredientLabel.TabIndex = 3;
            ingredientLabel.Text = "Ingrédients";
            // 
            // ingredientsVueDGV
            // 
            ingredientsVueDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ingredientsVueDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ingredientsVueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredientsVueDGV.Location = new Point(14, 229);
            ingredientsVueDGV.Margin = new Padding(3, 4, 3, 4);
            ingredientsVueDGV.Name = "ingredientsVueDGV";
            ingredientsVueDGV.RowHeadersWidth = 51;
            ingredientsVueDGV.Size = new Size(632, 247);
            ingredientsVueDGV.TabIndex = 4;
            ingredientsVueDGV.CellEndEdit += ingredientsVueDGV_CellEndEdit;
            // 
            // detruireCommandeButton
            // 
            detruireCommandeButton.Font = new Font("Segoe UI", 12F);
            detruireCommandeButton.Location = new Point(665, 45);
            detruireCommandeButton.Margin = new Padding(3, 4, 3, 4);
            detruireCommandeButton.Name = "detruireCommandeButton";
            detruireCommandeButton.Size = new Size(222, 104);
            detruireCommandeButton.TabIndex = 5;
            detruireCommandeButton.Text = "Détruire la commande et ses ingrédients";
            detruireCommandeButton.UseVisualStyleBackColor = true;
            detruireCommandeButton.Click += detruireCommandeButton_Click;
            // 
            // nomCommandeGroupBox
            // 
            nomCommandeGroupBox.Controls.Add(nomCommandeLabel);
            nomCommandeGroupBox.Controls.Add(nomCommandeComboBox);
            nomCommandeGroupBox.Location = new Point(14, 16);
            nomCommandeGroupBox.Margin = new Padding(3, 4, 3, 4);
            nomCommandeGroupBox.Name = "nomCommandeGroupBox";
            nomCommandeGroupBox.Padding = new Padding(3, 4, 3, 4);
            nomCommandeGroupBox.Size = new Size(632, 156);
            nomCommandeGroupBox.TabIndex = 6;
            nomCommandeGroupBox.TabStop = false;
            nomCommandeGroupBox.Text = "Rechercher une commande";
            // 
            // QuantiteDePieceAvecVueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 569);
            Controls.Add(nomCommandeGroupBox);
            Controls.Add(detruireCommandeButton);
            Controls.Add(ingredientsVueDGV);
            Controls.Add(ingredientLabel);
            Controls.Add(enregistrerButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuantiteDePieceAvecVueForm";
            Text = "Charger la quantité d'ingrédient pour un projet";
            Load += QuantiteDePieceAvecVueForm_Load;
            ((System.ComponentModel.ISupportInitialize)ingredientsVueDGV).EndInit();
            nomCommandeGroupBox.ResumeLayout(false);
            nomCommandeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enregistrerButton;
        private Label nomCommandeLabel;
        private ComboBox nomCommandeComboBox;
        private Label ingredientLabel;
        private DataGridView ingredientsVueDGV;
        private Button detruireCommandeButton;
        private GroupBox nomCommandeGroupBox;
    }
}