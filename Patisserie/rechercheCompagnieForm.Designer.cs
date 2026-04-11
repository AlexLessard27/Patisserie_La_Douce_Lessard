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
            rechercherEagerButton = new Button();
            nomCompagnieEagerTextBox = new TextBox();
            nomCompagnieEager = new Label();
            projetCompagnieEagerLabel = new Label();
            projetEagerDGV = new DataGridView();
            rechercheEagerDGV = new DataGridView();
            groupBox2 = new GroupBox();
            rechercherExplicitButton = new Button();
            nomCompagnieExplicitTextBox = new TextBox();
            nomCompagnieExplicitLabel = new Label();
            projetCompagnieExplicitLabel = new Label();
            projetExplicitDGV = new DataGridView();
            rechercheExplicitDGV = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projetEagerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rechercheEagerDGV).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)projetExplicitDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rechercheExplicitDGV).BeginInit();
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
            // rechercherEagerButton
            // 
            rechercherEagerButton.Location = new Point(370, 68);
            rechercherEagerButton.Name = "rechercherEagerButton";
            rechercherEagerButton.Size = new Size(156, 36);
            rechercherEagerButton.TabIndex = 5;
            rechercherEagerButton.Text = "Rechercher Eager";
            rechercherEagerButton.UseVisualStyleBackColor = true;
            rechercherEagerButton.Click += rechercherEagerButton_Click;
            // 
            // nomCompagnieEagerTextBox
            // 
            nomCompagnieEagerTextBox.Location = new Point(182, 33);
            nomCompagnieEagerTextBox.Name = "nomCompagnieEagerTextBox";
            nomCompagnieEagerTextBox.Size = new Size(344, 29);
            nomCompagnieEagerTextBox.TabIndex = 4;
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
            // projetCompagnieEagerLabel
            // 
            projetCompagnieEagerLabel.AutoSize = true;
            projetCompagnieEagerLabel.Location = new Point(6, 274);
            projetCompagnieEagerLabel.Name = "projetCompagnieEagerLabel";
            projetCompagnieEagerLabel.Size = new Size(169, 21);
            projetCompagnieEagerLabel.TabIndex = 2;
            projetCompagnieEagerLabel.Text = "Projet de la compagnie";
            // 
            // projetEagerDGV
            // 
            projetEagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projetEagerDGV.Location = new Point(6, 298);
            projetEagerDGV.Name = "projetEagerDGV";
            projetEagerDGV.Size = new Size(520, 150);
            projetEagerDGV.TabIndex = 1;
            // 
            // rechercheEagerDGV
            // 
            rechercheEagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rechercheEagerDGV.Location = new Point(6, 119);
            rechercheEagerDGV.Name = "rechercheEagerDGV";
            rechercheEagerDGV.Size = new Size(520, 135);
            rechercheEagerDGV.TabIndex = 0;
            rechercheEagerDGV.SelectionChanged += rechercheEagerDGV_SelectionChanged;
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
            // rechercherExplicitButton
            // 
            rechercherExplicitButton.Location = new Point(389, 68);
            rechercherExplicitButton.Name = "rechercherExplicitButton";
            rechercherExplicitButton.Size = new Size(156, 36);
            rechercherExplicitButton.TabIndex = 6;
            rechercherExplicitButton.Text = "Rechercher Explicit";
            rechercherExplicitButton.UseVisualStyleBackColor = true;
            rechercherExplicitButton.Click += rechercherExplicitButton_Click;
            // 
            // nomCompagnieExplicitTextBox
            // 
            nomCompagnieExplicitTextBox.Location = new Point(182, 30);
            nomCompagnieExplicitTextBox.Name = "nomCompagnieExplicitTextBox";
            nomCompagnieExplicitTextBox.Size = new Size(363, 29);
            nomCompagnieExplicitTextBox.TabIndex = 5;
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
            // projetCompagnieExplicitLabel
            // 
            projetCompagnieExplicitLabel.AutoSize = true;
            projetCompagnieExplicitLabel.Location = new Point(6, 274);
            projetCompagnieExplicitLabel.Name = "projetCompagnieExplicitLabel";
            projetCompagnieExplicitLabel.Size = new Size(169, 21);
            projetCompagnieExplicitLabel.TabIndex = 3;
            projetCompagnieExplicitLabel.Text = "Projet de la compagnie";
            // 
            // projetExplicitDGV
            // 
            projetExplicitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projetExplicitDGV.Location = new Point(6, 298);
            projetExplicitDGV.Name = "projetExplicitDGV";
            projetExplicitDGV.Size = new Size(539, 150);
            projetExplicitDGV.TabIndex = 2;
            // 
            // rechercheExplicitDGV
            // 
            rechercheExplicitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rechercheExplicitDGV.Location = new Point(6, 119);
            rechercheExplicitDGV.Name = "rechercheExplicitDGV";
            rechercheExplicitDGV.Size = new Size(539, 135);
            rechercheExplicitDGV.TabIndex = 1;
            rechercheExplicitDGV.SelectionChanged += rechercheExplicitDGV_SelectionChanged;
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
            ((System.ComponentModel.ISupportInitialize)projetEagerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rechercheEagerDGV).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)projetExplicitDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rechercheExplicitDGV).EndInit();
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