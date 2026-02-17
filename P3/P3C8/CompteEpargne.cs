namespace Compte
{
    public class CompteEpargne : Compte
    {
        // Le constructeur appelle le constructeur de la classe parent (Compte)
        public CompteEpargne(string nom, int numeroCompte, double soldeInitial)
            : base(nom, numeroCompte, soldeInitial)
        {
            // Le constructeur de base fait tout le travail
        }

        // Vous pouvez ajouter des méthodes spécifiques au compte épargne ici
        // exemple : calculer les intérêts, le taux d'intérêt, etc.
    }
}
