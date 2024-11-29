using MyFirstCat;
using System;

namespace MyFirstCat
{
    class Animals : Creatures
    {
        public string Name { get; set; }

        public Animals(DateTime birthdate, string name) : base(birthdate)
            {  Name = name; }
    }
}