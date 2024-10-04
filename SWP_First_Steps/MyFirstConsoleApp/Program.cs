// Programmierauftrag 1 ((noch) keine Programmierübung == wird nicht bewertet)
// Schreiben sie eine C# Konsolenanwendung welche
// _ Eine Eingabe über die Tastatur einliest 
//  _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
//  _ Bei Eingabe von "Beenden" soll das Programm beendet werden






using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

string? inputString = "";

while (true)
{


    Console.WriteLine("Um das Programm zu beenden, tippen Sie 'Beenden'.");
    inputString = Console.ReadLine();

    Console.WriteLine(inputString);


    inputString = "";
    int inputInt = 0;


    inputString = Console.ReadLine();
    int.TryParse(inputString, out inputInt);
    Console.WriteLine(inputInt + 1);





    Console.WriteLine("Geben Sie Zeichen aller art ein, sie werden identifiziert");
    string input = Console.ReadLine();

    if (bool.TryParse(input, out bool boolValue))
    {
        Console.WriteLine("Der eingegebene Wert ist ein Boolean: " + boolValue);
    }

    else if (double.TryParse(input, out double doubleValue))
    {
        Console.WriteLine("Der eingegebene Wert ist eine Kommazahl: " + doubleValue);
    }

    else if (int.TryParse(input, out int intValue))
    {
        Console.WriteLine("Der eingegebene Wert ist eine Ganzzahl: " + intValue);
    }

    else if (DateTime.TryParse(input, out DateTime dateTimeValue))
    {
        Console.WriteLine("Der eingegebene Wert ist ein Datum: " + dateTimeValue);
    }


    if (inputString == "Beenden")
    {
        Console.WriteLine("Programm wird beendet.");
        break;
    }

}



