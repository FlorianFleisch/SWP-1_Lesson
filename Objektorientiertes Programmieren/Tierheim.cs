using MyFirstCat;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Windows.Markup;

namespace Objektorientiertes_Programmieren
{
    public class Tierheim
    {
        private List<Animals> _Animals;
        public List<Animals> Animals
        {
            get { return _Animals; }
            set
            {
                if (_Animals == value) return;
                _Animals = value;
            }
        }
        public Tierheim()
        {
            Animals = new List<Animals>();

        }

        public void AddAnimal()
        {
            Console.WriteLine("Möchten Sie eine Katze oder einen Hund hinzufügen? (Katze/Hund) oder alle Tiere anzeigen");
            string? tierArt = Console.ReadLine()?.ToLower();

            if (tierArt == "katze")
            {
                AddCatFromInput();
            }
            else if (tierArt == "hund")
            {
                AddDogFromInput();
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie 'Katze' oder 'Hund' ein.");
            }
        }

        private void AddCatFromInput()
        {
            try
            {
                Console.Write("Geben Sie den Namen der Katze ein: ");
                string? name = Console.ReadLine();

                Console.Write("Geben Sie die Farbe der Katze ein: ");
                string? color = Console.ReadLine();

                Console.Write("Geben Sie das Geburtsjahr der Katze ein (z.B. 2021): ");
                int year = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Geben Sie den Geburtsmonat der Katze ein (z.B. 5): ");
                int month = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Geben Sie den Geburtstag der Katze ein (z.B. 20): ");
                int day = int.Parse(Console.ReadLine() ?? "0");

                Cat newCat = new Cat(new DateTime(year, month, day), name, color);
                Animals.Add(newCat);
                Console.WriteLine("Die Katze wurde erfolgreich hinzugefügt.\n");
                Console.WriteLine(AlleTiereVorstellen);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler bei der Eingabe: " + ex.Message);
            }
        }

        private void AddDogFromInput()
        {
            try
            {
                Console.Write("Geben Sie den Namen des Hundes ein: ");
                string? name = Console.ReadLine();

                Console.Write("Geben Sie die Farbe des Hundes ein: ");
                string? color = Console.ReadLine();

                Console.Write("Geben Sie das Geburtsjahr des Hundes ein (z.B. 2021): ");
                int year = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Geben Sie den Geburtsmonat des Hundes ein (z.B. 5): ");
                int month = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Geben Sie den Geburtstag des Hundes ein (z.B. 20): ");
                int day = int.Parse(Console.ReadLine() ?? "0");

                Dog newDog = new Dog(new DateTime(year, month, day), name, color);
                Animals.Add(newDog);
                Console.WriteLine("Der Hund wurde erfolgreich hinzugefügt.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler bei der Eingabe: " + ex.Message);
            }
        }

        public void AlleTiereVorstellen()
        {
            Console.WriteLine("Tiere im Tierheim:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"Es sind {AnzahlTiere} Tiere im Tierheim");
                Console.WriteLine($"Es sind {AnzahlCats} Katzen im Tierheim");
                Console.WriteLine($"Es sind {AnzahlDogs} Hunde im Tierheim");
                Console.WriteLine(animal);
            }
            double durchschnittsAlter = Animals.Average(a => a.Age);
            Console.WriteLine($"\nDas Durchschnittsalter aller Tiere beträgt: {durchschnittsAlter:F1} Jahre.");
        }
        public int AnzahlTiere() { return Animals.Count; }
        public int AnzahlDogs() { return _Animals.Where(a => a.GetType() == typeof(Cat)).Count(); }
        public int AnzahlCats() { return _Animals.Where(a => a.GetType() == typeof(Dog)).Count(); }

        public double DurchschnittsalterTiere()
        {
            if (Animals.Count == 0) return 0;

            return Animals.Average(a => a.Age);
        }
    }
}
