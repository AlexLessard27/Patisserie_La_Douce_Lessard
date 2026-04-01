using Patisserie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_Patisserie_LaDouche_Lessard
{
    public partial class ImputationPieceForm : Form
    {
        public ImputationPieceForm()
        {
            InitializeComponent();
        }

        private void rechercherIngredientButton_Click(object sender, EventArgs e)
        {
            using (var context = new LaDouceLessardContext())
            {
                var entreePiece = numeroPieceTextBox.Text;

                if (string.IsNullOrEmpty(entreePiece))
                {
                    MessageBox.Show("Champs vide");
                    return;
                }

                var resultats = context.Ingredients.Where(i => i.Description.Contains(entreePiece)).ToList();

                pieceDesireDGV.DataSource = resultats;
            }
        }

        private void commandeGroupBox_Enter(object sender, EventArgs e)
        {
            choisirCommandeComboBox.ValueMember = "IdCommande";
            choisirCommandeComboBox.DisplayMember = "Description";
            using (var context = new LaDouceLessardContext())
            {
                choisirCommandeComboBox.DataSource = context.Commandes.ToList();
            }
        }

        private void employeGroupBox_Enter(object sender, EventArgs e)
        {
            choisirEmployeComboBox.ValueMember = "IdEmploye";
            choisirEmployeComboBox.DisplayMember = "NomComplet";
            using (var context = new LaDouceLessardContext())
            {
                choisirEmployeComboBox.DataSource = context.Employes.ToList();
            }
        }
    }
}
