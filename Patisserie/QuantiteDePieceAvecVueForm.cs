using System.Data;
using Patisserie.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
                if (nomCommandeComboBox.SelectedValue == null || nomCommandeComboBox.SelectedValue is not int idCommande)
                {
                    ingredientsVueDGV.DataSource = null;
                    return;
                }

                using var context = new LaDouceLessardContext();

                var resultat = context.VueIngredientQuantitePrevus.Where(v => v.IdCommande == idCommande).ToList();

                ingredientsVueDGV.DataSource = resultat;

                ingredientsVueDGV.ReadOnly = false;
                ingredientsVueDGV.Columns["IdCommande"]!.ReadOnly = true;
                ingredientsVueDGV.Columns["Description"]!.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void ingredientsVueDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (ingredientsVueDGV.Columns[e.ColumnIndex].Name == "QuantitePrevue")
            {
                var cellule = ingredientsVueDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cellule.Value != null)
                {
                    int nouvelleValeur;

                    if (int.TryParse(cellule.Value.ToString(), out nouvelleValeur))
                    {
                        var idCommande = ingredientsVueDGV.Rows[e.RowIndex].Cells["IdCommande"].Value;
                        var idRecette = ingredientsVueDGV.Rows[e.RowIndex].Cells["IdRecette"].Value;
                        var idIngredient = ingredientsVueDGV.Rows[e.RowIndex].Cells["IdIngredient"].Value;

                        Enregistrer(idCommande, idRecette, idIngredient, nouvelleValeur);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un nombre valide !");
                }
            }
        }

        private void Enregistrer(object? idCommande, object? idRecette, object? idIngredient, int nouvelleValeur)
        {
            if (idCommande == null || idRecette == null || idIngredient == null)
            {
                return;
            }

            int cmdId = Convert.ToInt32(idCommande);
            int recId = Convert.ToInt32(idRecette);

            try
            {
                using (var context = new LaDouceLessardContext())
                {
                    var utilise = context.Utilises.FirstOrDefault(u => u.IdCommande == cmdId && u.IdRecette == recId);

                    if (utilise == null)
                    {
                        return;
                    }

                    int ancienneValeur = utilise.QuantitePrevue;

                    if (nouvelleValeur <= 0)
                    {
                        MessageBox.Show("La quantité prévue doit être supérieur à 0 !");

                        RevenirAncienneValeur(cmdId, recId, idIngredient, ancienneValeur);

                        return;
                    }

                    utilise.QuantitePrevue = nouvelleValeur;

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);

                RevenirAncienneValeur(Convert.ToInt32(idCommande), Convert.ToInt32(idRecette), idIngredient, null);
            }

        }

        private void RevenirAncienneValeur(int idCommande, int idRecette, object idIngredient, int? ancienneValeur)
        {
            foreach (DataGridViewRow row in ingredientsVueDGV.Rows)
            {
                if (Convert.ToInt32(row.Cells["IdCommande"].Value) == idCommande &&
                    Convert.ToInt32(row.Cells["IdRecette"].Value) == idRecette &&
                    Convert.ToInt32(row.Cells["IdIngredient"].Value) == Convert.ToInt32(idIngredient))
                {
                    if (ancienneValeur != null)
                    {
                        row.Cells["QuantitePrevue"].Value = ancienneValeur;

                        break;
                    }
                }
            }
        }

        private void detruireCommandeButton_Click(object sender, EventArgs e)
        {
            if (nomCommandeComboBox.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une commande à détruire.");
                return;
            }

            if (!int.TryParse(nomCommandeComboBox.SelectedValue.ToString(), out int idCommande))
            {
                MessageBox.Show("La commande sélectionnée est invalide.");
                return;
            }

            string nomCommande = nomCommandeComboBox.Text;

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous vraiment détruire la commande \"{nomCommande}\" et ses liens avec les recettes ?",
                "Confirmation de destruction",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var context = new LaDouceLessardContext();

                context.Database.ExecuteSqlRaw(
                    "EXEC dbo.Pro_SupprimerCommande @Id_Commande = {0}",
                    idCommande
                );

                MessageBox.Show("La commande a été détruite avec succès.");

                RafraichirCommandes();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Suppression impossible",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erreur lors de la destruction de la commande : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void RafraichirCommandes()
        {
            try
            {
                using var context = new LaDouceLessardContext();

                var commandes = context.Commandes
                    .OrderBy(c => c.Nom)
                    .ToList();

                nomCommandeComboBox.DataSource = null;

                if (commandes.Count == 0)
                {
                    ingredientsVueDGV.DataSource = null;
                    return;
                }

                nomCommandeComboBox.DisplayMember = "Nom";
                nomCommandeComboBox.ValueMember = "IdCommande";
                nomCommandeComboBox.DataSource = commandes;

                nomCommandeComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du rafraîchissement des commandes : " + ex.Message);
            }
        }
    }
}
