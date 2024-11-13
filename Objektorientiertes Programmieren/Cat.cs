using System;

namespace Objektorientiertes_Programmieren
{
    class Cat
    {
        private string? _Color = null;
        private DateTime _birthDate;

        public string Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value) return;
                _Color = value;
            }
        }
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }
        }

        public Cat(DateTime birthDate)
        {
            _birthDate = birthDate;
        }
    }
}
