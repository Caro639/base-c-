//TODO : Créer une boucle for et while qui affiche à 5 reprises la phrase, « Je m'amuse comme un fou ! ».
using System; 
namespace Exercice_1;

 class Program 
{ 
    static void Main(string[] args)
    {

        for (int i = 0; i < 5; i++)
        {
            if (i == 4)
                {
                    continue;
                }
            Console.WriteLine("Je m'amuse comme un fou !");
        }


        // string phraseBoucle = "Je m'amuse comme un fou !";

        // int nombrePhrase = 0;

        // while (nombrePhrase < 5) 
        // { 
        //     nombrePhrase += 1;

        //     Console.WriteLine(phraseBoucle); 
        // }
        // Console.WriteLine("Fin de la boucle while");
    }
}
