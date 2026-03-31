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

                var resultats = context.Employes.Where(e => e.Nom.Contains(entreeUtilisateur) || e.Prenom.Contains(entreeUtilisateur)).ToList();

                selectionEmployeComboBox.DataSource = resultats;
                selectionEmployeComboBox.DisplayMember = "NomComplet";
            }
        }
    }
}
