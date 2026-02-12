// Remplacer le ?? par le code approprié pour créer une liste de chaînes

IList <string> invites = new List<string>();

// Ajouter Joe, Martin et Marie à la liste.
invites.Add("Joe");
invites.Add("Martin");
invites.Add("Marie");


// Compléter l'instruction suivante en remplaçant le ?? pour afficher la taille de la liste
Console.WriteLine(invites.Count);

// Remplacer Martin par Jean dans la liste
invites.Insert(1, "Jean");

// Retirer Joe de la liste
invites.RemoveAt(0);

// Afficher le contenu de la liste
Console.WriteLine("Les invités sont :");
foreach (string invite in invites)
{
    Console.WriteLine(invite);
}