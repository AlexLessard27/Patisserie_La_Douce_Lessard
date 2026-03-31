namespace Travail_Patisserie_LaDouche_Lessard
{
    partial class rechercheCompagnieForm
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            rechercheEagerDGV = new DataGridView();
            projetEagerDGV = new DataGridView();
            rechercheExplicitDGV = new DataGridView();
            projetExplicitDGV = new DataGridView();
            projetCompagnieEagerLabel = new Label();
            projetCompagnieExplicitLabel = new Label();
            nomCompagnieEager = new Label();
            nomCompagnieEagerTextBox = new TextBox();
            rechercherEagerButton = new Button();
            nomCompagnieExplicitLabel = new Label();
            nomCompagnieExplicitTextBox = new TextBox();
            rechercherExplicitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rechercheEagerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projetEagerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rechercheExplicitDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projetExplicitDGV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rechercherEagerButton);
            groupBox1.Controls.Add(nomCompagnieEagerTextBox);
            groupBox1.Controls.Add(nomCompagnieEager);
            groupBox1.Controls.Add(projetCompagnieEagerLabel);
            groupBox1.Controls.Add(projetEagerDGV);
            groupBox1.Controls.Add(rechercheEagerDGV);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 458);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recherche une compagnie (Eager)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rechercherExplicitButton);
            groupBox2.Controls.Add(nomCompagnieExplicitTextBox);
            groupBox2.Controls.Add(nomCompagnieExplicitLabel);
            groupBox2.Controls.Add(projetCompagnieExplicitLabel);
            groupBox2.Controls.Add(projetExplicitDGV);
            groupBox2.Controls.Add(rechercheExplicitDGV);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(560, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(551, 458);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recherche une compagnie (Explicit)";
            // 
            // rechercheEagerDGV
            // 
            rechercheEagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rechercheEagerDGV.Location = new Point(6, 119);
            rechercheEagerDGV.Name = "rechercheEagerDGV";
            rechercheEagerDGV.Size = new Size(520, 135);
            rechercheEagerDGV.TabIndex = 0;
            // 
            // projetEagerDGV
            // 
            projetEagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projetEagerDGV.Location = new Point(6, 298);
            projetEagerDGV.Name = "projetEagerDGV";
            projetEagerDGV.Size = new Size(520, 150);
            projetEagerDGV.TabIndex = 1;
            // 
            // rechercheExplicitDGV
            // 
            rechercheExplicitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rechercheExplicitDGV.Location = new Point(6, 119);
            rechercheExplicitDGV.Name = "rechercheExplicitDGV";
            rechercheExplicitDGV.Size = new Size(539, 135);
            rechercheExplicitDGV.TabIndex = 1;
            // 
            // projetExplicitDGV
            // 
            projetExplicitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projetExplicitDGV.Location = new Point(6, 298);
            projetExplicitDGV.Name = "projetExplicitDGV";
            projetExplicitDGV.Size = new Size(539, 150);
            projetExplicitDGV.TabIndex = 2;
            // 
            // projetCompagnieEagerLabel
            // 
            projetCompagnieEagerLabel.AutoSize = true;
            projetCompagnieEagerLabel.Location = new Point(6, 274);
            projetCompagnieEagerLabel.Name = "projetCompagnieEagerLabel";
            projetCompagnieEagerLabel.Size = new Size(169, 21);
            projetCompagnieEagerLabel.TabIndex = 2;
            projetCompagnieEagerLabel.Text = "Projet de la compagnie";
            // 
            // projetCompagnieExplicitLabel
            // 
            projetCompagnieExplicitLabel.AutoSize = true;
            projetCompagnieExplicitLabel.Location = new Point(6, 274);
            projetCompagnieExplicitLabel.Name = "projetCompagnieExplicitLabel";
            projetCompagnieExplicitLabel.Size = new Size(169, 21);
            projetCompagnieExplicitLabel.TabIndex = 3;
            projetCompagnieExplicitLabel.Text = "Projet de la compagnie";
            // 
            // nomCompagnieEager
            // 
            nomCompagnieEager.AutoSize = true;
            nomCompagnieEager.Location = new Point(6, 36);
            nomCompagnieEager.Name = "nomCompagnieEager";
            nomCompagnieEager.Size = new Size(170, 21);
            nomCompagnieEager.TabIndex = 3;
            nomCompagnieEager.Text = "Nom de la compagnie :";
            // 
            // nomCompagnieEagerTextBox
            // 
            nomCompagnieEagerTextBox.Location = new Point(182, 33);
            nomCompagnieEagerTextBox.Name = "nomCompagnieEagerTextBox";
            nomCompagnieEagerTextBox.Size = new Size(344, 29);
            nomCompagnieEagerTextBox.TabIndex = 4;
            // 
            // rechercherEagerButton
            // 
            rechercherEagerButton.Location = new Point(370, 68);
            rechercherEagerButton.Name = "rechercherEagerButton";
            rechercherEagerButton.Size = new Size(156, 36);
            rechercherEagerButton.TabIndex = 5;
            rechercherEagerButton.Text = "Rechercher Eager";
            rechercherEagerButton.UseVisualStyleBackColor = true;
            // 
            // nomCompagnieExplicitLabel
            // 
            nomCompagnieExplicitLabel.AutoSize = true;
            nomCompagnieExplicitLabel.Location = new Point(6, 33);
            nomCompagnieExplicitLabel.Name = "nomCompagnieExplicitLabel";
            nomCompagnieExplicitLabel.Size = new Size(170, 21);
            nomCompagnieExplicitLabel.TabIndex = 4;
            nomCompagnieExplicitLabel.Text = "Nom de la compagnie :";
            // 
            // nomCompagnieExplicitTextBox
            // 
            nomCompagnieExplicitTextBox.Location = new Point(182, 30);
            nomCompagnieExplicitTextBox.Name = "nomCompagnieExplicitTextBox";
            nomCompagnieExplicitTextBox.Size = new Size(363, 29);
            nomCompagnieExplicitTextBox.TabIndex = 5;
            // 
            // rechercherExplicitButton
            // 
            rechercherExplicitButton.Location = new Point(389, 68);
            rechercherExplicitButton.Name = "rechercherExplicitButton";
            rechercherExplicitButton.Size = new Size(156, 36);
            rechercherExplicitButton.TabIndex = 6;
            rechercherExplicitButton.Text = "Rechercher Explicit";
            rechercherExplicitButton.UseVisualStyleBackColor = true;
            // 
            // rechercheCompagnieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 480);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "rechercheCompagnieForm";
            Text = "rechercheCompagnieForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rechercheEagerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)projetEagerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rechercheExplicitDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)projetExplicitDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView projetEagerDGV;
        private DataGridView rechercheEagerDGV;
        private DataGridView rechercheExplicitDGV;
        private Label projetCompagnieEagerLabel;
        private Label projetCompagnieExplicitLabel;
        private DataGridView projetExplicitDGV;
        private Button rechercherEagerButton;
        private TextBox nomCompagnieEagerTextBox;
        private Label nomCompagnieEager;
        private Button rechercherExplicitButton;
        private TextBox nomCompagnieExplicitTextBox;
        private Label nomCompagnieExplicitLabel;
    }
}