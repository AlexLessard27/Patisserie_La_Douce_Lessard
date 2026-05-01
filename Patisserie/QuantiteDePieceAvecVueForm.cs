using System.Data;
using System.Windows.Input;
using Patisserie.Models;

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

                ingredientsVueDGV.ReadOnly = false;
                ingredientsVueDGV.Columns["IdCommande"]!.ReadOnly = true;
                ingredientsVueDGV.Columns["Description"]!.ReadOnly = true;
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

        private void Enregistrer(object? idCommande, object? idRecette, object? idIngredient, int nouvelleValeur)
        {
            if (idCommande == null || idRecette ==  null || idIngredient == null)
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
    }
}
