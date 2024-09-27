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

    if (inputString == "Beenden")
    {
        Console.WriteLine("Programm wird beendet.");
        break;
    }


    Console.WriteLine(inputString);
}












// Programmierauftrag 2 ((auch noch) keine Programmierübung)

// Erweitern Sie ihre Konsolenanwendung. sodass sie eine natürliche Zahl einlesen können. 
// Ihr Programm soll dann die Eingabe in einen Integer konvertieren. 
// Verschaffen Sie sich zuerst einen Überblick über die elementaren Datentypen von C# 
// und wie sie diese "umwandeln" (konvertieren) können. 



inputString = "";
int inputInt = 0;


while (true)
{


    Console.WriteLine("Geben Sie eine natürliche Zahl ein");
    inputString = Console.ReadLine();
    int.TryParse(inputString, out inputInt);
    Console.WriteLine(inputInt + 1);

}





