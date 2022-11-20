using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace VPU111_CSharp
{

    partial class MyClass
    {
        public const int x = 10;

        public readonly int y;

        public readonly int[] arr = { 1, 2, 3 };

        static int st;

        public static int getSt()
        {
            return st;
        }

        static MyClass()
        {
            st = 1000;
        }

        public MyClass() : this(100)
        {

        }

        public MyClass(int y)
        {
            this.y = y;
        }

        public void MA()
        {
            a a = new a();
            a.A(this);
        }

        public void MA(int b)
        {
            a a = new a();
            a.A(this);
        }
    }

    class a
    {
        public void A(MyClass m)
        {

        }
    }

    struct MyStruct
    {
        public int Field;

        public MyStruct(int f)
        {
            Field = f;
        }

        public void Print()
        {
            Console.WriteLine(Field);
        }
    }

    enum Direction : ulong
    {
        UP = 10000000000, DOWN, LEFT, RIGHT
    }

    internal class Program
    {

        static int Method(ref int[] arr, out int a)
        {
            arr[0] = 1000;
            a = 100;
            a++;
            arr = new int[] { 5, 6, 7 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            return 0;
        }

        static int SUM(int r, params int[] arr)
        {
            int res = 0;
            foreach (int item in arr)
            {
                res += item;
            }
            return res;
        }

        static int Div(int a, int b)
        {
            int res = 0;
            try
            {
                res = a % b;
            }
            catch (DivideByZeroException e)
            {

                throw; /*new DivideByZeroException("Added inform", e);*/
            }
            return res;
        }

        static void SetMark(Hashtable students, string fName, string lName, int mark)
        {
            foreach (Student item in students.Keys)
            {
                if(item.FirstName == fName && item.LastName == lName)
                {
                    (students[item] as ArrayList).Add(mark);
                }
            }
        }

        static void PrintMark(Hashtable students)
        {
            foreach (Student item in students.Keys)
            {
                Console.Write($"{item.LastName} {item.FirstName} - ");
                foreach (int marks in students[item] as ArrayList)
                {
                    Console.Write(marks + " ");
                }
                Console.WriteLine();
            }
        }

        static void SetName(string name333, string n2 = "sd")
        {
            if (name333 == null)
                throw new ArgumentNullException(nameof(name333));
            Console.WriteLine(name333);
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "VPU111";
            Console.OutputEncoding = Encoding.Unicode;
            //Console.

            ////   20.11.2022 //////
            ///


            //int count = 10000000;
            //using(new OperationTimer("ArrayList"))
            //{
            //    ArrayList array = new ArrayList();
            //    for (int i = 0; i < count; i++)
            //    {
            //        array.Add(i);
            //        int x = (int)array[i];
            //    }
            //    array = null;
            //}


            //using(new OperationTimer("List"))
            //{
            //    List<int> l = new List<int>();
            //    for (int i = 0; i < count; i++)
            //    {
            //        l.Add(i);
            //        int x = l[i];
            //    }
            //    l = null;
            //}


            Student s = new Student { FirstName = "Vasyasdfg", LastName = "Pupsdfgkin" };
            Console.WriteLine(s.GetHashCode());
            Student s1 = new Student { FirstName = "Vasya", LastName = "Pupkin" };
            Console.WriteLine(s1.GetHashCode());

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "one");
            //hashtable.Add("two", 2);
            //hashtable.Add(s, new Student { FirstName = "Olga", LastName = "Pupkina" });
            //Console.WriteLine(s.GetHashCode());
            //foreach (var item in hashtable.Keys)
            //{
            //    Console.WriteLine(hashtable[item]);
            //}

            //SortedList sl = new SortedList();
            //sl.Add(1, "one");
            //sl.Add(2, 2);
            //sl.Add(-4, new Student { FirstName = "Olga", LastName = "Pupkina" });
            //foreach (var item in sl.Keys)
            //{
            //    Console.WriteLine(sl[item]);
            //}


            //Hashtable students = new Hashtable
            //{
            //    {
            //    new Student
            //        {
            //            FirstName = "Oleg",
            //            LastName = "Ivanov",
            //            BirthDay = new DateTime(1990, 2, 12),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AB",
            //                Number = 123456
            //            }
            //}, new ArrayList{9,9,9} },
            //    {
            //    new Student
            //        {
            //            FirstName = "Olga",
            //            LastName = "Petrova",
            //            BirthDay = new DateTime(1990, 1, 4),
            //            StudentCard = new StudentCard
            //            {
            //                Series = "AB",
            //                Number = 123450
            //            }
            //    }, new ArrayList{9,9,9} }
            //};

            //PrintMark(students);
            //Console.WriteLine();
            //SetMark(students, "Oleg", "Ivanov", 10);
            //PrintMark(students);
            //Console.WriteLine();
            //SetMark(students, "Olga", "Petrova", 10);
            //PrintMark(students);



            //using (GarbageMaker gm = new GarbageMaker())
            //{
            //    Console.WriteLine(GC.MaxGeneration);


            //    Console.WriteLine(GC.GetGeneration(gm));

            //    Console.WriteLine(GC.GetTotalMemory(false));

            //    gm.Make();

            //    Console.WriteLine(GC.GetGeneration(gm));

            //    Console.WriteLine(GC.GetTotalMemory(false));

            //    GC.Collect();

            //    Console.WriteLine(GC.GetTotalMemory(false));

            //    Console.WriteLine(GC.GetGeneration(gm));

            //    GC.Collect();

            //    Console.WriteLine(GC.GetTotalMemory(false));
            //    Console.WriteLine(GC.GetGeneration(gm));
            //}

            //gm.Dispose();

            ///// 13.11.2022 /////
            ///


            //try
            //{

            //    SetName(null);

            //    Console.WriteLine(Div(6, 0));
            //    //checked
            //    //{
            //        byte b = 100;
            //        b = (byte)(b + 200);
            //        Console.WriteLine(b);
            //    //}

            //    unchecked
            //    {

            //    }

            //}
            //catch (DivideByZeroException e) when (e.InnerException != null)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.HelpLink);
            //    Console.WriteLine(e.TargetSite);
            //    foreach (var item in e.Data.Keys)
            //    {
            //        Console.WriteLine($"{item} {e.Data[item]}");
            //    }
            //    Console.WriteLine(e.InnerException?.Message);
            //    Console.WriteLine(e.Source);
            //    Console.WriteLine(e.HResult);

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch
            //{
            //    Console.WriteLine("Fatal Error");
            //}
            //finally
            //{

            //}


            //Student st = new Student
            //{
            //    FirstName = "Oleg",
            //    LastName = "Ivanov",
            //    BirthDay = new DateTime(1990, 2, 12),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AB",
            //        Number = 123456
            //    }
            //};

            //Student st2 = (Student)st.Clone();
            //st2.StudentCard.Series = "TT";

            //Console.WriteLine(st);
            //Console.WriteLine(st2);





            /////// 06.11.2022 ////////

            //Group group = new Group();
            //foreach (Student item in group)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            ////group.Sort(new DateComparer());
            //group.Sort(Student.FromBirthDate);
            //foreach (Student item in group)
            //{
            //    Console.WriteLine(item);
            //}

            //MyClass11 myClass11 = new MyClass11();
            //myClass11.Print();

            //(myClass11 as IB).Print();


            //IA ia = new MyClass11();
            //ia.Print();


            //Director director = new Director("Ira", new DateTime(2004, 11, 11), 14000);

            //IWork worker1 = new Seller {
            //    Name = "Oleg", BirthDat = new DateTime(2000, 10, 10), 
            //    Salary = 10000, IsWorking = true };

            //IWork worker2 = new Seller
            //{
            //    Name = "Olga",
            //    BirthDat = new DateTime(2000, 10, 10),
            //    Salary = 11000,
            //    IsWorking = false
            //};

            //IWork worker3 = new Seller
            //{
            //    Name = "Orest",
            //    BirthDat = new DateTime(2000, 10, 10),
            //    Salary = 12000,
            //    IsWorking = true
            //};

            //IWork worker4 = new Supervisor
            //{
            //    Name = "Valery",
            //    BirthDat = new DateTime(2000, 10, 10),
            //    Salary = 14000,
            //    IsWorking = true
            //};

            ////Doctor employee = new Doctor("Vasya", new DateTime(2000, 11, 11), 5000);

            //director.Planing();
            //director.Organize();

            //director.Workers = new List<IWork>();
            //director.Workers.Add(worker1);
            //director.Workers.Add(worker2);
            //director.Workers.Add(worker3);
            //director.Workers.Add(worker4);

            //foreach (IWork item in director.Workers)
            //{
            //    Console.Write((item as Human).Name + " ");
            //    Console.WriteLine(item.Work());
            //}


            //Human[] humans = { new Employee("Vasya", new DateTime(2012, 11, 11), 5000),
            //    new Specialist("Ira", new DateTime(2004, 11, 11), 4000),
            //    new Doctor("Kolya", new DateTime(2008, 11, 11), 6000)
            //};

            //foreach (var item in humans)
            //{
            //    Console.WriteLine(item);
            //    //item.Work();
            //    Console.WriteLine();

            //    //try
            //    //{
            //    //    ((Employee)item).Print();
            //    //}
            //    //catch
            //    //{
            //    //}

            //    //Specialist s = item as Specialist;
            //    //if(s != null)
            //    //{
            //    //    s.Print();
            //    //}


            //    //if(item is Doctor)
            //    //{
            //    //    Doctor doctor = (Doctor)item;
            //    //    (item as Doctor).Print();
            //    //}

            //}

            //Doctor employee = new Doctor("Vasya", new DateTime(2000, 11, 11), 5000);
            //employee.Print();
            //Console.WriteLine(employee);


            /////// 30.10.2022 ///////////
            ///



            //Employee employee = new Employee("Vasya", new DateTime(2000, 11, 11), 5000);
            //employee.Print();



            //Point p = new Point () { X = 5, Y = 6 };

            //p.Print();

            //Point p2 = -p;
            //p2.Print();

            //(++p).Print();
            //(p++).Print();

            //Point p3 = new Point() { X = 5, Y = 6 };// + p2;
            // p.X = 10;

            //p3.Print();
            //p3.Print();

            //p3 += p;
            //p3.Print();

            //p3 = p3 * 5;
            //p3 = 5 * p3;
            //p3.Print();

            //Console.WriteLine(p3.Equals(p));

            //if(p3 && p)
            //{

            //}

            //float f = p3;

            //Point p4 = (Point)3.25f;

            //Polygon polygon = new Polygon(10);

            //polygon[1].Print();
            //polygon["one"] = new Point() { X = 100, Y = 100 };
            //polygon["one"].Print();
            //polygon[2,"one"].Print();   

            //if(card == 235)
            //{

            //}

            ////// 23.10.2022 /////////////
            ///


            //Student student = new Student() 
            //{ 
            //    Name = "Serg", 
            //    Age = 40, 
            //    BirthDay = new DateTime(2000, 10, 10)
            //};

            //student.Age = 30;
            //Console.WriteLine(student.Age);
            //student.SetName("Serg");

            //Console.WriteLine(SUM(new int[] {2,3,4,5}));
            //Console.WriteLine(SUM(2,3,4,5, 1));


            //int[] arr = { 1, 2, 3 };
            //int a;

            //Method(ref arr, out a);

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(a);


            //MyClass myClass = new MyClass(100);

            // myClass.METHOD();

            //Console.WriteLine(myClass.y);
            ////myClass.arr = new int[] { 2, 3, 4 };
            //myClass.arr[0] = 1000;
            ////myClass.getSt();
            //MyClass.getSt();

            //MyStruct s;
            //s = new MyStruct(12);
            //s.Print();


            //Console.WriteLine("Hello World!");


            //Random random = new Random();
            //random.Next(100, 200);

            //foreach (var item in args)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = "Hello mama, jhsdjkf, skjdf aasd ghfg     dfgdfg rer";
            //string[] str2 = str.Split(" .,!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //foreach (string str3 in str2)
            //    Console.WriteLine(str3);
            //string str5 = String.Empty;

            //str5 += str;


            //foreach (var item in Enum.GetNames(typeof(Direction)))
            //{
            //    Console.WriteLine(item);
            //}

            //var dir = Direction.DOWN;
            //dir = (Direction)1;


            //switch (Direction)
            //{
            //    case Direction.UP:
            //        break;
            //    case Direction.DOWN:
            //        break;
            //    case Direction.LEFT:
            //        break;
            //    case Direction.RIGHT:
            //        break;
            //    default:
            //        break;
            //}


            //string str2 = str;
            //str = "Gello";
            //Console.WriteLine(str2);



            //int[] arr;
            //arr = new int[] { 2, 5, 3, 5, 7, 6, 3 };
            //foreach (int item in arr)
            //{
            //    Console.Write($"{item:M} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(arr.Sum());

            //arr = null;


            //int[,] arr2 = { { 2, 5, 3 }, { 5, 7, 6 }, { 3, 3, 4 } };
            //int[,] arr3 = new int[2,3];
            //int[,] arr4 = new int[,] { { 2, 5, 3 }, { 5, 7, 6 }, { 3, 3, 4 } };

            //arr4[2, 1] = 100;

            //for (int i = 0; i < arr4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr4.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr4[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //int[][] arr7 = new int[2][];
            //arr7[0] = new int[] { 1, 2, 3, 4 };
            //arr7[1] = new int[] {3, 4 };

            //for (int i = 0; i < arr7.Length; i++)
            //{
            //    foreach (var item in arr7[i])
            //    {
            //        Console.Write($"{item} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            //string s = Console.ReadLine();

            //int c = Convert.ToInt32(s);
            //Console.WriteLine(c);



            //int a = 5;
            //Int32 b = 5;

            //int c = Convert.ToInt32(Console.ReadLine());
            //int c1 = Int32.Parse(Console.ReadLine());

            //int c2 = 100;
            //Int32.TryParse(Console.ReadLine(), out c2);
            //Console.WriteLine(c2);

            //int f = (int)8.2;

            //int? num = null;
            //num = num ?? 20;





            Console.ReadKey();
        }
    }
}
