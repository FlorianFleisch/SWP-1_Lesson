using System;

namespace Objektorientiertes_Programmieren
{
    class Cat : Animal
    {
        private string? _Color;
        private DateTime _birthDate;

        //public string Color
        //{
        //    get { return _Color; }
        //    set
        //    {
        //        if (_Color == value) return;
        //        _Color = value;
        //    }
        //}

        public string Color { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }
        }

        public Cat(string name, DateTime birthDate) : base(name)
        {
            _birthDate = birthDate;
            Name = name;
        }

        public Cat(string name, string color, DateTime birthDate) : base(name)
        {
            Color = color;
            _birthDate = birthDate;
        }
        public override string ToString()
        {
            //return $"Color: {Color}, Age: {Age}";
            return $"The Color of my Cat is {Color} and it is {Age} Years old...";
        }
    }
}
