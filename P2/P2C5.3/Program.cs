using System.Net.Http;

namespace Communication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            string chaineUrl = DonneeUtilisateur.DemanderUneUrl();

            var contenu = RecupererContenu(chaineUrl);

            try
            {
                EcrireFichier.Ecrire(contenu, "output.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine("Impossible d'écrire dans le fichier - " + e.ToString());
            }

            /// <summary>
            /// Retourner le contenu de l'URL
            /// </summary>
            /// <param name="url">L'URL de la ressource</param>
            static string RecupererContenu(string url)
            {
                string contenu = "";

                try
                {
                    using HttpClient httpClient = new();
                    {
                        contenu = httpClient.GetStringAsync(url).Result;
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Impossible d'établir une connexion - " + e.ToString());
                }

                return contenu;
            }
        }
    }
}