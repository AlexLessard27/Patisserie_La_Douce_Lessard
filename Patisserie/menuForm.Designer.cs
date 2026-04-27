namespace Travail_Patisserie_LaDouche_Lessard
{
    partial class menuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            employéToolStripMenuItem = new ToolStripMenuItem();
            imputationDePièceToolStripMenuItem = new ToolStripMenuItem();
            rechercherUneCompagnieToolStripMenuItem = new ToolStripMenuItem();
            quantitéDePièceToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { employéToolStripMenuItem, imputationDePièceToolStripMenuItem, rechercherUneCompagnieToolStripMenuItem, quantitéDePièceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // employéToolStripMenuItem
            // 
            employéToolStripMenuItem.Name = "employéToolStripMenuItem";
            employéToolStripMenuItem.Size = new Size(223, 20);
            employéToolStripMenuItem.Text = "Recherche/Modification d'un employé";
            employéToolStripMenuItem.Click += employéToolStripMenuItem_Click;
            // 
            // imputationDePièceToolStripMenuItem
            // 
            imputationDePièceToolStripMenuItem.Name = "imputationDePièceToolStripMenuItem";
            imputationDePièceToolStripMenuItem.Size = new Size(125, 20);
            imputationDePièceToolStripMenuItem.Text = "Imputation de pièce";
            imputationDePièceToolStripMenuItem.Click += imputationDePièceToolStripMenuItem_Click;
            // 
            // rechercherUneCompagnieToolStripMenuItem
            // 
            rechercherUneCompagnieToolStripMenuItem.Name = "rechercherUneCompagnieToolStripMenuItem";
            rechercherUneCompagnieToolStripMenuItem.Size = new Size(164, 20);
            rechercherUneCompagnieToolStripMenuItem.Text = "Rechercher une compagnie";
            rechercherUneCompagnieToolStripMenuItem.Click += rechercherUneCompagnieToolStripMenuItem_Click;
            // 
            // quantitéDePièceToolStripMenuItem
            // 
            quantitéDePièceToolStripMenuItem.Name = "quantitéDePièceToolStripMenuItem";
            quantitéDePièceToolStripMenuItem.Size = new Size(143, 20);
            quantitéDePièceToolStripMenuItem.Text = "Quantité de pièce (Vue)";
            quantitéDePièceToolStripMenuItem.Click += quantitéDePièceToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.Location = new Point(127, 51);
            label1.Name = "label1";
            label1.Size = new Size(552, 59);
            label1.TabIndex = 1;
            label1.Text = "Travail : Base de Donnée 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(147, 127);
            label2.Name = "label2";
            label2.Size = new Size(505, 54);
            label2.TabIndex = 2;
            label2.Text = "Patisserie La Douce Lessard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F);
            label3.Location = new Point(16, 19);
            label3.Name = "label3";
            label3.Size = new Size(364, 47);
            label3.TabIndex = 3;
            label3.Text = "Membres de l'équipe :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(79, 76);
            label4.Name = "label4";
            label4.Size = new Size(226, 37);
            label4.TabIndex = 4;
            label4.Text = "Steven Ladouceur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(79, 128);
            label5.Name = "label5";
            label5.Size = new Size(230, 37);
            label5.TabIndex = 5;
            label5.Text = "Alexandre Lessard";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(184, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 190);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // menuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "menuForm";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem employéToolStripMenuItem;
        private ToolStripMenuItem imputationDePièceToolStripMenuItem;
        private ToolStripMenuItem rechercherUneCompagnieToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ToolStripMenuItem quantitéDePièceToolStripMenuItem;
    }
}
