// Programmieraufgabe 4:

// Erweitern Sie ihre Konsolenanwendung in der Art, dass nach dem Einlesen der Natürlichen Zahl eine Abfrage erscheint, in der Sie eine Mathematische Operation auswählen können... Dies kann zum Beispiel so ausschauen:
// Geben Sie eine Zahl zwischen 1 und 3 ein um eine Mathematische Operation auszuwählen:
// 1) Quadrat
// 2) Wurzel
// 3) Fakultät
// Verschaffen Sie sich zuerst einen Überblick über verfügbare Kontrollstrukturen in C# und wie Sie logische Terme definieren können (logische Verknüpfungsoperatoren).

using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Bitte geben Sie eine Zahl ein:");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Ihre Zahl ist jetz " + number);
                    Console.WriteLine("Wählen Sie nun die Art der Operation die Sie mit " + number + "durchführen wollen");
                    Console.WriteLine("1) Quadrat");
                    Console.WriteLine("2) Wurzel");
                    Console.WriteLine("3) Fakultät");

                    if (int.TryParse(Console.ReadLine(), out int operation))
                    {
                        switch (operation)
                        {
                            case 1:
                                Console.WriteLine($"Das Quadrat von {number} ist {Math.Pow(number, 2)}.");
                                break;
                            case 2:
                                Console.WriteLine($"Die Wurzel von {number} ist {Math.Sqrt(number)}.");
                                break;
                            case 3:
                                int Fakultät = number;
                                for (int i = Fakultät - 1; i >= 1; i--)
                                {
                                    Fakultät = Fakultät * i;
                                }
                                Console.WriteLine($"Die Fakultät von {number} ist {Fakultät}.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");

                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }

        }
    }
}
