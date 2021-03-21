using System;
using InheritanceExercise1;

namespace InheritanceExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle ( 4, 3, "Toyota" );
                       
            Console.WriteLine(vehicle);

            Car car = new Car(4, 5, "Isuzu");
            
            Console.WriteLine(car);

            Motorcycle motorcycle = new Motorcycle(2, 1, "Harley");

            Console.WriteLine(motorcycle);

           Truck truck = new Truck (10, 11, "Mercedes");

            Console.WriteLine(truck);

            
            //Console.WriteLine("Status of license: " + Drive (5.5));
        }
    }
}
