ISet<string> ingredients = new HashSet<string>
{
    "sucre",
    "chocolat",
    "beurre",
    "vanille"
};

// ajouter un autre ingrédient à l'ensemble
ingredients.Add("farine");

// retirer la vanille de l'ensemble
ingredients.Remove("vanille");


// Afficher la liste des ingrédients
Console.WriteLine("Voici la liste de nos ingrédients");
foreach (string ingredient in ingredients)
{
    Console.WriteLine(ingredient);
}