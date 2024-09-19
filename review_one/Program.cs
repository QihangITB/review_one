using System;

class Program
{
    static void Main()
    {
        /*
        const string AskFirstNote = "Introdueix la primera qualificació: ";
        const string AskSecondNote = "Introdueix la segona qualificació: ";
        const string AskThirdNote = "Introdueix la tercera qualificació: ";
        const string MsgResult = "El promig de les notes es: ";
        const string MsgApproved = "Aprovat";
        const string MsgFailed = "Suspès";

        const int ApprovedNote = 6;
        const float NotesNumber = 3.0f;

        int firstNote, secondNote, thirdNote, sum;
        float avg;

        Console.WriteLine(AskFirstNote);
        firstNote = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(AskSecondNote);
        secondNote = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(AskThirdNote);
        thirdNote = Convert.ToInt32(Console.ReadLine());

        sum = firstNote + secondNote + thirdNote;

        avg = sum / NotesNumber;

        Console.WriteLine(MsgResult + avg);

        Console.WriteLine(avg > ApprovedNote ? MsgApproved : MsgFailed);
        */

        const string AskToContinue = "Si vols sortir, prem 0.";
        const string MsgCitiesList = "Ciutat: {0}, Codi Postal: {1} ";

        int input = 1;
        Dictionary<string, string> cities = new Dictionary<string, string>();

        do
        {
            AskCity(ref cities);

            Console.WriteLine(AskToContinue);
            input = Convert.ToInt32(Console.ReadLine());

        } while (input != 0);


        foreach(var city in cities)
        {
            Console.WriteLine(MsgCitiesList, city.Key, city.Value);
        }
    }

    public static void AskCity(ref Dictionary<string, string> citiesList)
    {
        const string AskCity = "Introdueix el nom de la ciutat: ";
        const string AskZipCode = "Introdueix el codi postal de la ciutat: ";
        
        Console.WriteLine(AskCity);
        string? city = Console.ReadLine();

        Console.WriteLine(AskZipCode);
        string? zipCode = Console.ReadLine();

        citiesList.Add(city, zipCode);
    }
}

