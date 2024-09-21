namespace Index.Inheritance
{


    public class Manager : Employeee
    {
        private const decimal AllowanceRate = 0.05m;
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }
        public decimal CalculateAllowance()
        {
            return base.Calculate() * AllowanceRate;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nBase Salary: {Math.Round(base.CalculateBaseSalary(), 2)} $" +
                   $"\nOverTime Salary: {Math.Round(base.CalculateOverTimeSalary(), 2)} $" +
                   $"\nAllowance: {Math.Round(CalculateAllowance(), 2)} $" +
                   $"\nNet Salary: {Math.Round(Calculate(), 2)}  $";
        }
    }
}