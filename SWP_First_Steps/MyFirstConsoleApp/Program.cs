
// PÜ 5
// Programmieraufgabe 5: (Arbeiten mit Strings)
// Schreiben Sie eine Konsolenanwendung die einen String einliest und die Anzahl an Selbstlauten (a,e,i,o,u) in dem String bestimmt und ausgibt.

// Machen Sie sich mit der Klasse String vertraut und schauen Sie sich die Operationen auf Strings an. Wie können Sie einen String "umkehren", wie vergleichen, wie mögliche Leerzeichen entfernen,...?



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
                Console.WriteLine("Geben Sie eine Text eine String ein, ausgegeben werden dann die Selbstlaute Ihres Strings");
                string userText = Console.ReadLine().ToLower();
                char[] letters = userText.ToCharArray();
                int anzahlSelbstlaute = 0;

                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == 'a' || letters[i] == 'e' || letters[i] == 'i' || letters[i] == 'o' || letters[i] == 'u')
                    {
                        Console.Write(letters[i] + " ");
                        anzahlSelbstlaute++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Anzahl der Selbstlaute: {anzahlSelbstlaute}");
            }
        }
    }
}
