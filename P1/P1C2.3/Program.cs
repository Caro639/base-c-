// étape 1 :
// Créer une variable nommée jourDeDepart avec pour valeur initiale 3
int jourDeDepart = 3;

// étape 2 :
// Créer une constante nommée joursDansSemaine avec pour valeur 7
const int joursDansSemaine = 7;

// étape 3 :
// Utiliser un opérateur de raccourci pour ajouter la valeur de la constante joursDansSemaine à la variable jourDeDepart
jourDeDepart += joursDansSemaine;

// Afficher le résultat 
Console.WriteLine("Il y a " + joursDansSemaine + " jours dans la semaine.");
Console.WriteLine("Votre jour de départ du mois est : " + jourDeDepart);