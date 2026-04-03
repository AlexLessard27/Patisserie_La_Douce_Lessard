namespace Travail_Patisserie_LaDouche_Lessard
{
    partial class ImputationPieceForm
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
            rechercherPieceGroupBox = new GroupBox();
            rechercherRecetteButton = new Button();
            numeroPieceTextBox = new TextBox();
            pieceDesireDGV = new DataGridView();
            label2 = new Label();
            numeroPieceLabel = new Label();
            commandeGroupBox = new GroupBox();
            choisirCommandeLabel = new Label();
            choisirCommandeComboBox = new ComboBox();
            employeGroupBox = new GroupBox();
            choisirEmployeLabel = new Label();
            choisirEmployeComboBox = new ComboBox();
            choisirEmployeButton = new Button();
            quantiteLabel = new Label();
            quatiteNUD = new NumericUpDown();
            ajoutezImputationButton = new Button();
            rechercherPieceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pieceDesireDGV).BeginInit();
            commandeGroupBox.SuspendLayout();
            employeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quatiteNUD).BeginInit();
            SuspendLayout();
            // 
            // rechercherPieceGroupBox
            // 
            rechercherPieceGroupBox.Controls.Add(rechercherRecetteButton);
            rechercherPieceGroupBox.Controls.Add(numeroPieceTextBox);
            rechercherPieceGroupBox.Controls.Add(pieceDesireDGV);
            rechercherPieceGroupBox.Controls.Add(label2);
            rechercherPieceGroupBox.Controls.Add(numeroPieceLabel);
            rechercherPieceGroupBox.Font = new Font("Segoe UI", 12F);
            rechercherPieceGroupBox.Location = new Point(14, 16);
            rechercherPieceGroupBox.Margin = new Padding(3, 4, 3, 4);
            rechercherPieceGroupBox.Name = "rechercherPieceGroupBox";
            rechercherPieceGroupBox.Padding = new Padding(3, 4, 3, 4);
            rechercherPieceGroupBox.Size = new Size(890, 345);
            rechercherPieceGroupBox.TabIndex = 0;
            rechercherPieceGroupBox.TabStop = false;
            rechercherPieceGroupBox.Text = "Rechercher une recette avec ou sans scanneur";
            // 
            // rechercherRecetteButton
            // 
            rechercherRecetteButton.Location = new Point(552, 35);
            rechercherRecetteButton.Margin = new Padding(3, 4, 3, 4);
            rechercherRecetteButton.Name = "rechercherRecetteButton";
            rechercherRecetteButton.Size = new Size(173, 39);
            rechercherRecetteButton.TabIndex = 6;
            rechercherRecetteButton.Text = "Rechercher";
            rechercherRecetteButton.UseVisualStyleBackColor = true;
            rechercherRecetteButton.Click += rechercherRecetteButton_Click;
            // 
            // numeroPieceTextBox
            // 
            numeroPieceTextBox.Location = new Point(201, 35);
            numeroPieceTextBox.Margin = new Padding(3, 4, 3, 4);
            numeroPieceTextBox.Name = "numeroPieceTextBox";
            numeroPieceTextBox.Size = new Size(326, 34);
            numeroPieceTextBox.TabIndex = 5;
            // 
            // pieceDesireDGV
            // 
            pieceDesireDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pieceDesireDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pieceDesireDGV.Location = new Point(21, 119);
            pieceDesireDGV.Margin = new Padding(3, 4, 3, 4);
            pieceDesireDGV.Name = "pieceDesireDGV";
            pieceDesireDGV.RowHeadersWidth = 51;
            pieceDesireDGV.Size = new Size(845, 200);
            pieceDesireDGV.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(272, 28);
            label2.TabIndex = 3;
            label2.Text = "Sélectionner la recette désirée";
            // 
            // numeroPieceLabel
            // 
            numeroPieceLabel.AutoSize = true;
            numeroPieceLabel.Location = new Point(21, 33);
            numeroPieceLabel.Name = "numeroPieceLabel";
            numeroPieceLabel.Size = new Size(174, 28);
            numeroPieceLabel.TabIndex = 2;
            numeroPieceLabel.Text = "Recherche recette :";
            // 
            // commandeGroupBox
            // 
            commandeGroupBox.Controls.Add(choisirCommandeLabel);
            commandeGroupBox.Controls.Add(choisirCommandeComboBox);
            commandeGroupBox.Font = new Font("Segoe UI", 12F);
            commandeGroupBox.Location = new Point(14, 369);
            commandeGroupBox.Margin = new Padding(3, 4, 3, 4);
            commandeGroupBox.Name = "commandeGroupBox";
            commandeGroupBox.Padding = new Padding(3, 4, 3, 4);
            commandeGroupBox.Size = new Size(890, 123);
            commandeGroupBox.TabIndex = 1;
            commandeGroupBox.TabStop = false;
            commandeGroupBox.Text = "Commande";
            // 
            // choisirCommandeLabel
            // 
            choisirCommandeLabel.AutoSize = true;
            choisirCommandeLabel.Location = new Point(7, 52);
            choisirCommandeLabel.Name = "choisirCommandeLabel";
            choisirCommandeLabel.Size = new Size(221, 28);
            choisirCommandeLabel.TabIndex = 1;
            choisirCommandeLabel.Text = "Choisir une commande :";
            // 
            // choisirCommandeComboBox
            // 
            choisirCommandeComboBox.FormattingEnabled = true;
            choisirCommandeComboBox.Location = new Point(245, 52);
            choisirCommandeComboBox.Margin = new Padding(3, 4, 3, 4);
            choisirCommandeComboBox.Name = "choisirCommandeComboBox";
            choisirCommandeComboBox.Size = new Size(372, 36);
            choisirCommandeComboBox.TabIndex = 0;
            // 
            // employeGroupBox
            // 
            employeGroupBox.Controls.Add(choisirEmployeLabel);
            employeGroupBox.Controls.Add(choisirEmployeComboBox);
            employeGroupBox.Controls.Add(choisirEmployeButton);
            employeGroupBox.Font = new Font("Segoe UI", 12F);
            employeGroupBox.Location = new Point(14, 500);
            employeGroupBox.Margin = new Padding(3, 4, 3, 4);
            employeGroupBox.Name = "employeGroupBox";
            employeGroupBox.Padding = new Padding(3, 4, 3, 4);
            employeGroupBox.Size = new Size(890, 111);
            employeGroupBox.TabIndex = 1;
            employeGroupBox.TabStop = false;
            employeGroupBox.Text = "Employé";
            // 
            // choisirEmployeLabel
            // 
            choisirEmployeLabel.AutoSize = true;
            choisirEmployeLabel.Location = new Point(7, 44);
            choisirEmployeLabel.Name = "choisirEmployeLabel";
            choisirEmployeLabel.Size = new Size(189, 28);
            choisirEmployeLabel.TabIndex = 2;
            choisirEmployeLabel.Text = "Choisir un employé :";
            // 
            // choisirEmployeComboBox
            // 
            choisirEmployeComboBox.FormattingEnabled = true;
            choisirEmployeComboBox.Location = new Point(245, 37);
            choisirEmployeComboBox.Margin = new Padding(3, 4, 3, 4);
            choisirEmployeComboBox.Name = "choisirEmployeComboBox";
            choisirEmployeComboBox.Size = new Size(372, 36);
            choisirEmployeComboBox.TabIndex = 1;
            // 
            // choisirEmployeButton
            // 
            choisirEmployeButton.Location = new Point(650, 37);
            choisirEmployeButton.Margin = new Padding(3, 4, 3, 4);
            choisirEmployeButton.Name = "choisirEmployeButton";
            choisirEmployeButton.Size = new Size(215, 41);
            choisirEmployeButton.TabIndex = 0;
            choisirEmployeButton.Text = "Choisir un employé";
            choisirEmployeButton.UseVisualStyleBackColor = true;
            // 
            // quantiteLabel
            // 
            quantiteLabel.AutoSize = true;
            quantiteLabel.Font = new Font("Segoe UI", 12F);
            quantiteLabel.Location = new Point(21, 633);
            quantiteLabel.Name = "quantiteLabel";
            quantiteLabel.Size = new Size(97, 28);
            quantiteLabel.TabIndex = 2;
            quantiteLabel.Text = "Quantité :";
            // 
            // quatiteNUD
            // 
            quatiteNUD.Location = new Point(133, 637);
            quatiteNUD.Margin = new Padding(3, 4, 3, 4);
            quatiteNUD.Name = "quatiteNUD";
            quatiteNUD.Size = new Size(140, 27);
            quatiteNUD.TabIndex = 3;
            // 
            // ajoutezImputationButton
            // 
            ajoutezImputationButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ajoutezImputationButton.Location = new Point(297, 633);
            ajoutezImputationButton.Margin = new Padding(3, 4, 3, 4);
            ajoutezImputationButton.Name = "ajoutezImputationButton";
            ajoutezImputationButton.Size = new Size(203, 47);
            ajoutezImputationButton.TabIndex = 4;
            ajoutezImputationButton.Text = "Ajouter imputation";
            ajoutezImputationButton.UseVisualStyleBackColor = true;
            ajoutezImputationButton.Click += ajoutezImputationButton_Click;
            // 
            // ImputationPieceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 701);
            Controls.Add(ajoutezImputationButton);
            Controls.Add(quatiteNUD);
            Controls.Add(quantiteLabel);
            Controls.Add(employeGroupBox);
            Controls.Add(commandeGroupBox);
            Controls.Add(rechercherPieceGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImputationPieceForm";
            Text = "Faire une imputation";
            rechercherPieceGroupBox.ResumeLayout(false);
            rechercherPieceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pieceDesireDGV).EndInit();
            commandeGroupBox.ResumeLayout(false);
            commandeGroupBox.PerformLayout();
            employeGroupBox.ResumeLayout(false);
            employeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quatiteNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox rechercherPieceGroupBox;
        private Button rechercherRecetteButton;
        private TextBox numeroPieceTextBox;
        private DataGridView pieceDesireDGV;
        private Label label2;
        private Label numeroPieceLabel;
        private GroupBox commandeGroupBox;
        private GroupBox employeGroupBox;
        private Label choisirCommandeLabel;
        private ComboBox choisirCommandeComboBox;
        private Label choisirEmployeLabel;
        private ComboBox choisirEmployeComboBox;
        private Button choisirEmployeButton;
        private Label quantiteLabel;
        private NumericUpDown quatiteNUD;
        private Button ajoutezImputationButton;
    }
}