using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        public Program()
        {
            int zahl;
            string eingabe;

            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein:");
                eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out zahl) && zahl > 0)
                {
                    break;
                }
                else if (!int.TryParse(eingabe, out _))
                {
                    Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
                    Console.WriteLine("1) Alle Selbstlaute (a, e, i, o, u) entfernen");
                    Console.WriteLine("2) Die Zeichenkette umdrehen");
                    Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");

                    int stringOperation;
                    if (int.TryParse(Console.ReadLine(), out stringOperation))
                    {
                        switch (stringOperation)
                        {
                            case 1:
                                string ohneSelbstlaute = RemoveVowels(eingabe);
                                Console.WriteLine($"Zeichenkette ohne Selbstlaute: {ohneSelbstlaute}");
                                break;

                            case 2:
                                string umgedreht = ReverseString(eingabe);
                                Console.WriteLine($"Umgedrehte Zeichenkette: {umgedreht}");
                                break;

                            case 3:
                                Console.WriteLine($"Die Zeichenkette hat {eingabe.Length} Zeichen.");
                                break;

                            default:
                                Console.WriteLine("Ungültige Auswahl.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe.");
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                }
            }

            int operation = 0;
            while (true)
            {
                Console.WriteLine("Welche mathematische Operation möchten Sie ausführen?");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Multiplikation");
                Console.WriteLine("3) Division");
                Console.WriteLine("4) Fakultät");
                Console.WriteLine("5) Wurzelziehen");
                Console.WriteLine("Wählen Sie eine Option (1-5) oder 0, um das Programm zu beenden:");

                if (!int.TryParse(Console.ReadLine(), out operation) || operation < 0 || operation > 5)
                {
                    Console.WriteLine("Ungültige Eingabe, bitte wählen Sie eine Option von 1 bis 5 oder 0, um das Programm zu beenden.");
                    continue;
                }

                if (operation == 0)
                {
                    Console.WriteLine("Programm wird beendet.");
                    break;
                }

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Geben Sie eine Zahl zum Addieren ein:");
                        if (int.TryParse(Console.ReadLine(), out int addZahl))
                        {
                            Console.WriteLine($"{zahl} + {addZahl} = {zahl + addZahl}");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Geben Sie eine Zahl zum Multiplizieren ein:");
                        if (int.TryParse(Console.ReadLine(), out int multZahl))
                        {
                            Console.WriteLine($"{zahl} * {multZahl} = {zahl * multZahl}");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Geben Sie eine Zahl zum Dividieren ein:");
                        if (int.TryParse(Console.ReadLine(), out int divZahl) && divZahl != 0)
                        {
                            Console.WriteLine($"{zahl} / {divZahl} = {(double)zahl / divZahl}");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe oder Division durch Null.");
                        }
                        break;

                    case 4:
                        long fakultät = 1;
                        for (int i = 1; i <= zahl; i++)
                        {
                            fakultät *= i;
                        }
                        Console.WriteLine($"Fakultät von {zahl} = {fakultät}");
                        break;

                    case 5:
                        Console.WriteLine($"Wurzel aus {zahl} = {Math.Sqrt(zahl)}");
                        break;
                }
            }
        }

        string RemoveVowels(string input)
        {
            return input.Replace("a", "")
                .Replace("e", "")
                .Replace("i", "")
                .Replace("o", "")
                .Replace("u", "")
                .Replace("A", "")
                .Replace("E", "")
                .Replace("I", "")
                .Replace("O", "")
                .Replace("U", "");
        }

        string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
