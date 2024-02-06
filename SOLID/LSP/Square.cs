namespace SOLID.LSP
{
    internal class Square : QuadRangle
    {
        int len;

        public Square(int len)
        {
            this.len = len;
        }

        public override int Area()
        {
            return len * len;
        }
    }
}
