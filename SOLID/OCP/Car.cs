namespace SOLID.OCP
{
    internal class Car : Vehicle
    {
        public Car(int maxspeed) : base(maxspeed)
        {            
            this.maxspeed = maxspeed;            
        }
        public new double CalculateAllowedSpeed() { return this.maxspeed * 0.8; }
    }
}
