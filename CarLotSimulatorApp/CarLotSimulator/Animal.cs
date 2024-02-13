using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Animal
    {
        private bool _isAlien;

        public bool IsAlien
        {
            get
            {
                return _isAlien;
            }
            set
            {
                _isAlien = value;
            }
        }
        public Animal()
        { }

        public int Legs { get; set; }
        public int Age { get; set; }

        
    }
}
