using SOLID.DIP;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new PetrolEngine());
            car.Start();
            car = new Car(new DieselEngine());
            car.Start();
        }
    }
}
