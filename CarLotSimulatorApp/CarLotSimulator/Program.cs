using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Car katesCar = new Car();
            Car NikasCar = new Car();

            Console.WriteLine($"Number of cars in the car lot: {CarLot.NumberOfCars}");

            

            Teacher kate = new Teacher();
            kate.Name = "Kate Lynn";
            Teacher.Subject = "Everything";
            kate.Name = "Kate"; 
            Labrador gabby = new Labrador();
            Animal animalInstance = new Animal();

            gabby.IsAlien = true; 

            CarLot carLot = new CarLot();
            

            CarLot lot1 = new CarLot();
            
            //TODO

            //Create a seperate class file called Car DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property DONE all 3


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car\ DONE

            var jeep = new Car(); // special member method Constructor - helps us create new instance of Car class
            //carLot.Cars.Add(jeep);

            //var jeep = new Car()
            //{
            //    Make = "Jeep",
            //    Model = "Wrangler",
            //    Year = 2024,
            //    EngineNoise = "Vroomity vroom vroom",
            //    HonkNoise = "quacl quack",
            //    IsDriveable = true,
            //};
            //var jeep = new Car("Jeep", "Wrangler", 2024, "Vroomity vroom", "quack quack", true);
            var mercedes = new Car();
            //carLot.Cars.Add(mercedes);
            //var mercedes = new Car()
            //{
            //    Make = "Benz",
            //    Model = "M-Class",
            //    Year = 2023,
            //    EngineNoise = "Prr Baby",
            //    HonkNoise = "Honk Honk Baby",
            //    IsDriveable = true,
            //};
            //var mercedes = new Car("Benz", "M-Class", 2023, "Prr Baby", "Honk Honk Baby", true);
            //var lincoln = new Car();
            //var lincoln = new Car()
            //{
            //    Make = "Lincoln",
            //    Model = "Navigator",
            //    Year = 2025,
            //    EngineNoise = "Slickkk",
            //    HonkNoise = "..",
            //    IsDriveable = false
            //};
            var lincoln = new Car("Lincoln", "Navigator", 2025, "Slickkk", "..", false);
            //carLot.Cars.Add(lincoln);

            jeep.Make = "Jeep";
            jeep.Year = 2024;
            jeep.Model = "Wrangler";
            jeep.EngineNoise = "Vroomity vroom vroom";
            jeep.HonkNoise = "quack quack";
            jeep.IsDriveable = true;

            jeep.MakeEngineNoise("Vroom Quack Vroom");
            jeep.MakeHonkNoise("HOOOOOONKKKK");

            Console.WriteLine(jeep.EngineNoise);
            Console.WriteLine(jeep.HonkNoise);

            mercedes.Make = "Benz";
            mercedes.Year = 2023;
            mercedes.Model = "M Class";
            mercedes.EngineNoise = "Vavvvrrrrooomm";
            mercedes.HonkNoise = "prrrrrr";
            mercedes.IsDriveable = true;

            mercedes.MakeEngineNoise("vrrrrrmm");
            mercedes.MakeHonkNoise("rrrrrrrr");

            Console.WriteLine(mercedes.EngineNoise);
            Console.WriteLine(mercedes.HonkNoise);

            lincoln.Make = "Lincoln";
            lincoln.Year = 2025;
            lincoln.Model = "Navigator";
            lincoln.EngineNoise = "....";
            lincoln.HonkNoise = "something snazzy";
            lincoln.IsDriveable = false;

            lincoln.MakeEngineNoise("i'm too classy for my..");
            lincoln.MakeHonkNoise("snazzier");

            Console.WriteLine(mercedes.EngineNoise);
            Console.WriteLine(mercedes.HonkNoise);
           
            var carList = new List<Car>();

            //carLot.Cars.Add(jeep);
            //carLot.Cars.Add(mercedes);
            //carLot.Cars.Add(lincoln);

            //lincoln.MakeEngineNoise(lincoln.EngineNoise);
            ////jeep.MakeEngineNoise();
            //Console.WriteLine(carLot.Cars);

            //foreach (var car in carLot.Cars)
            //{
            //    Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            //}
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // DONE

            //*************BONUS X 2*************//

            //Create a CarLot class DONE
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console DONE
            //foreach (Car car in carLot.Cars)
            //{
            //    Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            //}
            var accountOne = new BankAccount();
            var accountTwo = new BankAccount();
            Console.WriteLine( BankAccount.NumberOfAccounts );

            Console.WriteLine(Math.Abs(100));
        }
        class Teacher
        {
            public string Name { get; set; }
            public static string Subject { get; set; }
        }

        public class BankAccount
        {
            private static int numberOfAccounts = 0;

            public BankAccount()
            {
                //increment the counter when new bank account created
                numberOfAccounts++;
            }

            public static int NumberOfAccounts
            {
                get { return numberOfAccounts; }
            }
        }

        public class AppConfig
        {
            public static string DefaultLanguage { get; set; } = "English";
            public static int MaxNumberOfConnections { get; set; } = 100;
        }
    }
}
