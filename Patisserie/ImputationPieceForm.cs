using Patisserie.Models;

namespace Travail_Patisserie_LaDouche_Lessard
{
    public partial class ImputationPieceForm : Form
    {
        private Pro_RechercherRecettesResult? _recetteSelectionnee;

        public ImputationPieceForm()
        {
            InitializeComponent();

            pieceDesireDGV.AutoGenerateColumns = true;
            pieceDesireDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pieceDesireDGV.MultiSelect = false;
            pieceDesireDGV.ReadOnly = true;
            pieceDesireDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // IMPORTANT
            pieceDesireDGV.CellClick += pieceDesireDGV_CellClick;

            ChargerEmployes();
        }

        private void ChargerEmployes()
        {
            try
            {
                using var context = new LaDouceLessardContext();

                choisirEmployeComboBox.DataSource = null;
                choisirEmployeComboBox.DisplayMember = "NomComplet";
                choisirEmployeComboBox.ValueMember = "IdEmploye";
                choisirEmployeComboBox.DataSource = context.Employes
                    .OrderBy(e => e.Prenom)
                    .ThenBy(e => e.Nom)
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des employés : " + ex.Message);
            }
        }

        private async void rechercherRecetteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new LaDouceLessardContext();

                string recherche = numeroPieceTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(recherche))
                {
                    MessageBox.Show("Veuillez entrer une recherche.");
                    return;
                }

                var recettes = await context.Procedures.Pro_RechercherRecettesAsync(recherche);

                pieceDesireDGV.DataSource = null;
                choisirCommandeComboBox.DataSource = null;
                _recetteSelectionnee = null;

                if (recettes == null || recettes.Count == 0)
                {
                    MessageBox.Show("Aucune recette trouvée.");
                    return;
                }

                pieceDesireDGV.DataSource = recettes;

                if (pieceDesireDGV.Columns["Id_Recette"] != null)
                    pieceDesireDGV.Columns["Id_Recette"].HeaderText = "Id";

                if (pieceDesireDGV.Columns["Nom"] != null)
                    pieceDesireDGV.Columns["Nom"].HeaderText = "Nom de la recette";

                if (pieceDesireDGV.Columns["Description"] != null)
                    pieceDesireDGV.Columns["Description"].HeaderText = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche : " + ex.Message);
            }
        }

        private async void pieceDesireDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                _recetteSelectionnee = pieceDesireDGV.Rows[e.RowIndex].DataBoundItem as Pro_RechercherRecettesResult;

                if (_recetteSelectionnee == null)
                    return;

                using var context = new LaDouceLessardContext();

                var commandes = await context.Procedures.Pro_ObtenirCommandesParRecetteAsync(_recetteSelectionnee.Id_Recette);

                choisirCommandeComboBox.DataSource = null;

                if (commandes == null || commandes.Count == 0)
                {
                    MessageBox.Show("Aucune commande liée à cette recette.");
                    return;
                }

                choisirCommandeComboBox.DisplayMember = "NomCommande";
                choisirCommandeComboBox.ValueMember = "Id_Commande";
                choisirCommandeComboBox.DataSource = commandes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des commandes : " + ex.Message);
            }
        }

        private async void ajoutezImputationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_recetteSelectionnee == null)
                {
                    MessageBox.Show("Veuillez sélectionner une recette.");
                    return;
                }

                if (choisirCommandeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner une commande.");
                    return;
                }

                if (choisirEmployeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner un employé.");
                    return;
                }

                if (quatiteNUD.Value <= 0)
                {
                    MessageBox.Show("La quantité doit être supérieure à 0.");
                    return;
                }

                var commandeSelectionnee = (Pro_ObtenirCommandesParRecetteResult)choisirCommandeComboBox.SelectedItem;
                var employeSelectionne = (Employe)choisirEmployeComboBox.SelectedItem;

                using var context = new LaDouceLessardContext();

                await context.Procedures.Pro_AjouterImputationRecetteAsync(
                    DateOnly.FromDateTime(DateTime.Now),
                    quatiteNUD.Value,
                    commandeSelectionnee.Id_Commande,
                    employeSelectionne.IdEmploye,
                    _recetteSelectionnee.Id_Recette,
                    1
                );

                MessageBox.Show("Imputation ajoutée avec succès.");
                quatiteNUD.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'imputation : " + ex.Message);
            }
        }
    }
}