namespace ArchStore.ModelElements
{
    internal class Power
    {
        private static int counter = 0;
        private readonly int id;
        private float power;

        public Power(float power)
        {
            this.power = power;
        }

        public int GetId()
        {
            return id;
        }

        public float GetPower()
        {
            return power;
        }

        public void SetPower(float power)
        {
            this.power = power;
        }
    }
}
