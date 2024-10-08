﻿using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Index.Inheritance;

namespace Index
{
    public delegate void RecDele(int width, int height);
    public delegate void OnChange(Porsa O, decimal changePrice);
    internal class Program
    {
        static void Main(string[] args)
        {

            #region important of oop
            //Employee employee = new Employee();
            //Console.Write("TAX :");
            //bool t = double.TryParse(Console.ReadLine(), out double result);
            //Employee.TAX = result;

            //Console.Write("Fname :");
            //employee.Fname = Console.ReadLine();
            //Console.Write("Lname :");
            //employee.Lname = Console.ReadLine();
            //Console.Write("Logged Hours :");
            //employee.LoggedHours = int.Parse(Console.ReadLine());
            //Console.Write("Wage :");
            //employee.Wage = int.Parse(Console.ReadLine());

            //employee.Print();

            #endregion

            #region methods

            //// passing by value
            //// value type 
            //DoAction d = new DoAction();
            //var age = 18;
            //d.DoValuev(age);
            //// reference type 
            //int[] arr = { 1, 2, 3 };
            //d.DoValuer(arr);
            //Console.WriteLine(arr[2]);

            //// passing by refernce
            //// value type
            //var x = 10;
            //var y = 20;
            //d.DoRefencev(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //// refernce type
            //int[] arr1 = { 1, 2, 3 };
            //d.DoRefencer(ref arr1);
            ////Console.WriteLine(arr1[2]);

            //// out modifier
            //int z = 10;
            //int outer;
            //int inter = 10100000;
            //int result = d.outmodifier(z, out outer, in inter);
            //Console.WriteLine($"{result},{outer}");

            //// params modifier
            //string s = null;
            //d.paramms(s, 1, 2, 3, 4, 5, 6, 7);

            //// optional 
            //d.testOptional();

            //// named argument 
            //d.NamedArg(y: 20, x: 10, z: 30);

            ////Ref Locals
            //int[] arrref = { 1, 2, 3, 4 };
            //arrref[0] = 10;
            //ref int reef = ref arrref[0];
            //Console.WriteLine(reef);
            //Console.WriteLine(arrref[0]);

            #endregion

            #region test
            //int age ;
            //test2 t = new test2();
            //t.me(out age );


            #endregion

            #region Problem Solving
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //str1= str2;
            //str1 = "HANN";
            //string str3 = str1 + " " + str2;
            //Console.WriteLine(str3 );

            //int[] arr1 = { 1, 5, 3, 4, 5 };
            //int[] arr2 = { 1, 2, 3 };
            //arr1 = arr2;
            //arr1[2] = 60;
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr1[1]);

            // int x = 0;
            // int y = 50;
            // x = y;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // string s = "hello world";
            //string ns= s.Substring(3);
            // Console.WriteLine(ns);

            #endregion

            #region Constructor 

            //Date d = new Date(10, 2000);
            //Console.WriteLine(d.Print());

            //Ob oo = Ob.Create(1,"Mo","Ha");


            //Console.WriteLine(oo.Display());

            #endregion

            #region Properties 
            //Dollar d = new Dollar(1.025M);
            //Console.WriteLine(d.Amount);
            //d.Amount = 1.9990m;
            //Console.WriteLine(d.Amount);
            #endregion

            #region Indexers ID.Ex


            ID id = new ID("255.255.25.2");
            id[2] = 1;
            //Console.WriteLine(id.Display());

            #endregion

            #region Delegate
            //var emps =new Emp[]
            //{
            //    new Emp{Id = 1, Name = "Mohamed", Gender ="Male", TotalSales = 4100M },
            //    new Emp{Id = 2, Name = "Amr", Gender ="Male", TotalSales = 8000m },
            //    new Emp{Id = 3 ,Name = "Mai", Gender ="Female", TotalSales = 6000m },
            //    new Emp{Id = 4, Name = "Shahd", Gender ="Female", TotalSales = 11000m },
            //    new Emp{Id = 5, Name = "Hany", Gender ="Male", TotalSales = 3000M },
            //    new Emp{Id = 6, Name = "Ismail", Gender ="Male", TotalSales =7000m },
            //    new Emp{Id = 7 ,Name = "Amany", Gender ="Female", TotalSales = 2000m },
            //    new Emp{Id = 8, Name = "Fatma", Gender ="Female", TotalSales = 9500m }

            //};

            //Report r = new Report();
            //r.Process(emps, "This Employees Less Than 5000$", e =>e.TotalSales < 5000);
            //r.Process(emps, "This Employees between 5000 And 8000", e => e.TotalSales > 5000 && e.TotalSales < 8000);
            //r.Process(emps, "This Employees Up 8000", e => e.TotalSales > 8000);

            // MultiCast Delegate

            //Rectangle rec = new Rectangle();
            //rec.Area(10,10);
            //rec.Paremeter(10,10);

            //RecDele recdele;
            //recdele = rec.Area;
            //recdele += rec.Paremeter; 
            //recdele(10,10);

            //recdele -= rec.Paremeter;
            //recdele(40, 40);
            #endregion

            #region Event
            //var s = new Stock("Amazon");
            //s.Price = 100m;
            //s.OnChangePrice += (s ,oldPrice) => {
            //    var result = "";
            //    if (s.Price < oldPrice)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        result = "Down";
            //    }
            //    else if (s.Price > oldPrice)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        result = "Up";
            //    }
            //    else
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    Console.WriteLine($"{s.Name} : {s.Price} -- {result}");
            //}; 

            //s.ChangePriceBy(0.05M);
            //s.ChangePriceBy(-0.05M);
            //s.ChangePriceBy(0.00M);
            #endregion

            #region Operator OverLoading

            //Money m1 = new Money(10);
            //Money m2 = new Money(20);
            //Money m3 = ++m1;
            //Console.WriteLine(m3.Amount);


            #endregion

            #region Finilizer (Garbage Collector)
            //Person p = new Person();
            //Version();
            //Console.WriteLine($"Before Call Garbage Collctor{GC.GetTotalMemory(false):N}");
            //GC.Collect();
            //Console.WriteLine($"After Call Garbage Collctor{GC.GetTotalMemory(true):N}");
            //p.Name = "Mohamed";

            #endregion

            #region Struct

            //St s = new St();
            //Console.WriteLine(s.MyProperty);
            //s.MyMethod();
            #endregion

            #region Enum
            //var End = Day.Saturday;
            //if (Day.WeekEnd.HasFlag(End))
            //{
            //    Console.WriteLine("Enjoy");
            //}
            //else
            //{
            //    Console.WriteLine("Not Enjoy");
            //}

            //var m = "FEB";
            //Console.WriteLine((int)Enum.Parse(typeof(Month), m));
            //if (Enum.TryParse(m, out Month mo))
            //{
            //    Console.WriteLine(mo.ToString());
            //    Console.WriteLine((int)mo);
            //}
            //if (Enum.IsDefined(typeof(Month), m))
            //{
            //    Console.WriteLine(Enum.Parse(typeof(Month), m));
            //    Console.WriteLine((int)Enum.Parse(typeof(Month), m));
            //}

            // LOOP IN ENUM


            //foreach (var x in Enum.GetValues(typeof(Month)))
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine((int)x);
            //}

            //foreach (var x in Enum.GetNames(typeof(Month)))
            //{
            //    Console.WriteLine($"{x} : {(int)Enum.Parse(typeof(Month), x)}");
            //}
            #endregion

            #region Event Examples
            //Porsa o = new Porsa("Amazon");
            //o.Price = 1000; 
            //o.OnChangePrice += (Porsa o, decimal changePrice)=>
            //{
            //    if (changePrice > o.Price)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Down");
            //    }
            //    else if (changePrice < o.Price)
            //    {
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Up");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Equal");
            //    }
            //};
            //o.Change(20);
            #endregion

            #region Inheritance
            Animal test = new Animal();
            test.Name = "donky";
            //Console.WriteLine(test);

            Eagle e = new Eagle();
            //e.Move();
            Animal a = e;
            //e.Fly();
            // UpCasting 
            //Animal a = e;
            //a.Move();
            // DownCasting
            //Eagle e2 = new Eagle();
            //e2 = (Eagle)a;

            // Constructor and Inheritance 
            //SubClass sub = new SubClass("hany",10);
            //Console.WriteLine(sub)/*;*/
            #endregion

            #region Example Inheritance
            Manager m = new Manager()
            {
                ID = 1000,
                Name = "Mohamed Hany",
                LoggedHours = 176,
                Wage = 1
            };
            //Console.WriteLine(m);

            Maintenance ma = new Maintenance()
            {
                ID = 1000,
                Name = "Mohamed Hany",
                LoggedHours = 180,
                Wage = 2,
            };
            //Console.WriteLine(ma);

            Developer d = new Developer()
            {
                ID = 100,
                Name = "Reem A",
                LoggedHours = 180,
                Wage = 14,
                TaskCompleted = true,
            };
            //Console.WriteLine(d);


            #endregion

            #region Interface
            CaterPaler c = new CaterPaler("Honda", "Civic", 2020);
            //c.Move();

            #endregion

            #region Interface Example
            Cashier c1 = new Cashier(new Visa(99999.99m));
            //Console.WriteLine(c1);
            #endregion


            Console.ReadKey();
        }
    }


    #region Constructor
    public class Date
    {

        private static readonly int[] DayToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] DayToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private readonly int day;
        private readonly int month;
        private readonly int year;

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            var Leap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year > 0 && year <= 9999 && month > 0 && month < 31)
            {
                int[] days = Leap ? DayToMonth366 : DayToMonth365;
                if (day > 0 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
                else
                {
                    this.day = 0;
                    this.month = 0;
                    this.year = 0;
                }
            }
            else
            {
                this.day = 0;
                this.month = 0;
                this.year = 0;
            }
        }

        // constructor overloading 
        public Date(int year) : this(01, 01, year)
        {
        }
        public Date(int month, int year) : this(01, month, year)
        {
        }


        public string Print()
        {
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
        }
    }
    #endregion

    #region Method

    //class test2
    //{
    //    public int me(out int age)
    //    {
    //        age = 10;
    //        return age;
    //    }
    //}
    //public class DoAction
    //{
    //    public int DoValuev(int age)
    //    {
    //        age = age * 2;
    //        return age;
    //    }
    //    public void DoValuer(int[] a)
    //    {
    //        a[2] = 5;
    //        a = null;
    //    }
    //    public void DoRefencev(ref int x, ref int y)
    //    {
    //        var temp = x;
    //        x = y;
    //        y = temp;
    //    }

    //    public void DoRefencer(ref int[] a)
    //    {
    //        a[2] = 5;
    //        a = null;
    //    }

    //    public int outmodifier(int x, out int y,in int d)
    //    {
    //        y = x*d;
    //        return x * x * y;
    //    }


    //    public void paramms(string s,params int[] a )
    //    {
    //        a[0] = 5;
    //        a[1] = 5;
    //        Console.WriteLine(a[4]);
    //        Console.WriteLine(a[2]);
    //        s= "hap";
    //        Console.WriteLine(s);

    //    }

    //    public void testOptional(int x =  0, int y = 0)
    //    {
    //        Console.WriteLine(x);
    //        Console.WriteLine(y);
    //    }

    //    public void NamedArg(int x , int y, int z )
    //    {
    //        Console.WriteLine(x);
    //        Console.WriteLine(y);
    //        Console.WriteLine(z);
    //    }

    //}

    #endregion

    #region Object Initializer 
    public class Ob
    {
        public int Id;
        public string FName;
        public string LName;

        private Ob(int id, string fname, string lname)
        {
            Id = id;
            FName = fname;
            LName = lname;
        }

        public static Ob Create(int id, string fName, string LName)
        {
            return new Ob(id, fName, LName);
        }
        public string Display() => $"Id: {Id} ,FirstName: {FName} ,LastName: {LName}.";
    }
    #endregion

    #region Properties
    public class Dollar
    {
        private decimal _amount;

        public decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = ProcessValue(value);
            }
        }

        public Dollar(decimal amount)
        {
            _amount = ProcessValue(amount);
        }

        private decimal ProcessValue(decimal value) => value <= 0 ? 0 : Math.Round(value, 2);
    }


    #endregion

    #region Indexers
    public class ID
    {
        private int[] ids = new int[4];

        // indexer
        public int this[int indx]
        {
            get
            {
                return ids[indx];
            }
            set
            {
                ids[indx] = value;
            }
        }

        public ID(string s)  // 123.652.36.14 as string 
        {
            var r = s.Split(".");
            for (int i = 0; i < ids.Length; i++)
            {
                ids[i] = int.Parse(r[i]);
            }


        }
        public ID(int Seg1, int Seg2, int Seg3, int Seg4)
        {
            ids[0] = Seg1;
            ids[1] = Seg2;
            ids[2] = Seg3;
            ids[3] = Seg4;
        }

        public string Display() => string.Join(".", ids);
    }

    #endregion

    #region Delegate
    public class Rectangle

    {
        public void Area(int width, int height)
        {
            var result = width * height;
            Console.WriteLine($"Area: {width} * {height} = {result}");
        }

        public void Paremeter(int width, int height)
        {
            var result = (width + height) * 2;
            Console.WriteLine($"Paremeter: 2 * ({width} + {height}) = {result}");
        }
    }

    #endregion

    public delegate void ChangePriceHandler(Stock s, decimal oldPrice);

    #region Event
    public class Stock
    {
        public string Name { get; private set; }
        public decimal Price { get; set; }

        public event ChangePriceHandler OnChangePrice;

        public Stock(string name)
        {
            this.Name = name;
        }

        public void ChangePriceBy(decimal percent)
        {
            var oldPrice = Price;
            Price += Math.Round(Price * percent, 2);
            if (OnChangePrice != null)
                OnChangePrice(this, oldPrice);
        }

    }

    #endregion

    #region Operator OverLoading

    public class Money
    {
        public decimal Amount { get; private set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        // Arthematic Operators
        public static Money operator +(Money a, Money b) => new Money(a.Amount + b.Amount);
        public static Money operator -(Money a, Money b) => new Money(a.Amount - b.Amount);
        public static Money operator /(Money a, Money b) => new Money(a.Amount / b.Amount);
        public static Money operator *(Money a, Money b) => new Money(a.Amount * b.Amount);
        public static Money operator %(Money a, Money b) => new Money(a.Amount % b.Amount);

        // Relational Operators 
        public static bool operator >(Money a, Money b) => a.Amount > b.Amount;
        public static bool operator <(Money a, Money b) => a.Amount > b.Amount;
        public static bool operator >=(Money a, Money b) => a.Amount >= b.Amount;
        public static bool operator <=(Money a, Money b) => a.Amount <= b.Amount;
        public static bool operator ==(Money a, Money b) => a.Amount == b.Amount;
        public static bool operator !=(Money a, Money b) => a.Amount != b.Amount;

        // Unary Operator 
        public static Money operator ++(Money a) => new Money(++a.Amount);
        public static Money operator --(Money a) => new Money(--a.Amount);










    }
    #endregion

    #region Finilizer (Garbage Collector)
    //public class Person
    //{
    //    public string Name { get; set; }


    //    public Person()
    //    {
    //        Console.WriteLine("This is Constructor");

    //    }

    //    ~Person()
    //    {
    //        Console.WriteLine("This is Destructor");
    //    }
    //}
    #endregion

    #region Struct
    public struct St
    {
        private int z;
        public int MyProperty { get; set; }

        public void MyMethod()
        {
            Console.WriteLine("Do SomeThing Again");
        }



    }
    #endregion

    #region Enum
    enum Month : int
    {
        JAN = 1,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }

    [Flags]
    enum Day
    {
        Monday = 0b_0000_0001,// 1
        Tuesday = 0b_0000_0010,// 2
        Wednesday = 0b_0000_0100,// 4
        Thursday = 0b_0000_1000,// 8
        Friday = 0b_0001_0000,// 16
        Saturday = 0b_0010_0000,// 32
        Sunday = 0b_0100_0000,// 64
        BusDay = Monday | Tuesday | Wednesday | Thursday | Friday,
        WeekEnd = Saturday | Sunday,
    }
    #endregion

    #region Event Examples
    public class Porsa
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public event OnChange OnChangePrice;
        public Porsa(string name)
        {
            Name = name;
        }

        public void Change(decimal Percent)
        {
            var oldPrice = Price;
            Price += Math.Round(Price * Percent, 2);
            if (OnChangePrice != null)
                OnChangePrice(this, oldPrice);
        }
    }
    #endregion

    #region Inheritance
    class Animal
    {
        public string Name { get; set; }
        public virtual void Move()
        {
            Console.WriteLine("Im Moving");
        }
        public override string ToString()
        {
            return $"{Name} is Animal";
        }

    }
    class Eagle : Animal
    {
        public sealed override void Move()
        {
            Console.WriteLine("another moving");
        }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    public class BaseClass
    {
        public string Name { get; set; } = "";
        public int Id { get; set; } = 0;

        public BaseClass(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public BaseClass()
        {

        }

        public override string ToString()
        {
            return $"{Name} {Id}";
        }
    }

    public class SubClass : BaseClass
    {
        public SubClass() : base() { }
        public SubClass(string name, int id) : base(name, id) { }


    }

    #endregion

    #region Interface 
    class Vehicle
    {
        public Vehicle(string name, string model, int year)
        {
            Name = name;
            Model = model;
            Year = year;
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


    }

    class Honda : Vehicle
    {
        public Honda(string name, string model, int year) : base(name, model, year) { }


    }

    class CaterPaler : Vehicle, ILoad, IMove
    {
        public CaterPaler(string name, string model, int year) : base(name, model, year) { }
        public void Load()
        {
            Console.WriteLine("Loading");
        }
        public void UnLoad()
        {
            Console.WriteLine("UnLoading");
        }
        public void Move()
        {
            Console.WriteLine("Moving");
        }
        public void UnMove()
        {
            Console.WriteLine("UnMoving");
        }
    }

    interface ILoad
    {
        void Load();
        void UnLoad();
    }

    interface IMove
    {
        void Move();
        void UnMove();
    }


    #endregion

    #region Interface Example

    class Cashier
    {
        private IPayment _payment;

        public Cashier(IPayment payment)
        {
            _payment = payment;
        }

        public override string ToString()
        {
            return _payment.Pay() ;
        }
    }

    interface IPayment

    {
        string Pay();
    }


    class Cash : IPayment
    {
        public decimal Amount { get; set; }
        public Cash(decimal amount)
        {
            Amount = amount;
        }
        public string Pay()
        {
            return $"Cash Payment: ${Math.Round(Amount, 2):N0}";
        }
    }
    class Visa : IPayment
    {
        public decimal Amount { get; set; }
        public Visa(decimal amount)
        {
            Amount = amount;
        }

        public string Pay()
        {
            return $"Visa Payment: ${Math.Round(Amount, 2):N0}";
        }
    }
    class Depit : IPayment
    {
        public decimal Amount { get; set; }
        public Depit(decimal amount)
        {
            Amount = amount;
        }

        public string Pay()
        {
            return $"Depit Payment: ${Math.Round(Amount, 2):N0}";
        }
    }

    #endregion
}