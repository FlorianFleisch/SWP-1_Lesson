using MyFirstCat;
using System;

namespace Objektorientiertes_Programmieren
{
    class Cat : Animals
    {
        private string? _Color;

        public Cat(DateTime birthdate, string name = "undefined", string color = "undefined") : base(birthdate, name)
        {
            _Color = color;
        }
        public override string ToString()
        {
            return $"{Name} is {_Color} and is {Age} Years old.";
        }
    }
}
