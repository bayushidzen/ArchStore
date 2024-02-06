using System.Transactions;

namespace SOLID.OCP
{
    internal class Bus : Vehicle
    {
        public Bus(int maxspeed) : base(maxspeed)
        {
            this.maxspeed = maxspeed;
        }

        public new double CalculateAllowedSpeed() { return this.maxspeed * 0.5; }
    }
}
