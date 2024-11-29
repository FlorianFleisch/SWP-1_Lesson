using System;

namespace Objektorientiertes_Programmieren
{
    class Cat
    {
        private string? _Color;
        private DateTime _birthDate;

        public string Color { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }
        }

        public Cat(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public override string ToString()
        {
            //return $"Color: {Color}, Age: {Age}";
            return $"The Color of my Cat is {Color} and it is {Age} Years old...";
        }
    }
}
