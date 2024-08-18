namespace Index
{
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
            Console.WriteLine(id.Display());

            #endregion

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

        public ID(string s)  // 123.652.36.14
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

        #endregion


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

    }
}