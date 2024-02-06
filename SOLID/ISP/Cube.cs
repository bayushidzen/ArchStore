namespace SOLID.ISP
{
    internal class Cube : IShape3D
    {
        int len;

        public Cube(int len)
        {
            this.len = len;
        }

        public double Perimetr()
        {
            return len * 12;
        }

        public double value()
        {
            return len * len * len;
        }
    }
}
