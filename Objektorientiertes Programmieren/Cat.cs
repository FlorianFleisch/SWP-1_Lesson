using MyFirstCat;
using System;

namespace Objektorientiertes_Programmieren
{
    public class Cat : Animals
    {

        public Cat(DateTime birthdate, string name = "undefined", string color = "undefined") : base(birthdate, name, color) { }

        public override string ToString()
        {
            return $"{Name} is {Color} and is {Age} Years old.";
        }
    }
}
