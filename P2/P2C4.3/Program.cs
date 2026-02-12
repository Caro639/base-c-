using P2C4._3;

try
{

    // List<int> temperaturesEnregistreDegresCelcius = new List<int>();
    List<int> temperaturesEnregistreDegresCelcius = [];

    // remplir la liste à partir des valeurs fournies comme arguments en ligne de commande
    foreach (string stringRepresentationTemperature in args)
    {
        int temperature = int.Parse(stringRepresentationTemperature);
        temperaturesEnregistreDegresCelcius.Add(temperature);
    }

    // Calculer et afficher la température moyenne
    int moyenneTemperature = MathSimple.CalculMoyenne(temperaturesEnregistreDegresCelcius);
    Console.WriteLine("La température moyenne est " + moyenneTemperature);
}
catch (FormatException)
{
    Console.WriteLine("Les températures fournies doivent être des nombres");
    Environment.Exit(-1);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Vous devez fournir au moins une température");
    Environment.Exit(-1);
}