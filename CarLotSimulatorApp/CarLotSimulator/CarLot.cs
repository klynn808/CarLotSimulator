using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int NumberOfCars { get; private set; }       
        public static void IncrementCounter()
        {
            NumberOfCars++;
        }    
    }
}

