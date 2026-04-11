using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Patisserie.Models;

namespace Travail_Patisserie_LaDouche_Lessard
{
    public partial class rechercheCompagnieForm : Form
    {
        public rechercheCompagnieForm()
        {
            InitializeComponent();
        }

        private void rechercherEagerButton_Click(object sender, EventArgs e)
        {
            using (var context = new LaDouceLessardContext())
            {
                var nomCompagnie = nomCompagnieEagerTextBox.Text;

                if (string.IsNullOrWhiteSpace(nomCompagnie))
                {
                    MessageBox.Show("Veillez entrer un nom de compagnie !");
                    return;
                }

                var compagnie = context.Clients
                    .Where(c => c.Nom.Contains(nomCompagnie))
                    .Include(c => c.Commandes)
                    .ToList();

                if (compagnie == null)
                {
                    MessageBox.Show("Aucune compagnie trouvée !");
                    return;
                }

                rechercheEagerDGV.DataSource = compagnie;
               
                rechercheEagerDGV.Columns["IdClient"].Visible = false;
                                  
            }
        }

        private void rechercheEagerDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (rechercheEagerDGV.CurrentRow == null)
                return;


            var compagnie = rechercheEagerDGV.CurrentRow.DataBoundItem as Client;

            if (compagnie == null)
                return;

            using (var context = new LaDouceLessardContext())
            {
                var compagnieCommande = context.Clients
                    .Where(c => c.IdClient == compagnie.IdClient)
                    .Include(c => c.Commandes)
                    .FirstOrDefault();

                var data = compagnieCommande?.Commandes.Select(c => new
                {
                    IdCommande = c.Nom,
                    Description = c.Description
                }).ToList();

                commandeEagerDGV.DataSource = data;
            }
        }

        private void rechercherExplicitButton_Click(object sender, EventArgs e)
        {
            using (var context = new LaDouceLessardContext())
            {
                var nom = nomCompagnieExplicitTextBox.Text;

                var compagnies = context.Clients
                    .Where(c => c.Nom.Contains(nom))
                    .OrderBy(c => c.Nom)
                    .ToList();

                rechercheExplicitDGV.DataSource = compagnies;
            }
        }

        private void rechercheExplicitDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (rechercheExplicitDGV.CurrentRow == null)
                return;

            var compagnie = rechercheExplicitDGV.CurrentRow.DataBoundItem as Client;

            if (compagnie == null)
                return;

            using (var context = new LaDouceLessardContext())
            {
                var compagnieCommande = context.Clients.FirstOrDefault(c => c.IdClient ==  compagnie.IdClient);

                if (compagnieCommande == null)
                    return;               

                context.Entry(compagnieCommande)
                    .Collection(c => c.Commandes)
                    .Load();

                var data = compagnieCommande.Commandes.Select(c => new
                {
                    IdCommande = c.Nom,
                    Description = c.Description
                }).ToList();

                commandeExplicitDGV.DataSource = data;

                rechercheExplicitDGV.Columns["IdClient"].Visible = false;
            }
        }
    }
}
