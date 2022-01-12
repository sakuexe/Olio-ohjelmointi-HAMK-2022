
//Tehtävä 1.1, Lukujen keskiarvo - Saku Karttunen

void numbers()
{ 
    Console.WriteLine("Montako lukua?");
    var quantity = Console.ReadLine();
    List<int> numbersList = new();

    for (int i = 0; i < int.Parse(quantity); i++)
    {
        Console.WriteLine("Anna " + (i + 1) + ". luku");
        numbersList.Add(int.Parse(Console.ReadLine()));
    }

    Console.WriteLine("Lukujen keskiarvo: " + (numbersList.Sum() / 2) );
}

//tehtävä 1.2, Yhteen vai vähennyslasku

void calculation()
{
    Console.WriteLine("Yhteen- vai vähennyslasku? ( + / - )");
    var choice = Console.ReadLine();
    List<int> calculatedNumbers = new();

    for (int x = 0; x < 2; x++)
    {
        Console.WriteLine("Anna " + (x + 1) + ". luku");
        calculatedNumbers.Add(int.Parse(Console.ReadLine()));
    }

    if (choice == "+")
    {
        Console.WriteLine("Yhteenlaskun lopputulos on: " + calculatedNumbers.Sum());
    }

    else if (choice == "-")
    {
        Console.WriteLine("Vähennyslaskun lopputulos on: " + (calculatedNumbers[0] - calculatedNumbers[1]));
    }

    else
    {
        Console.WriteLine("Virhe laskun valinnassa.");
    }
}

// Programmi

Console.WriteLine("Valitse ohjelma (1 / 2): \n" + "1. Lukujen keskiarvo. \n" + "2. Yhteen- tai vähennyslasku");
var initialChoice = Console.ReadLine();

if (initialChoice == "1")
{
    numbers();
}

else if (initialChoice == "2")
{
    calculation();
}

Console.WriteLine("\n" + "Kiitos käynnistä(misestä)");