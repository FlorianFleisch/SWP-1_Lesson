// Programmierauftrag 1 ((noch) keine Programmierübung == wird nicht bewertet)
// Schreiben sie eine C# Konsolenanwendung welche
// _ Eine Eingabe über die Tastatur einliest 
//  _ mit <Enter> soll die Eingabe "abgeschlossen" werden und der eingegebene String auf der Konsole ausgegeben werden
//  _ Bei Eingabe von "Beenden" soll das Programm beendet werden


using System;
using System.Globalization;

namespace ReadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (true)
            {

                Console.WriteLine("Um das Programm zu enden tippen Sie Beenden");
                input = Console.ReadLine();


                if (input == "Beenden")
                {
                    Console.WriteLine("Programm endet:(");
                    break;
                }


            }



        }
    }
}






// Programmierauftrag 2 ((auch noch) keine Programmierübung)

// Erweitern Sie ihre Konsolenanwendung. sodass sie eine natürliche Zahl einlesen können. 
// Ihr Programm soll dann die Eingabe in einen Integer konvertieren. 
// Verschaffen Sie sich zuerst einen Überblick über die elementaren Datentypen von C# 
// und wie sie diese "umwandeln" (konvertieren) können. 