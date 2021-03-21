using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceExercise1
{
    internal class Car : Vehicle
    {

        public double AverageWeight
        {
            get
            {
                return Weight / Wheels;
            }
        }


    public Car(double wheels, double weight, string brand) : base(wheels, weight, brand)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " average weight per wheel: " + AverageWeight;
        }

        public new string Drive(double Weight)
        {
            if (Weight < 6)
            {
                return "ordinary driving license";
            }
            else
            {
                return "special driving license";
            }

        }
    }

}
