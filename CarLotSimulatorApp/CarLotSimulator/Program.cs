using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            

            var honda = new Car();
            honda.Year = 2003;
            honda.Make = "Honda";
            honda.Model = "Civic";

            cars.Add(honda); 

            var chevrolet = new Car();
            chevrolet.Year = 2015;
            chevrolet.Make = "Chevrolet";
            chevrolet.Model = "Cobalt";

            cars.Add(chevrolet); 
            

            var ford = new Car();
            ford.Year = 2003;
            ford.Make = "Ford";
            ford.Model = "Focus";

            cars.Add(ford);                     

            

            var toyota = new Car();
            toyota.Year = 2013;
            toyota.Make = "Toyota";
            toyota.Model = "Corolla";
            toyota.EngineNoise = "hum";
            toyota.HonkNoise = "beep";
            toyota.IsDriveable = true;

            cars.Add(toyota);

            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();



            var kia = new Car()
            {
                Year = 2015,
                Make = "Kia",
                Model = "Sedona",
                EngineNoise = "clanky",
                HonkNoise = "squeak",
                IsDriveable = true,
            };
            cars.Add(kia); 

            kia.MakeEngineNoise();
            kia.MakeHonkNoise();

            var mazda = new Car(2008, "Mazda", "Three", "click", "shriek", true);
            cars.Add(mazda);

            mazda.MakeEngineNoise();
            mazda.MakeHonkNoise();

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
            }

            CarLot._numberOfCars = cars.Count;
            Console.WriteLine($"The number of cars in the carlot is { CarLot._numberOfCars}.");


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
