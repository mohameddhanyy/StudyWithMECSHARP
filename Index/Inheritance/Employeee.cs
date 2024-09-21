namespace Index.Inheritance
{



    public abstract class Employeee
    {
        private const int MinimumLoggedHour = 176;
        private const decimal OverTimeRate = 1.25m;
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }



        public virtual decimal CalculateBaseSalary()
        {
            return MinimumLoggedHour * Wage;
        }
        public virtual decimal CalculateOverTimeSalary()
        {
            var overTimeHours = LoggedHours - MinimumLoggedHour > 0 ? LoggedHours - MinimumLoggedHour : 0;
            return overTimeHours * Wage * OverTimeRate;
        }
        public virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTimeSalary();
        }

        public override string ToString()
        {
            return $"\nID: {ID}" +
                   $"\nName: {Name}" +
                   $"\nLogged Hours: {LoggedHours} hr" +
                   $"\nWage: {Wage} $/hr";
        }




    }
}