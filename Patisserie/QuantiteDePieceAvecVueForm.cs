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

namespace Patisserie
{
    public partial class QuantiteDePieceAvecVueForm : Form
    {
        public QuantiteDePieceAvecVueForm()
        {
            InitializeComponent();
        }

        private void QuantiteDePieceAvecVueForm_Load(object sender, EventArgs e)
        {
            try
            {
                using var context = new LaDouceLessardContext();

                nomCommandeComboBox.DataSource = null;
                nomCommandeComboBox.DisplayMember = "Nom";
                nomCommandeComboBox.ValueMember = "IdCommande";
                nomCommandeComboBox.DataSource = context.Commandes
                    .OrderBy(e => e.Nom)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des commandes : " + ex.Message);
            }
        }

        private void nomCommandeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nomCommandeComboBox == null)
                {
                    return;
                }

                int idCommande = (int)nomCommandeComboBox.SelectedValue!;

                using var context = new LaDouceLessardContext();

                var resultat = context.VueIngredientQuantitePrevus.Where(v => v.IdCommande == idCommande).ToList();

                ingredientsVueDGV.DataSource = resultat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private async void detruireCommandeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ingredientsVueDGV.CurrentRow == null || ingredientsVueDGV.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner une commande à détruire.");
                    return;
                }

                var elementSelectionne =
                    (VueIngredientQuantitePrevu)ingredientsVueDGV.CurrentRow.DataBoundItem;

                var confirmation = MessageBox.Show(
                    "Voulez-vous vraiment détruire cette commande ?",
                    "Confirmation de destruction",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation != DialogResult.Yes)
                {
                    return;
                }

                using var context = new LaDouceLessardContext();

                await context.Procedures.Pro_SupprimerCommandeAsync(
                    elementSelectionne.IdCommande
                );

                MessageBox.Show("Commande détruite avec succès.");

                ingredientsVueDGV.DataSource = null;

                nomCommandeComboBox.DataSource = context.Commandes
                    .OrderBy(c => c.Nom)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la destruction de la commande : " + ex.Message);
            }
        }
    }
}
