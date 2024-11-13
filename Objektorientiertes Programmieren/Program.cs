using System;

namespace Objektorientiertes_Programmieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Tierheim tierheim = new Tierheim();

            bool weiter = true;
            while (weiter)
            {
                Console.WriteLine("Möchten Sie eine Katze hinzufügen? (ja/nein)");
                string? antwort = Console.ReadLine()?.ToLower();

                if (antwort == "ja")
                {
                    tierheim.AddCatFromInput();
                }
                else if (antwort == "nein")
                {
                    weiter = false;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'ja' oder 'nein' ein.");
                }
            }

            Console.WriteLine("\nAlle Katzen im Tierheim:");
            tierheim.AlleKatzenVorstellen();
        }
    }
}
