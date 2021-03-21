using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise1
{
    internal class Truck : Vehicle
    {
        public string Loaded
        {
            get
            { return "heavy"; }
        }


        public Truck(double wheels, double weight, string brand) : base(wheels, weight, brand)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " when loaded: " + Loaded;
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
