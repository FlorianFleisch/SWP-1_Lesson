using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCat
{
     class Creatures 
    {
        private DateTime _birthDate;
        public int Age
        {
            get { return DateTime.Now.Year - _birthDate.Year; }
        }
        public Creatures(DateTime birthdate) 
        {
            _birthDate = birthdate;
        }

    }
}
