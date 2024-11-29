using MyFirstCat;
using System;
using System.Drawing;

namespace MyFirstCat
{
    class Animals : Creatures
    {
        public Animals(DateTime birthdate, string name, string color) : base(birthdate, name, color) {}
    }
}