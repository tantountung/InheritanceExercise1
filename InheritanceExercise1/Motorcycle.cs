using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExercise1
{
    internal class Motorcycle : Vehicle
    {
        public string TankSize
        {
            get
            { return "small"; }
        }
        public Motorcycle(double wheels, double weight, string brand) : base(wheels, weight, brand)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " tank size: " + TankSize;
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

