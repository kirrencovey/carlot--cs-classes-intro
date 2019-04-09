using System;
using System.Collections.Generic;

namespace CarLot
{

    public class Car {

        // constructor method:
        public Car (int year) {
            Year = year;
        }
        // method overload for constructor method, so users can pass year in on construction or not
        public Car () {}
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        private string _baseSound = "vroom";
        public void Drive() {
            Console.WriteLine(_baseSound);
        }
        public void Drive(string soundToMake) {
            Console.WriteLine(soundToMake);
        }
        public void Drive(int kilometers) {
            Console.WriteLine($"I drove {kilometers} kilometers");
        }
        public void Drive(int kilometers, string sound) {
            Console.WriteLine($"I drove {kilometers} kilometers - {sound}");
        }
    }
}

// Method-based polymorphism illustrated in Drive methods