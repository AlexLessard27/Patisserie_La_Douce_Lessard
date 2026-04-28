using Patisserie.Models;
using System.Data;

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
            if (idCommande == null)
            {
                return;
            }

            using (var context = new LaDouceLessardContext())
            {
               
            }
        }
    }
}
