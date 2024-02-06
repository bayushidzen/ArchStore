namespace SOLID.DIP
{
    internal class Car
    {
        readonly IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start ()
        {
            engine.Start();
        }
    }
}
