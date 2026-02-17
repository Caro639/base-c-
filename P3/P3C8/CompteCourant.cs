namespace Compte
{
    public class CompteCourant : Compte
    {
        // Le constructeur appelle le constructeur de la classe parent (Compte)
        public CompteCourant(string nom, int numeroCompte, double soldeInitial)
            : base(nom, numeroCompte, soldeInitial)
        {
            // Le constructeur de base fait tout le travail
        }

        // Vous pouvez ajouter des méthodes spécifiques au compte courant ici
    }
}
