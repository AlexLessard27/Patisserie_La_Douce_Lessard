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
            rechercherPIeceButton = new Button();
            numeroPieceTextBox = new TextBox();
            pieceDesireDGV = new DataGridView();
            label2 = new Label();
            numeroPieceLabel = new Label();
            commandeGroupBox = new GroupBox();
            choisirCommandeLabel = new Label();
            choisirCommandeComboBox = new ComboBox();
            employeGroupBox = new GroupBox();
            choisirEmployeLabel = new Label();
            comboBox1 = new ComboBox();
            choisirEmployeButton = new Button();
            quantiteLabel = new Label();
            quatiteNUD = new NumericUpDown();
            button1 = new Button();
            rechercherPieceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pieceDesireDGV).BeginInit();
            commandeGroupBox.SuspendLayout();
            employeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quatiteNUD).BeginInit();
            SuspendLayout();
            // 
            // rechercherPieceGroupBox
            // 
            rechercherPieceGroupBox.Controls.Add(rechercherPIeceButton);
            rechercherPieceGroupBox.Controls.Add(numeroPieceTextBox);
            rechercherPieceGroupBox.Controls.Add(pieceDesireDGV);
            rechercherPieceGroupBox.Controls.Add(label2);
            rechercherPieceGroupBox.Controls.Add(numeroPieceLabel);
            rechercherPieceGroupBox.Font = new Font("Segoe UI", 12F);
            rechercherPieceGroupBox.Location = new Point(12, 12);
            rechercherPieceGroupBox.Name = "rechercherPieceGroupBox";
            rechercherPieceGroupBox.Size = new Size(776, 259);
            rechercherPieceGroupBox.TabIndex = 0;
            rechercherPieceGroupBox.TabStop = false;
            rechercherPieceGroupBox.Text = "Rechercher une pièce avec ou sans scanneur";
            // 
            // rechercherPIeceButton
            // 
            rechercherPIeceButton.Location = new Point(467, 25);
            rechercherPIeceButton.Name = "rechercherPIeceButton";
            rechercherPIeceButton.Size = new Size(151, 29);
            rechercherPIeceButton.TabIndex = 6;
            rechercherPIeceButton.Text = "Rechercher";
            rechercherPIeceButton.UseVisualStyleBackColor = true;
            // 
            // numeroPieceTextBox
            // 
            numeroPieceTextBox.Location = new Point(160, 25);
            numeroPieceTextBox.Name = "numeroPieceTextBox";
            numeroPieceTextBox.Size = new Size(286, 29);
            numeroPieceTextBox.TabIndex = 5;
            // 
            // pieceDesireDGV
            // 
            pieceDesireDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pieceDesireDGV.Location = new Point(18, 89);
            pieceDesireDGV.Name = "pieceDesireDGV";
            pieceDesireDGV.Size = new Size(739, 150);
            pieceDesireDGV.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 62);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 3;
            label2.Text = "Sélectionner la pièce désirée";
            // 
            // numeroPieceLabel
            // 
            numeroPieceLabel.AutoSize = true;
            numeroPieceLabel.Location = new Point(18, 25);
            numeroPieceLabel.Name = "numeroPieceLabel";
            numeroPieceLabel.Size = new Size(136, 21);
            numeroPieceLabel.TabIndex = 2;
            numeroPieceLabel.Text = "Numéro de pièce :";
            // 
            // commandeGroupBox
            // 
            commandeGroupBox.Controls.Add(choisirCommandeLabel);
            commandeGroupBox.Controls.Add(choisirCommandeComboBox);
            commandeGroupBox.Font = new Font("Segoe UI", 12F);
            commandeGroupBox.Location = new Point(12, 277);
            commandeGroupBox.Name = "commandeGroupBox";
            commandeGroupBox.Size = new Size(776, 92);
            commandeGroupBox.TabIndex = 1;
            commandeGroupBox.TabStop = false;
            commandeGroupBox.Text = "Commande";
            // 
            // choisirCommandeLabel
            // 
            choisirCommandeLabel.AutoSize = true;
            choisirCommandeLabel.Location = new Point(6, 39);
            choisirCommandeLabel.Name = "choisirCommandeLabel";
            choisirCommandeLabel.Size = new Size(178, 21);
            choisirCommandeLabel.TabIndex = 1;
            choisirCommandeLabel.Text = "Choisir une commande :";
            // 
            // choisirCommandeComboBox
            // 
            choisirCommandeComboBox.FormattingEnabled = true;
            choisirCommandeComboBox.Location = new Point(214, 39);
            choisirCommandeComboBox.Name = "choisirCommandeComboBox";
            choisirCommandeComboBox.Size = new Size(326, 29);
            choisirCommandeComboBox.TabIndex = 0;
            // 
            // employeGroupBox
            // 
            employeGroupBox.Controls.Add(choisirEmployeLabel);
            employeGroupBox.Controls.Add(comboBox1);
            employeGroupBox.Controls.Add(choisirEmployeButton);
            employeGroupBox.Font = new Font("Segoe UI", 12F);
            employeGroupBox.Location = new Point(12, 375);
            employeGroupBox.Name = "employeGroupBox";
            employeGroupBox.Size = new Size(776, 83);
            employeGroupBox.TabIndex = 1;
            employeGroupBox.TabStop = false;
            employeGroupBox.Text = "Employé";
            // 
            // choisirEmployeLabel
            // 
            choisirEmployeLabel.AutoSize = true;
            choisirEmployeLabel.Location = new Point(6, 33);
            choisirEmployeLabel.Name = "choisirEmployeLabel";
            choisirEmployeLabel.Size = new Size(152, 21);
            choisirEmployeLabel.TabIndex = 2;
            choisirEmployeLabel.Text = "Choisir un employé :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 29);
            comboBox1.TabIndex = 1;
            // 
            // choisirEmployeButton
            // 
            choisirEmployeButton.Location = new Point(569, 28);
            choisirEmployeButton.Name = "choisirEmployeButton";
            choisirEmployeButton.Size = new Size(188, 31);
            choisirEmployeButton.TabIndex = 0;
            choisirEmployeButton.Text = "Choisir un employé";
            choisirEmployeButton.UseVisualStyleBackColor = true;
            // 
            // quantiteLabel
            // 
            quantiteLabel.AutoSize = true;
            quantiteLabel.Font = new Font("Segoe UI", 12F);
            quantiteLabel.Location = new Point(18, 475);
            quantiteLabel.Name = "quantiteLabel";
            quantiteLabel.Size = new Size(77, 21);
            quantiteLabel.TabIndex = 2;
            quantiteLabel.Text = "Quantité :";
            // 
            // quatiteNUD
            // 
            quatiteNUD.Location = new Point(116, 478);
            quatiteNUD.Name = "quatiteNUD";
            quatiteNUD.Size = new Size(120, 23);
            quatiteNUD.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(260, 475);
            button1.Name = "button1";
            button1.Size = new Size(175, 35);
            button1.TabIndex = 4;
            button1.Text = "Ajouter imputation";
            button1.UseVisualStyleBackColor = true;
            // 
            // ImputationPieceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(button1);
            Controls.Add(quatiteNUD);
            Controls.Add(quantiteLabel);
            Controls.Add(employeGroupBox);
            Controls.Add(commandeGroupBox);
            Controls.Add(rechercherPieceGroupBox);
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
        private Button rechercherPIeceButton;
        private TextBox numeroPieceTextBox;
        private DataGridView pieceDesireDGV;
        private Label label2;
        private Label numeroPieceLabel;
        private GroupBox commandeGroupBox;
        private GroupBox employeGroupBox;
        private Label choisirCommandeLabel;
        private ComboBox choisirCommandeComboBox;
        private Label choisirEmployeLabel;
        private ComboBox comboBox1;
        private Button choisirEmployeButton;
        private Label quantiteLabel;
        private NumericUpDown quatiteNUD;
        private Button button1;
    }
}