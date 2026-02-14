namespace P3C4;

public class Methodes
{
    // Méthode 1 : Vérifier si un mot est un palindrome
    public static bool IsPalindrome(string mot)
    {
        if (string.IsNullOrEmpty(mot))
            return false;

        string motNettoye = mot.ToLower().Replace(" ", "");
        int longueur = motNettoye.Length;

        for (int i = 0; i < longueur / 2; i++)
        {
            if (motNettoye[i] != motNettoye[longueur - 1 - i])
                return false;
        }

        return true;
    }

    // Méthode 2 : Valider un mot de passe (min 8 caractères + au moins 1 chiffre)
    public static bool PasswordIsValid(string password)
    {
        // Vérifier si null ou trop court
        if (string.IsNullOrEmpty(password) || password.Length < 8)
            return false;

        // Vérifier si contient au moins un chiffre
        foreach (char c in password)
        {
            if (char.IsDigit(c))
                return true;
        }

        return false;
    }
}
