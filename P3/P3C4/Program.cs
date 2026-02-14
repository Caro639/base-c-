using P3C4;

// Affichage des résultats
Console.WriteLine("=== Tests de la méthode IsPalindrome ===");
Console.WriteLine($"'radar' est un palindrome : {Methodes.IsPalindrome("radar")}");
Console.WriteLine($"'kayak' est un palindrome : {Methodes.IsPalindrome("kayak")}");
Console.WriteLine($"'bonjour' est un palindrome : {Methodes.IsPalindrome("bonjour")}");
Console.WriteLine($"'Elu par cette crapule' est un palindrome : {Methodes.IsPalindrome("Elu par cette crapule")}");
Console.WriteLine();

Console.WriteLine("=== Tests de la méthode PasswordIsValid ===");
Console.WriteLine($"'password123' est valide : {Methodes.PasswordIsValid("password123")}");
Console.WriteLine($"'abcdefgh' est valide : {Methodes.PasswordIsValid("abcdefgh")}");
Console.WriteLine($"'abc123' est valide : {Methodes.PasswordIsValid("abc123")}");
Console.WriteLine($"'monMotDePasse1' est valide : {Methodes.PasswordIsValid("monMotDePasse1")}");
Console.WriteLine();

// Exécution des tests
Console.WriteLine("=== Exécution des tests ===");
Test.IsPalindrome_True();
Test.IsPalindrome_False();
Test.PasswordIsValid_True();
Test.PasswordIsValid_False_TropCourt();
Test.PasswordIsValid_False_PasDeChiffre();
Console.WriteLine("Tous les tests sont passés avec succès!");
Console.WriteLine();