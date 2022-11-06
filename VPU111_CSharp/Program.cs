﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using System.Text;

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

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "VPU111";
            Console.OutputEncoding = Encoding.Unicode;
            //Console.

            /////// 06.11.2022 ////////

            Group group = new Group();
            foreach (Student item in group)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //group.Sort(new DateComparer());
            group.Sort(Student.FromBirthDate);
            foreach (Student item in group)
            {
                Console.WriteLine(item);
            }

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
