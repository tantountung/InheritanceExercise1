using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise1
{
    //Define class named Vehicle with associated properties.
    internal class Vehicle
    {
        public double Wheels { get; set; }

        public double Weight { get; set; }

        public string Brand { get; set; }

        public Vehicle(double wheels, double weight, string brand)
        {
            Wheels = wheels;
            Weight = weight;
            Brand = brand;
        }

        public override string ToString()
        {
            return $" wheels: {Wheels}, weight: {Weight}, brand: {Brand}";
        }

        public string Drive(double Weight)
        {
            if (Weight < 5)
            {
                return "light vehicle";
            }
            else
            {
                return "heavy vehicle";
            }

        }
    }
}
