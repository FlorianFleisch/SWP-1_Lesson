using System;
using System.Collections.Generic;

namespace Objektorientiertes_Programmieren
{
    class Tierheim
    {
        private List<Cat> cats;

        public Tierheim()
        {
            cats = new List<Cat>();
        }

        // Methode zum Hinzufügen einer Katze über Benutzereingaben
        public void AddCatFromInput()
        {
            try
            {
                // Eingabe des Namens der Katze
                Console.Write("Geben Sie den Namen der Katze ein: ");
                string? name = Console.ReadLine();

                // Eingabe der Farbe der Katze
                Console.Write("Geben Sie die Farbe der Katze ein: ");
                string? color = Console.ReadLine();

                // Eingabe des Geburtsjahrs
                Console.Write("Geben Sie das Geburtsjahr der Katze ein (z.B. 2021): ");
                int year = int.Parse(Console.ReadLine() ?? "0");

                // Eingabe des Geburtsmonats
                Console.Write("Geben Sie den Geburtsmonat der Katze ein (z.B. 5): ");
                int month = int.Parse(Console.ReadLine() ?? "0");

                // Eingabe des Geburtstags
                Console.Write("Geben Sie den Geburtstag der Katze ein (z.B. 20): ");
                int day = int.Parse(Console.ReadLine() ?? "0");

                // Erstellen einer neuen Cat-Instanz mit Name, Farbe und Geburtsdatum
                Cat newCat = new Cat(name ?? "Unbekannt", color ?? "Unbekannt", new DateTime(year, month, day));

                // Hinzufügen der neuen Katze zur Liste
                cats.Add(newCat);

                Console.WriteLine("Die Katze wurde erfolgreich hinzugefügt.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler bei der Eingabe: " + ex.Message);
            }
        }

        // Methode zum Vorstellen aller Katzen im Tierheim
        public void AlleKatzenVorstellen()
        {
            if (cats.Count == 0)
            {
                Console.WriteLine("Im Tierheim befinden sich derzeit keine Katzen.");
                return;
            }

            // Ausgabe der Informationen jeder Katze
            foreach (var cat in cats)
            {
                Console.WriteLine(cat);  // Verwendet die `ToString`-Methode von `Cat`
            }
        }
    }
}
