namespace Patisserie.Models
{
    public partial class Employe
    {
        public string NomComplet => Prenom + " " + Nom + ", " + AdresseCourriel;
    }
}
