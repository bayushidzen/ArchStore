namespace SOLID.LSP
{
    internal class Rectangle : QuadRangle
    {
        public int height;
        public int width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public override int Area()
        {
            return height * width;
        }
    }
}
