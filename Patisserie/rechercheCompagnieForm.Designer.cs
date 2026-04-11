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
            nomDuClientEager = new Label();
            CommandeCompagnieEagerLabel = new Label();
            commandeEagerDGV = new DataGridView();
            rechercheEagerDGV = new DataGridView();
            groupBox2 = new GroupBox();
            rechercherExplicitButton = new Button();
            nomCompagnieExplicitTextBox = new TextBox();
            nomDuClientExplicitLabel = new Label();
            CommandeCompagnieExplicitLabel = new Label();
            commandeExplicitDGV = new DataGridView();
            rechercheExplicitDGV = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)commandeEagerDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rechercheEagerDGV).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)commandeExplicitDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rechercheExplicitDGV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(rechercherEagerButton);
            groupBox1.Controls.Add(nomCompagnieEagerTextBox);
            groupBox1.Controls.Add(nomDuClientEager);
            groupBox1.Controls.Add(CommandeCompagnieEagerLabel);
            groupBox1.Controls.Add(commandeEagerDGV);
            groupBox1.Controls.Add(rechercheEagerDGV);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(608, 632);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recherche un client (Eager)";
            // 
            // rechercherEagerButton
            // 
            rechercherEagerButton.Location = new Point(410, 91);
            rechercherEagerButton.Margin = new Padding(3, 4, 3, 4);
            rechercherEagerButton.Name = "rechercherEagerButton";
            rechercherEagerButton.Size = new Size(191, 48);
            rechercherEagerButton.TabIndex = 5;
            rechercherEagerButton.Text = "Rechercher Eager";
            rechercherEagerButton.UseVisualStyleBackColor = true;
            rechercherEagerButton.Click += rechercherEagerButton_Click;
            // 
            // nomCompagnieEagerTextBox
            // 
            nomCompagnieEagerTextBox.Location = new Point(228, 44);
            nomCompagnieEagerTextBox.Margin = new Padding(3, 4, 3, 4);
            nomCompagnieEagerTextBox.Name = "nomCompagnieEagerTextBox";
            nomCompagnieEagerTextBox.Size = new Size(373, 34);
            nomCompagnieEagerTextBox.TabIndex = 4;
            // 
            // nomDuClientEager
            // 
            nomDuClientEager.AutoSize = true;
            nomDuClientEager.Location = new Point(7, 48);
            nomDuClientEager.Name = "nomDuClientEager";
            nomDuClientEager.Size = new Size(145, 28);
            nomDuClientEager.TabIndex = 3;
            nomDuClientEager.Text = "Nom du client :";
            // 
            // CommandeCompagnieEagerLabel
            // 
            CommandeCompagnieEagerLabel.AutoSize = true;
            CommandeCompagnieEagerLabel.Location = new Point(7, 365);
            CommandeCompagnieEagerLabel.Name = "CommandeCompagnieEagerLabel";
            CommandeCompagnieEagerLabel.Size = new Size(263, 28);
            CommandeCompagnieEagerLabel.TabIndex = 2;
            CommandeCompagnieEagerLabel.Text = "Commande de la compagnie";
            // 
            // commandeEagerDGV
            // 
            commandeEagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            commandeEagerDGV.Location = new Point(7, 397);
            commandeEagerDGV.Margin = new Padding(3, 4, 3, 4);
            commandeEagerDGV.Name = "commandeEagerDGV";
            commandeEagerDGV.RowHeadersWidth = 51;
            commandeEagerDGV.Size = new Size(594, 200);
            commandeEagerDGV.TabIndex = 1;
            // 
            // rechercheEagerDGV
            // 
            rechercheEagerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rechercheEagerDGV.Location = new Point(7, 159);
            rechercheEagerDGV.Margin = new Padding(3, 4, 3, 4);
            rechercheEagerDGV.Name = "rechercheEagerDGV";
            rechercheEagerDGV.RowHeadersWidth = 51;
            rechercheEagerDGV.Size = new Size(594, 180);
            rechercheEagerDGV.TabIndex = 0;
            rechercheEagerDGV.SelectionChanged += rechercheEagerDGV_SelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(rechercherExplicitButton);
            groupBox2.Controls.Add(nomCompagnieExplicitTextBox);
            groupBox2.Controls.Add(nomDuClientExplicitLabel);
            groupBox2.Controls.Add(CommandeCompagnieExplicitLabel);
            groupBox2.Controls.Add(commandeExplicitDGV);
            groupBox2.Controls.Add(rechercheExplicitDGV);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(640, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(630, 632);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recherche un client (Explicit)";
            // 
            // rechercherExplicitButton
            // 
            rechercherExplicitButton.Location = new Point(432, 91);
            rechercherExplicitButton.Margin = new Padding(3, 4, 3, 4);
            rechercherExplicitButton.Name = "rechercherExplicitButton";
            rechercherExplicitButton.Size = new Size(191, 48);
            rechercherExplicitButton.TabIndex = 6;
            rechercherExplicitButton.Text = "Rechercher Explicit";
            rechercherExplicitButton.UseVisualStyleBackColor = true;
            rechercherExplicitButton.Click += rechercherExplicitButton_Click;
            // 
            // nomCompagnieExplicitTextBox
            // 
            nomCompagnieExplicitTextBox.Location = new Point(218, 40);
            nomCompagnieExplicitTextBox.Margin = new Padding(3, 4, 3, 4);
            nomCompagnieExplicitTextBox.Name = "nomCompagnieExplicitTextBox";
            nomCompagnieExplicitTextBox.Size = new Size(404, 34);
            nomCompagnieExplicitTextBox.TabIndex = 5;
            // 
            // nomDuClientExplicitLabel
            // 
            nomDuClientExplicitLabel.AutoSize = true;
            nomDuClientExplicitLabel.Location = new Point(7, 44);
            nomDuClientExplicitLabel.Name = "nomDuClientExplicitLabel";
            nomDuClientExplicitLabel.Size = new Size(145, 28);
            nomDuClientExplicitLabel.TabIndex = 4;
            nomDuClientExplicitLabel.Text = "Nom du client :";
            // 
            // CommandeCompagnieExplicitLabel
            // 
            CommandeCompagnieExplicitLabel.AutoSize = true;
            CommandeCompagnieExplicitLabel.Location = new Point(7, 365);
            CommandeCompagnieExplicitLabel.Name = "CommandeCompagnieExplicitLabel";
            CommandeCompagnieExplicitLabel.Size = new Size(263, 28);
            CommandeCompagnieExplicitLabel.TabIndex = 3;
            CommandeCompagnieExplicitLabel.Text = "Commande de la compagnie";
            // 
            // commandeExplicitDGV
            // 
            commandeExplicitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            commandeExplicitDGV.Location = new Point(7, 397);
            commandeExplicitDGV.Margin = new Padding(3, 4, 3, 4);
            commandeExplicitDGV.Name = "commandeExplicitDGV";
            commandeExplicitDGV.RowHeadersWidth = 51;
            commandeExplicitDGV.Size = new Size(616, 200);
            commandeExplicitDGV.TabIndex = 2;
            // 
            // rechercheExplicitDGV
            // 
            rechercheExplicitDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rechercheExplicitDGV.Location = new Point(7, 159);
            rechercheExplicitDGV.Margin = new Padding(3, 4, 3, 4);
            rechercheExplicitDGV.Name = "rechercheExplicitDGV";
            rechercheExplicitDGV.RowHeadersWidth = 51;
            rechercheExplicitDGV.Size = new Size(616, 180);
            rechercheExplicitDGV.TabIndex = 1;
            rechercheExplicitDGV.SelectionChanged += rechercheExplicitDGV_SelectionChanged;
            // 
            // rechercheCompagnieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 640);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "rechercheCompagnieForm";
            Text = "rechercheCompagnieForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)commandeEagerDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rechercheEagerDGV).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)commandeExplicitDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)rechercheExplicitDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView commandeEagerDGV;
        private DataGridView rechercheEagerDGV;
        private DataGridView rechercheExplicitDGV;
        private Label CommandeCompagnieEagerLabel;
        private Label CommandeCompagnieExplicitLabel;
        private DataGridView commandeExplicitDGV;
        private Button rechercherEagerButton;
        private TextBox nomCompagnieEagerTextBox;
        private Label nomDuClientEager;
        private Button rechercherExplicitButton;
        private TextBox nomCompagnieExplicitTextBox;
        private Label nomDuClientExplicitLabel;
    }
}