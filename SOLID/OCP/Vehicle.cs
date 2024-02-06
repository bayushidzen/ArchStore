using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class Vehicle
    {
        public int maxspeed;

        public Vehicle(int maxspeed) 
        {
            this.maxspeed = maxspeed;
        }

        public double CalculateAllowedSpeed() { return maxspeed; }
    }
}
