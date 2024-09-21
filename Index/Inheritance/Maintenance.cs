namespace Index.Inheritance
{

    public class Maintenance : Employeee
    {
        private const decimal HardShip = 100m;
        public override decimal Calculate()
        {
            return base.Calculate() + HardShip;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nBase Salary: {Math.Round(base.CalculateBaseSalary(), 2)} $" +
                   $"\nOverTime Salary: {Math.Round(base.CalculateOverTimeSalary(), 2)} $" +
                   $"\nHard Ship: {Math.Round(HardShip, 2)} $" +
                   $"\nNet Salary: {Math.Round(Calculate(), 2)}  $";
        }


    }

}