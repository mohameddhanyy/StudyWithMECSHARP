namespace Index.Inheritance
{



    public class Sales : Employeee
    {
        public decimal Commission { get; set; }
        public decimal SalesAmount { get; set; }

        public decimal CalculateBonus() => Commission * SalesAmount;

        public override decimal Calculate() => base.Calculate() + CalculateBonus();

        public override string ToString()
        {
            return base.ToString() +
                   $"\nBase Salary: {Math.Round(base.CalculateBaseSalary(), 2)} $" +
                   $"\nOverTime Salary: {Math.Round(base.CalculateOverTimeSalary(), 2)} $" +
                   $"\nSalesAmount: {SalesAmount}" +
                   $"\nCommission: {Commission}" +
                   $"\nBonus: {Math.Round(CalculateBonus(), 2)} $" +
                   $"\nNet Salary: {Math.Round(Calculate(), 2)}  $";
        }
    }
}