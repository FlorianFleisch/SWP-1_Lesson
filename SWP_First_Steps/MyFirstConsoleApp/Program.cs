// PA 6
// Programmieraufgabe 6:
// Erweitern Sie ihre Konsolenapplikation in der Art, dass zuerst eine mathematische Operation abgefragt wird:
// Geben Sie die Entsprechende Nummer für die Auswahl einer mathematischen Operation an:

// 1... Multiplizieren
// 2... Dividieren
// 3... Addieren
// 4... Potenzieren
// 5... Wurzelziehen
// 6... Fakultät
// 7... Invertieren

// Je nach Auswahl soll im Anschluss entweder eine oder zwei Ganzzahlen eingelesen und die entsprechende mathematische Operation ausgeführt werden.

// Achten Sie bei ihrer Implementierung auf Clean Code, machen Sie einen neuen Branch und dann einen sauberen PR.




using System;
using System.Security.Cryptography;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wählen Sie zwischen folgenden Ops aus:");
                Console.WriteLine("1... Multiplizieren");
                Console.WriteLine("2... Dividieren");
                Console.WriteLine("3... Addieren");
                Console.WriteLine("4... Potenzieren");
                Console.WriteLine("5... Wurzelziehen");
                Console.WriteLine("6... Fakultät");
                Console.WriteLine("7... Invertieren");
                int operation = Convert.ToInt32(Console.ReadLine());

                if (operation >= 1 && operation <= 4)
                {
                    Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                            break;
                        case 2:
                            if (number2 != 0)
                            {
                                Console.WriteLine($"{number1} / {number2} = {(double)number1 / number2}");
                            }
                            else
                            {
                                Console.WriteLine("Division durch Null ist nicht erlaubt.");
                            }
                            break;
                        case 3:
                            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                            break;
                        case 4:
                            Console.WriteLine($"{number1} ^ {number2} = {Math.Pow(number1, number2)}");
                            break;
                    }
                }
                else if (operation == 5)
                {
                    Console.WriteLine("Bitte geben Sie eine nummer ein");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Wurzel aus {number3} = {Math.Sqrt(number3)}");
                }
                else if (operation == 6)
                {
                    Console.WriteLine("Bitte geben Sie eine nummer ein");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    int Fakultät = number3;
                    for (int i = Fakultät - 1; i >= 1; i--)
                    {
                        Fakultät = Fakultät * i;
                    }
                    Console.WriteLine($"Fakultät von {number3} = {Fakultät}");
                }
                else if (operation == 7)
                {
                    Console.WriteLine("Bitte geben Sie eine nummer ein");
                    int number3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Invertiert {number3} = {-number3}");
                }
            }
        }
    }
}



