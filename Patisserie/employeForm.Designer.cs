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
            rechercheEmployeGroupBox.Location = new Point(12, 12);
            rechercheEmployeGroupBox.Name = "rechercheEmployeGroupBox";
            rechercheEmployeGroupBox.Size = new Size(776, 197);
            rechercheEmployeGroupBox.TabIndex = 0;
            rechercheEmployeGroupBox.TabStop = false;
            rechercheEmployeGroupBox.Text = "Rechercher un employé";
            // 
            // selectionEmployeComboBox
            // 
            selectionEmployeComboBox.Font = new Font("Segoe UI", 12F);
            selectionEmployeComboBox.FormattingEnabled = true;
            selectionEmployeComboBox.Location = new Point(275, 145);
            selectionEmployeComboBox.Name = "selectionEmployeComboBox";
            selectionEmployeComboBox.Size = new Size(484, 29);
            selectionEmployeComboBox.TabIndex = 5;
            selectionEmployeComboBox.SelectedIndexChanged += selectionEmployeComboBox_SelectedIndexChanged;
            // 
            // rechercheEmployeTextBox
            // 
            rechercheEmployeTextBox.Font = new Font("Segoe UI", 12F);
            rechercheEmployeTextBox.Location = new Point(275, 41);
            rechercheEmployeTextBox.Name = "rechercheEmployeTextBox";
            rechercheEmployeTextBox.Size = new Size(484, 29);
            rechercheEmployeTextBox.TabIndex = 6;
            // 
            // rechercherButton
            // 
            rechercherButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rechercherButton.Location = new Point(618, 85);
            rechercherButton.Name = "rechercherButton";
            rechercherButton.Size = new Size(141, 44);
            rechercherButton.TabIndex = 4;
            rechercherButton.Text = "Rechercher";
            rechercherButton.UseVisualStyleBackColor = true;
            rechercherButton.Click += rechercherButton_Click;
            // 
            // rechercheEmployeLabel
            // 
            rechercheEmployeLabel.AutoSize = true;
            rechercheEmployeLabel.Font = new Font("Segoe UI", 12F);
            rechercheEmployeLabel.Location = new Point(18, 44);
            rechercheEmployeLabel.Name = "rechercheEmployeLabel";
            rechercheEmployeLabel.Size = new Size(251, 21);
            rechercheEmployeLabel.TabIndex = 2;
            rechercheEmployeLabel.Text = "Entrez une un nom ou un prénom :";
            // 
            // selectionEmployeLabel
            // 
            selectionEmployeLabel.AutoSize = true;
            selectionEmployeLabel.Font = new Font("Segoe UI", 12F);
            selectionEmployeLabel.Location = new Point(18, 148);
            selectionEmployeLabel.Name = "selectionEmployeLabel";
            selectionEmployeLabel.Size = new Size(175, 21);
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
            modifEmployeGroupBox.Location = new Point(12, 226);
            modifEmployeGroupBox.Name = "modifEmployeGroupBox";
            modifEmployeGroupBox.Size = new Size(776, 198);
            modifEmployeGroupBox.TabIndex = 1;
            modifEmployeGroupBox.TabStop = false;
            modifEmployeGroupBox.Text = "Modifier l'employé";
            // 
            // enregisterModifEmployeButton
            // 
            enregisterModifEmployeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enregisterModifEmployeButton.Location = new Point(571, 101);
            enregisterModifEmployeButton.Name = "enregisterModifEmployeButton";
            enregisterModifEmployeButton.Size = new Size(188, 74);
            enregisterModifEmployeButton.TabIndex = 10;
            enregisterModifEmployeButton.Text = "Enregistrer la modification";
            enregisterModifEmployeButton.UseVisualStyleBackColor = true;
            enregisterModifEmployeButton.Click += enregisterModifEmployeButton_Click;
            // 
            // employeIdLabel
            // 
            employeIdLabel.AutoSize = true;
            employeIdLabel.Font = new Font("Segoe UI", 12F);
            employeIdLabel.Location = new Point(6, 39);
            employeIdLabel.Name = "employeIdLabel";
            employeIdLabel.Size = new Size(115, 21);
            employeIdLabel.TabIndex = 6;
            employeIdLabel.Text = "No d'employé :";
            // 
            // employeEmailTextBox
            // 
            employeEmailTextBox.Font = new Font("Segoe UI", 12F);
            employeEmailTextBox.Location = new Point(127, 146);
            employeEmailTextBox.Name = "employeEmailTextBox";
            employeEmailTextBox.Size = new Size(424, 29);
            employeEmailTextBox.TabIndex = 4;
            // 
            // employePrenomTextBox
            // 
            employePrenomTextBox.Font = new Font("Segoe UI", 12F);
            employePrenomTextBox.Location = new Point(127, 76);
            employePrenomTextBox.Name = "employePrenomTextBox";
            employePrenomTextBox.Size = new Size(424, 29);
            employePrenomTextBox.TabIndex = 5;
            // 
            // employeNomTextBox
            // 
            employeNomTextBox.Font = new Font("Segoe UI", 12F);
            employeNomTextBox.Location = new Point(127, 111);
            employeNomTextBox.Name = "employeNomTextBox";
            employeNomTextBox.Size = new Size(424, 29);
            employeNomTextBox.TabIndex = 3;
            // 
            // employeEmailLabel
            // 
            employeEmailLabel.AutoSize = true;
            employeEmailLabel.Font = new Font("Segoe UI", 12F);
            employeEmailLabel.Location = new Point(6, 150);
            employeEmailLabel.Name = "employeEmailLabel";
            employeEmailLabel.Size = new Size(55, 21);
            employeEmailLabel.TabIndex = 9;
            employeEmailLabel.Text = "Email :";
            // 
            // employePrenomLabel
            // 
            employePrenomLabel.AutoSize = true;
            employePrenomLabel.Font = new Font("Segoe UI", 12F);
            employePrenomLabel.Location = new Point(6, 72);
            employePrenomLabel.Name = "employePrenomLabel";
            employePrenomLabel.Size = new Size(72, 21);
            employePrenomLabel.TabIndex = 7;
            employePrenomLabel.Text = "Prénom :";
            // 
            // employeNomLabel
            // 
            employeNomLabel.AutoSize = true;
            employeNomLabel.Font = new Font("Segoe UI", 12F);
            employeNomLabel.Location = new Point(6, 109);
            employeNomLabel.Name = "employeNomLabel";
            employeNomLabel.Size = new Size(52, 21);
            employeNomLabel.TabIndex = 8;
            employeNomLabel.Text = "Nom :";
            // 
            // employeIdTextBox
            // 
            employeIdTextBox.Font = new Font("Segoe UI", 12F);
            employeIdTextBox.Location = new Point(127, 41);
            employeIdTextBox.Name = "employeIdTextBox";
            employeIdTextBox.Size = new Size(424, 29);
            employeIdTextBox.TabIndex = 2;
            // 
            // employeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modifEmployeGroupBox);
            Controls.Add(rechercheEmployeGroupBox);
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