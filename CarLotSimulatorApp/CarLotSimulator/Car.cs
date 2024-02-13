using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        // Constructors
        public Car() // default constructor
        {
            CarLot.IncrementCounter();
        } // a special member method that has the same name as its class
        //public Car()
        //{
            
        //}
        public Car(string make, 
            string model, 
            int year, 
            string engineNoise, 
            string honkNoise, 
            bool isDriveable)
        {
            Make = make;
            Model = model; 
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        // fields
        //Properties
        public int? Year { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        //methods
        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
        }
        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
        }
    }
}
