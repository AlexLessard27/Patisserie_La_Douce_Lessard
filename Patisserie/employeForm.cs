using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Patisserie.Models;

namespace Travail_Patisserie_LaDouche_Lessard
{
    public partial class employeForm : Form
    {
        public employeForm()
        {
            InitializeComponent();
        }

        private void employeForm_Load(object sender, EventArgs e)
        {
            employeIdTextBox.ReadOnly = true;
        }

        private void rechercherButton_Click(object sender, EventArgs e)
        {
            using (var context = new LaDouceLessardContext())
            {
                var entreeUtilisateur = rechercheEmployeTextBox.Text;

                if (string.IsNullOrEmpty(entreeUtilisateur))
                {
                    MessageBox.Show("Champs vide");
                    return;
                }

                var resultats = context.Employes.Where(e => e.Nom.Contains(entreeUtilisateur)
                                || e.Prenom.Contains(entreeUtilisateur))
                                .OrderBy(e => e.Nom)
                                .ThenBy(e => e.Prenom)
                                .ToList();

                selectionEmployeComboBox.DataSource = resultats;
                selectionEmployeComboBox.DisplayMember = "NomComplet";
            }
        }

        private void selectionEmployeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var employe = selectionEmployeComboBox.SelectedItem as Employe;

            if (employe != null)
            {
                employeIdTextBox.Text = employe.IdEmploye.ToString();
                employePrenomTextBox.Text = employe.Prenom;
                employeNomTextBox.Text = employe.Nom;
                employeEmailTextBox.Text = employe.AdresseCourriel;
            }
        }

        private void enregisterModifEmployeButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new LaDouceLessardContext())
                {
                    var employeSelectionne = selectionEmployeComboBox.SelectedItem as Employe;

                    if (employeSelectionne == null)
                    {
                        MessageBox.Show("Aucun employé sélectionné");
                        return;
                    }

                    var employe = context.Employes.FirstOrDefault(e => e.IdEmploye == employeSelectionne.IdEmploye);

                    if (employe == null)
                    {
                        MessageBox.Show("Employe introuvable");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(employePrenomTextBox.Text) || string.IsNullOrWhiteSpace(employeNomTextBox.Text))
                    {
                        MessageBox.Show("Nom et prénom obligatoires");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(employeEmailTextBox.Text))
                    {
                        MessageBox.Show("Email obligatoire");
                        return;
                    }

                    employe.Prenom = employePrenomTextBox.Text;
                    employe.Nom = employePrenomTextBox.Text;
                    employe.AdresseCourriel = employeEmailTextBox.Text;

                    context.SaveChanges();

                    MessageBox.Show("Les modifications ont été enregistrées");

                    selectionEmployeComboBox.DataSource = null;
                    employePrenomTextBox.Clear();
                    employePrenomTextBox.Clear();
                    employeEmailTextBox.Clear();
                }
            }
            catch (DbUpdateException ex)
            {
                var errorMessage = "Erreur, corrigez puis réessayer. \n\r";
                if (ex.InnerException is SqlException sqlException)
                {
                    errorMessage += $" Error Number: {sqlException.Number}\n\r Message: {sqlException.Message}\n\r";
                }
                throw new Exception(errorMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
