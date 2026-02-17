// See https://aka.ms/new-console-template for more information
namespace Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création du compte courant et du compte épargne
            CompteCourant compteCourant = new("Alice Martin", 12345, 0);
            CompteEpargne compteEpargne = new("Alice Martin", 67890, 0);

            Console.WriteLine("Appuyez sur Entrée pour afficher le menu.");
            Console.ReadLine();

            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string? choix = Console.ReadLine()?.ToUpper();

                switch (choix)
                {
                    case "I":
                        AfficherInfoTitulaire(compteCourant, compteEpargne);
                        break;
                    case "CS":
                        Console.WriteLine($"Solde du compte courant : {compteCourant.Solde} €");
                        break;
                    case "CD":
                        EffectuerDepot(compteCourant);
                        break;
                    case "CR":
                        EffectuerRetrait(compteCourant);
                        break;
                    case "ES":
                        Console.WriteLine($"Solde du compte épargne : {compteEpargne.Solde} €");
                        break;
                    case "ED":
                        EffectuerDepot(compteEpargne);
                        break;
                    case "ER":
                        EffectuerRetrait(compteEpargne);
                        break;
                    case "X":
                        continuer = false;
                        SauvegarderTransactions(compteCourant, compteEpargne);
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }

                if (continuer)
                {
                    Console.WriteLine("Appuyez sur Entrée pour afficher le menu.");
                    Console.ReadLine();
                }
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Veuillez sélectionner une option ci-dessous :");
            Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
            Console.WriteLine("[CS] Compte courant - Consulter le solde");
            Console.WriteLine("[CD] Compte courant - Déposer des fonds");
            Console.WriteLine("[CR] Compte courant - Retirer des fonds");
            Console.WriteLine("[ES] Compte épargne - Consulter le solde");
            Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
            Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
            Console.WriteLine("[X] Quitter");
            Console.WriteLine();
        }

        static void AfficherInfoTitulaire(CompteCourant cc, CompteEpargne ce)
        {
            Console.WriteLine($"Nom du titulaire : {cc.Nom}");
            Console.WriteLine($"Numéro du compte courant : {cc.NumeroCompte}");
            Console.WriteLine($"Numéro du compte épargne : {ce.NumeroCompte}");
        }

        static void EffectuerDepot(Compte compte)
        {
            Console.Write("Quel montant souhaitez-vous déposer ? ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double montant) && montant > 0)
            {
                compte.Deposer(montant);
            }
            else
            {
                Console.WriteLine("Montant invalide.");
            }
        }

        static void EffectuerRetrait(Compte compte)
        {
            Console.Write("Quel montant souhaitez-vous retirer ? ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double montant) && montant > 0)
            {
                compte.Retirer(montant);
            }
            else
            {
                Console.WriteLine("Montant invalide.");
            }
        }

        static void SauvegarderTransactions(CompteCourant cc, CompteEpargne ce)
        {
            string fichier = "transactions.txt";

            using (StreamWriter writer = new(fichier))
            {
                writer.WriteLine("=== HISTORIQUE DES TRANSACTIONS ===");
                writer.WriteLine();
                writer.WriteLine("--- COMPTE COURANT ---");
                foreach (string transaction in cc.Transactions)
                {
                    writer.WriteLine(transaction);
                }

                writer.WriteLine();
                writer.WriteLine("--- COMPTE ÉPARGNE ---");
                foreach (string transaction in ce.Transactions)
                {
                    writer.WriteLine(transaction);
                }
            }

            Console.WriteLine($"Les transactions ont été sauvegardées dans {fichier}");
        }
    }
}
