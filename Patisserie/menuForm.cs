namespace Travail_Patisserie_LaDouche_Lessard
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void employéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeForm = new employeForm();
            employeForm.ShowDialog();
        }

        private void imputationDePièceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var imputationForm = new ImputationPieceForm();
            imputationForm.ShowDialog();
        }

        private void rechercherUneCompagnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var compagnieForm = new rechercheCompagnieForm();
            compagnieForm.ShowDialog();
        }
    }
}
