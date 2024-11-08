using System;

namespace Objektorientiertes_Programmieren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Objekts der Klasse Cat
            Cat myCat = new Cat(new DateTime(2022, 11, 8));
            myCat.Color = "black";

            // Aufrufen der Methode
            Console.WriteLine("The Color of my Cat is " + myCat.Color + " and it is " + myCat.Age + " Years old...");  // Ausgabe: The color of my cat is black and she is 2 years old.
        }
    }
}
