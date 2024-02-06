namespace SOLID.ISP
{
    internal class Circle : IShape
    {
        int radius;
        double pi = 3.14;

        public Circle(int radius)
        {
            this.radius = radius;
        }
    
        public double Perimetr()
        {
            return 2 * pi * radius;
        }
    }
}
