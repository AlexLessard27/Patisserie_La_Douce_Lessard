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
            enregistrerButton.Location = new Point(443, 363);
            enregistrerButton.Name = "enregistrerButton";
            enregistrerButton.Size = new Size(122, 38);
            enregistrerButton.TabIndex = 0;
            enregistrerButton.Text = "Enregistrer";
            enregistrerButton.UseVisualStyleBackColor = true;
            // 
            // nomCommandeLabel
            // 
            nomCommandeLabel.AutoSize = true;
            nomCommandeLabel.Font = new Font("Segoe UI", 12F);
            nomCommandeLabel.Location = new Point(16, 31);
            nomCommandeLabel.Name = "nomCommandeLabel";
            nomCommandeLabel.Size = new Size(171, 21);
            nomCommandeLabel.TabIndex = 1;
            nomCommandeLabel.Text = "Nom de la commande :";
            // 
            // nomCommandeComboBox
            // 
            nomCommandeComboBox.FormattingEnabled = true;
            nomCommandeComboBox.Location = new Point(16, 55);
            nomCommandeComboBox.Name = "nomCommandeComboBox";
            nomCommandeComboBox.Size = new Size(531, 23);
            nomCommandeComboBox.TabIndex = 2;
            // 
            // ingredientLabel
            // 
            ingredientLabel.AutoSize = true;
            ingredientLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingredientLabel.Location = new Point(12, 144);
            ingredientLabel.Name = "ingredientLabel";
            ingredientLabel.Size = new Size(114, 25);
            ingredientLabel.TabIndex = 3;
            ingredientLabel.Text = "Ingrédients";
            // 
            // ingredientsVueDGV
            // 
            ingredientsVueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ingredientsVueDGV.Location = new Point(12, 172);
            ingredientsVueDGV.Name = "ingredientsVueDGV";
            ingredientsVueDGV.Size = new Size(553, 185);
            ingredientsVueDGV.TabIndex = 4;
            // 
            // detruireCommandeButton
            // 
            detruireCommandeButton.Font = new Font("Segoe UI", 12F);
            detruireCommandeButton.Location = new Point(582, 34);
            detruireCommandeButton.Name = "detruireCommandeButton";
            detruireCommandeButton.Size = new Size(194, 78);
            detruireCommandeButton.TabIndex = 5;
            detruireCommandeButton.Text = "Détruire la commande et ses ingrédients";
            detruireCommandeButton.UseVisualStyleBackColor = true;
            // 
            // nomCommandeGroupBox
            // 
            nomCommandeGroupBox.Controls.Add(nomCommandeLabel);
            nomCommandeGroupBox.Controls.Add(nomCommandeComboBox);
            nomCommandeGroupBox.Location = new Point(12, 12);
            nomCommandeGroupBox.Name = "nomCommandeGroupBox";
            nomCommandeGroupBox.Size = new Size(553, 117);
            nomCommandeGroupBox.TabIndex = 6;
            nomCommandeGroupBox.TabStop = false;
            nomCommandeGroupBox.Text = "Rechercher une commande";
            // 
            // QuantiteDePieceAvecVueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 427);
            Controls.Add(nomCommandeGroupBox);
            Controls.Add(detruireCommandeButton);
            Controls.Add(ingredientsVueDGV);
            Controls.Add(ingredientLabel);
            Controls.Add(enregistrerButton);
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