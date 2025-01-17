using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
    public class Creatures
    {
        private DateTime _birthDate;
        private string? _Color;

        private string _Name;
        public string Name { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }
        }
        public Creatures(DateTime birthdate, string name, string color)
        {
            _birthDate = birthdate;
            _Color = color;
            Name = name;
        }

        public string? Color1

        {
            get { return _Color; }
        }


    }
}
