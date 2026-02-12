// Définir l'URL à laquelle se connecter
using System.Net.Http;

namespace Communication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            string chaineUrl = DonneeUtilisateur.DemanderUneUrl();

            Console.WriteLine(await RecupererContenu(chaineUrl));

            /// <summary>
            /// Retourner le contenu de l'URL
            /// </summary>
            /// <param name="url">L'adresse Web dont le contenu sera renvoyé</param>
            async Task<string> RecupererContenu(string url)
            {
                string contenu = "";

                try
                {
                    using HttpClient client = new();
                    contenu = await client.GetStringAsync(url);
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