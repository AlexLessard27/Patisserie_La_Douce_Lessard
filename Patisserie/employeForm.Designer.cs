namespace Travail_Patisserie_LaDouche_Lessard
{
    partial class employeForm
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
            rechercheEmployeGroupBox = new GroupBox();
            selectionEmployeComboBox = new ComboBox();
            rechercheEmployeTextBox = new TextBox();
            rechercherButton = new Button();
            rechercheEmployeLabel = new Label();
            selectionEmployeLabel = new Label();
            modifEmployeGroupBox = new GroupBox();
            enregisterModifEmployeButton = new Button();
            employeIdLabel = new Label();
            employeEmailTextBox = new TextBox();
            employePrenomTextBox = new TextBox();
            employeNomTextBox = new TextBox();
            employeEmailLabel = new Label();
            employePrenomLabel = new Label();
            employeNomLabel = new Label();
            employeIdTextBox = new TextBox();
            rechercheEmployeGroupBox.SuspendLayout();
            modifEmployeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // rechercheEmployeGroupBox
            // 
            rechercheEmployeGroupBox.Controls.Add(selectionEmployeComboBox);
            rechercheEmployeGroupBox.Controls.Add(rechercheEmployeTextBox);
            rechercheEmployeGroupBox.Controls.Add(rechercherButton);
            rechercheEmployeGroupBox.Controls.Add(rechercheEmployeLabel);
            rechercheEmployeGroupBox.Controls.Add(selectionEmployeLabel);
            rechercheEmployeGroupBox.Font = new Font("Segoe UI", 16F);
            rechercheEmployeGroupBox.Location = new Point(14, 16);
            rechercheEmployeGroupBox.Margin = new Padding(3, 4, 3, 4);
            rechercheEmployeGroupBox.Name = "rechercheEmployeGroupBox";
            rechercheEmployeGroupBox.Padding = new Padding(3, 4, 3, 4);
            rechercheEmployeGroupBox.Size = new Size(887, 263);
            rechercheEmployeGroupBox.TabIndex = 0;
            rechercheEmployeGroupBox.TabStop = false;
            rechercheEmployeGroupBox.Text = "Rechercher un employé";
            // 
            // selectionEmployeComboBox
            // 
            selectionEmployeComboBox.Font = new Font("Segoe UI", 12F);
            selectionEmployeComboBox.FormattingEnabled = true;
            selectionEmployeComboBox.Location = new Point(328, 194);
            selectionEmployeComboBox.Margin = new Padding(3, 4, 3, 4);
            selectionEmployeComboBox.Name = "selectionEmployeComboBox";
            selectionEmployeComboBox.Size = new Size(553, 36);
            selectionEmployeComboBox.TabIndex = 5;
            selectionEmployeComboBox.SelectedIndexChanged += selectionEmployeComboBox_SelectedIndexChanged;
            // 
            // rechercheEmployeTextBox
            // 
            rechercheEmployeTextBox.Font = new Font("Segoe UI", 12F);
            rechercheEmployeTextBox.Location = new Point(328, 56);
            rechercheEmployeTextBox.Margin = new Padding(3, 4, 3, 4);
            rechercheEmployeTextBox.Name = "rechercheEmployeTextBox";
            rechercheEmployeTextBox.Size = new Size(553, 34);
            rechercheEmployeTextBox.TabIndex = 6;
            // 
            // rechercherButton
            // 
            rechercherButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rechercherButton.Location = new Point(706, 113);
            rechercherButton.Margin = new Padding(3, 4, 3, 4);
            rechercherButton.Name = "rechercherButton";
            rechercherButton.Size = new Size(161, 59);
            rechercherButton.TabIndex = 4;
            rechercherButton.Text = "Rechercher";
            rechercherButton.UseVisualStyleBackColor = true;
            rechercherButton.Click += rechercherButton_Click;
            // 
            // rechercheEmployeLabel
            // 
            rechercheEmployeLabel.AutoSize = true;
            rechercheEmployeLabel.Font = new Font("Segoe UI", 12F);
            rechercheEmployeLabel.Location = new Point(21, 59);
            rechercheEmployeLabel.Name = "rechercheEmployeLabel";
            rechercheEmployeLabel.Size = new Size(313, 28);
            rechercheEmployeLabel.TabIndex = 2;
            rechercheEmployeLabel.Text = "Entrez une un nom ou un prénom :";
            // 
            // selectionEmployeLabel
            // 
            selectionEmployeLabel.AutoSize = true;
            selectionEmployeLabel.Font = new Font("Segoe UI", 12F);
            selectionEmployeLabel.Location = new Point(21, 197);
            selectionEmployeLabel.Name = "selectionEmployeLabel";
            selectionEmployeLabel.Size = new Size(220, 28);
            selectionEmployeLabel.TabIndex = 3;
            selectionEmployeLabel.Text = "Sélectionner l'employé :";
            // 
            // modifEmployeGroupBox
            // 
            modifEmployeGroupBox.Controls.Add(enregisterModifEmployeButton);
            modifEmployeGroupBox.Controls.Add(employeIdLabel);
            modifEmployeGroupBox.Controls.Add(employeEmailTextBox);
            modifEmployeGroupBox.Controls.Add(employePrenomTextBox);
            modifEmployeGroupBox.Controls.Add(employeNomTextBox);
            modifEmployeGroupBox.Controls.Add(employeEmailLabel);
            modifEmployeGroupBox.Controls.Add(employePrenomLabel);
            modifEmployeGroupBox.Controls.Add(employeNomLabel);
            modifEmployeGroupBox.Controls.Add(employeIdTextBox);
            modifEmployeGroupBox.Font = new Font("Segoe UI", 16F);
            modifEmployeGroupBox.Location = new Point(14, 301);
            modifEmployeGroupBox.Margin = new Padding(3, 4, 3, 4);
            modifEmployeGroupBox.Name = "modifEmployeGroupBox";
            modifEmployeGroupBox.Padding = new Padding(3, 4, 3, 4);
            modifEmployeGroupBox.Size = new Size(887, 264);
            modifEmployeGroupBox.TabIndex = 1;
            modifEmployeGroupBox.TabStop = false;
            modifEmployeGroupBox.Text = "Modifier l'employé";
            // 
            // enregisterModifEmployeButton
            // 
            enregisterModifEmployeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enregisterModifEmployeButton.Location = new Point(653, 135);
            enregisterModifEmployeButton.Margin = new Padding(3, 4, 3, 4);
            enregisterModifEmployeButton.Name = "enregisterModifEmployeButton";
            enregisterModifEmployeButton.Size = new Size(215, 99);
            enregisterModifEmployeButton.TabIndex = 10;
            enregisterModifEmployeButton.Text = "Enregistrer la modification";
            enregisterModifEmployeButton.UseVisualStyleBackColor = true;
            enregisterModifEmployeButton.Click += enregisterModifEmployeButton_Click;
            // 
            // employeIdLabel
            // 
            employeIdLabel.AutoSize = true;
            employeIdLabel.Font = new Font("Segoe UI", 12F);
            employeIdLabel.Location = new Point(7, 52);
            employeIdLabel.Name = "employeIdLabel";
            employeIdLabel.Size = new Size(146, 28);
            employeIdLabel.TabIndex = 6;
            employeIdLabel.Text = "No d'employé :";
            // 
            // employeEmailTextBox
            // 
            employeEmailTextBox.Font = new Font("Segoe UI", 12F);
            employeEmailTextBox.Location = new Point(159, 195);
            employeEmailTextBox.Margin = new Padding(3, 4, 3, 4);
            employeEmailTextBox.Name = "employeEmailTextBox";
            employeEmailTextBox.Size = new Size(484, 34);
            employeEmailTextBox.TabIndex = 4;
            // 
            // employePrenomTextBox
            // 
            employePrenomTextBox.Font = new Font("Segoe UI", 12F);
            employePrenomTextBox.Location = new Point(159, 101);
            employePrenomTextBox.Margin = new Padding(3, 4, 3, 4);
            employePrenomTextBox.Name = "employePrenomTextBox";
            employePrenomTextBox.Size = new Size(484, 34);
            employePrenomTextBox.TabIndex = 5;
            // 
            // employeNomTextBox
            // 
            employeNomTextBox.Font = new Font("Segoe UI", 12F);
            employeNomTextBox.Location = new Point(159, 148);
            employeNomTextBox.Margin = new Padding(3, 4, 3, 4);
            employeNomTextBox.Name = "employeNomTextBox";
            employeNomTextBox.Size = new Size(484, 34);
            employeNomTextBox.TabIndex = 3;
            // 
            // employeEmailLabel
            // 
            employeEmailLabel.AutoSize = true;
            employeEmailLabel.Font = new Font("Segoe UI", 12F);
            employeEmailLabel.Location = new Point(7, 200);
            employeEmailLabel.Name = "employeEmailLabel";
            employeEmailLabel.Size = new Size(68, 28);
            employeEmailLabel.TabIndex = 9;
            employeEmailLabel.Text = "Email :";
            // 
            // employePrenomLabel
            // 
            employePrenomLabel.AutoSize = true;
            employePrenomLabel.Font = new Font("Segoe UI", 12F);
            employePrenomLabel.Location = new Point(7, 96);
            employePrenomLabel.Name = "employePrenomLabel";
            employePrenomLabel.Size = new Size(89, 28);
            employePrenomLabel.TabIndex = 7;
            employePrenomLabel.Text = "Prénom :";
            // 
            // employeNomLabel
            // 
            employeNomLabel.AutoSize = true;
            employeNomLabel.Font = new Font("Segoe UI", 12F);
            employeNomLabel.Location = new Point(7, 145);
            employeNomLabel.Name = "employeNomLabel";
            employeNomLabel.Size = new Size(65, 28);
            employeNomLabel.TabIndex = 8;
            employeNomLabel.Text = "Nom :";
            // 
            // employeIdTextBox
            // 
            employeIdTextBox.Font = new Font("Segoe UI", 12F);
            employeIdTextBox.Location = new Point(159, 52);
            employeIdTextBox.Margin = new Padding(3, 4, 3, 4);
            employeIdTextBox.Name = "employeIdTextBox";
            employeIdTextBox.Size = new Size(484, 34);
            employeIdTextBox.TabIndex = 2;
            // 
            // employeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(modifEmployeGroupBox);
            Controls.Add(rechercheEmployeGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "employeForm";
            Text = "employe";
            Load += employeForm_Load;
            rechercheEmployeGroupBox.ResumeLayout(false);
            rechercheEmployeGroupBox.PerformLayout();
            modifEmployeGroupBox.ResumeLayout(false);
            modifEmployeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox rechercheEmployeGroupBox;
        private GroupBox modifEmployeGroupBox;
        private Label rechercheEmployeLabel;
        private Label selectionEmployeLabel;
        private Button rechercherButton;
        private ComboBox selectionEmployeComboBox;
        private TextBox rechercheEmployeTextBox;
        private TextBox employeIdTextBox;
        private TextBox employeNomTextBox;
        private TextBox employeEmailTextBox;
        private TextBox employePrenomTextBox;
        private Label employeIdLabel;
        private Label employePrenomLabel;
        private Label employeNomLabel;
        private Label employeEmailLabel;
        private Button enregisterModifEmployeButton;
    }
}