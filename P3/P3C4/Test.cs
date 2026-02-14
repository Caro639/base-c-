namespace P3C4;

public class Test
{
    public static void IsPalindrome_True()
    {
        string motTest = "radar";

        bool resultat = Methodes.IsPalindrome(motTest);

        if (!resultat)
        {
            throw new Exception($"Test échoué : '{motTest}' devrait être un palindrome");
        }
        Console.WriteLine($"Test réussi : IsPalindrome_True");
    }

    public static void IsPalindrome_False()
    {
        string motTest = "bonjour";

        bool resultat = Methodes.IsPalindrome(motTest);

        if (resultat)
        {
            throw new Exception($"Test échoué : '{motTest}' ne devrait pas être un palindrome");
        }
        Console.WriteLine($"Test réussi : IsPalindrome_False");
    }

    public static void PasswordIsValid_True()
    {
        string passwordTest = "motdepasse123";

        bool resultat = Methodes.PasswordIsValid(passwordTest);

        if (!resultat)
        {
            throw new Exception($"Test échoué : '{passwordTest}' devrait être valide");
        }
        Console.WriteLine($"Test réussi : PasswordIsValid_True");
    }

    public static void PasswordIsValid_False_TropCourt()
    {
        string passwordTest = "abc123";

        bool resultat = Methodes.PasswordIsValid(passwordTest);

        if (resultat)
        {
            throw new Exception($"Test échoué : '{passwordTest}' devrait être invalide (trop court)");
        }
        Console.WriteLine($"Test réussi : PasswordIsValid_False_TropCourt");
    }

    public static void PasswordIsValid_False_PasDeChiffre()
    {
        string passwordTest = "abcdefgh";

        bool resultat = Methodes.PasswordIsValid(passwordTest);

        if (resultat)
        {
            throw new Exception($"Test échoué : '{passwordTest}' devrait être invalide (pas de chiffre)");
        }
        Console.WriteLine($"Test réussi : PasswordIsValid_False_PasDeChiffre");
    }

}
