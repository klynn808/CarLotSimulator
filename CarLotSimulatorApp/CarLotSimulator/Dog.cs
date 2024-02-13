using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Dog : Animal
    {
        public Dog() 
        {
            Legs = 4;
        }
        public string OwnerName { get; set; }
        public string FavoriteToy { get; set; }
    }
}
