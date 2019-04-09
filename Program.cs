using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            // Define a Dictionary to represent a car. Each dictionary should have the following KeyValuePairs.

            // * Make
            // * Model
            // * Year
            // * Price

            // Create three car dictionaries for three different car models

            Dictionary<string, string> volt = new Dictionary<string, string>() {
                {"Make", "Chevrolet"},
                {"Model", "Volt"},
                {"Year", "2013"},
                {"Price", "$13,000"}
            };

            Dictionary<string, string> tacoma = new Dictionary<string, string>() {
                {"Make", "Toyota"},
                {"Model", "Tacoma"},
                {"Year", "2014"},
                {"Price", "$17,000"}
            };

            Dictionary<string, string> lancer = new Dictionary<string, string>() {
                {"Make", "Mitsubishi"},
                {"Model", "Lancer"},
                {"Year", "2006"},
                {"Price", "$6,000"}
            };

            // Console.WriteLine($@"
            //     Make: {volt["Make"]}
            //     Model: {volt["Model"]}
            //     Year: {volt["Year"]}
            //     Price: {volt["Price"]}
            // ");


            // * Create a car lot list.
            // * Add each car to the car lot.
            // * Iterate the car lot list and output all the details of each car

            List<Dictionary<string, string>> carLot = new List<Dictionary<string, string>>(){
                volt,
                tacoma,
                lancer
            };


            // foreach (Dictionary<string, string> car in carLot)
            // {
            //     foreach (KeyValuePair<string, string> kvp in car)
            //     {
            //         Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //     }
            // }

            // If you know what the key names are, you can do it this way. If you don't,
            // and want to see all the kvps, do it the previous way.
            foreach (Dictionary<string, string> car in carLot)
            {
                // Console.WriteLine($@"
                //     Make: {car["Make"]}
                //     Model: {car["Model"]}
                //     Year: {car["Year"]}
                //     Price: {car["Price"]}
                // ");
            }
            }

            {// Use custom class instead of dictionaries, for more flexibility (new class found in Car.cs)
            Car theVolt = new Car() {
                Make = "Chevrolet",
                Model = "Volt",
                Year = 2013,
                Price = 13000.39
            };

            // theVolt.Drive("*silence*");
            theVolt.Drive(36, "*silence*");

            Car theTacoma = new Car() {
                Make = "Toyota",
                Model = "Tacoma",
                Year = 2014,
                Price = 17300.95
            };

            theVolt.Drive("rumble");

            // can pass in year on construction, thanks to constructor class
            Car theLancer = new Car(2006) {
                Make = "Mitsubishi",
                Model = "Lancer",
                Price = 6000
            };

            theVolt.Drive();
            theVolt.Drive("whine");
            theVolt.Drive(15);

            List<Car> theCarLot = new List<Car>() {
                theVolt,
                theTacoma,
                theLancer
            };

            // foreach (Car car in theCarLot)
            // {
            //     Console.WriteLine($@"
            //         Make: {car.Make}
            //         Model: {car.Model}
            //         Year: {car.Year}
            //         Price: {car.Price}
            //     ");
            // }

            // Define a car lot with new class, for more complexity and detail
            CarLot mikesUsedCars = new CarLot() {
                Owner = "Mike Wyczowski"
            };

            mikesUsedCars.Inventory.Add(theVolt);
            mikesUsedCars.Inventory.Add(theTacoma);
            mikesUsedCars.Inventory.Add(theLancer);
            mikesUsedCars.Address = "1000 Infinity Way";
            mikesUsedCars.Size = 20000;

            foreach (Car car in mikesUsedCars.Inventory) {
                Console.WriteLine($@"
Make: {car.Make}
Model: {car.Model}
Year: {car.Year}
Price: {car.Price}
                ");
            }

            }
        }
    }
}
