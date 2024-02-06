namespace SOLID.SRP
{
    internal class CalculateSalary
    {
        int baseSalary;

        public void CalcSalary(int baseSalary)
        {
            this.baseSalary = baseSalary;
        }

        public double CalcSalary()
        {
            return baseSalary * 1.5;
        }
    }
}
