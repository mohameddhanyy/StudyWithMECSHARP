namespace Index.Inheritance
{
    public class Developer : Employeee
    {
        private const decimal Commission = 0.03m;
        public bool TaskCompleted { get; set; }
        public override decimal Calculate() => base.Calculate() + CalculateBonus();

        public decimal CalculateBonus()
        {
            if (TaskCompleted)
                return Commission * base.Calculate();
            else return 0m;
        }


        public override string ToString()
        {
            return base.ToString() +
                   $"\nBase Salary: {Math.Round(base.CalculateBaseSalary(), 2)} $" +
                   $"\nOverTime Salary: {Math.Round(base.CalculateOverTimeSalary(), 2)} $" +
                   $"\nTasl Completed: {TaskCompleted}" +
                   $"\nCommission: {Commission}" +
                   $"\nBonus: {Math.Round(CalculateBonus(), 2)} $" +
                   $"\nNet Salary: {Math.Round(Calculate(), 2)}  $";
        }
    }
}