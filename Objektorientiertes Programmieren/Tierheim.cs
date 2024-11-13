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

        public void AddCat(Cat cat)
        {
            cats.Add(cat);
        }

        public void AddCatFromInput()
        {
            try
            {
                Console.Write("Geben Sie die Farbe der Katze ein: ");
                string? color = Console.ReadLine();

                Console.Write("Geben Sie das Geburtsjahr der Katze ein (z.B. 2021): ");
                int year = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Geben Sie den Geburtsmonat der Katze ein (z.B. 5): ");
                int month = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Geben Sie den Geburtstag der Katze ein (z.B. 20): ");
                int day = int.Parse(Console.ReadLine() ?? "0");

                Cat newCat = new Cat(new DateTime(year, month, day))
                {
                    Color = color
                };

                AddCat(newCat);
                Console.WriteLine("Die Katze wurde erfolgreich hinzugefügt.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler bei der Eingabe: " + ex.Message);
            }
        }

        public void AlleKatzenVorstellen()
        {
            foreach (var cat in cats)
            {
                Console.WriteLine($"The Color of my Cat is {cat.Color} and it is {cat.Age} Years old...");
            }
        }
    }
}
