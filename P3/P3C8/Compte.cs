namespace Compte
{
    public class Compte(string nom, int numeroCompte, double soldeInitial)
    {
        // Champs privés
        private string nom = nom;
        private int numeroCompte = numeroCompte;
        private double solde = soldeInitial;

        // Liste pour stocker les transactions
        private readonly List<string> transactions =
        [
            $"{DateTime.Now}: Solde initial: {soldeInitial} €"
        ];

        // Propriétés publiques pour accéder aux champs privés
        public string Nom => nom;
        public int NumeroCompte => numeroCompte;
        public double Solde => solde;
        public IReadOnlyList<string> Transactions => transactions.AsReadOnly();

        public void Afficher()
        {
            Console.WriteLine($"Nom: {nom}, Compte Numéro: {numeroCompte}, Solde: {solde} €");
        }

        public void Deposer(double montant)
        {
            solde += montant;
            string transaction = $"{DateTime.Now}: Dépôt de {montant} €. Nouveau solde: {solde} €";
            transactions.Add(transaction);
            Console.WriteLine($"Vous avez déposé : {montant} €");
        }

        public void Retirer(double montant)
        {
            if (montant > solde)
            {
                Console.WriteLine("Fonds insuffisants pour effectuer le retrait.");
            }
            else
            {
                solde -= montant;
                string transaction = $"{DateTime.Now}: Retrait de {montant} €. Nouveau solde: {solde} €";
                transactions.Add(transaction);
                Console.WriteLine($"Vous avez retiré : {montant} €");
            }
        }
    }
}