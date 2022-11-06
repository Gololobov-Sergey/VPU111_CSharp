using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    internal /*sealed*/ abstract class Human
    {
        protected int id;
        public string Name { get; set; }
        public DateTime BirthDat { get; set; }

        //public abstract void Work();
        public Human() { }

        public Human(string n, DateTime d)
        {
            Name = n;
            BirthDat = d;
        }

        public override string ToString()
        {
            return $"Name: {Name}" + $"\nBirthDay: {BirthDat.ToShortDateString()}";
        }

        //public virtual void Print()
        //{
        //    Console.WriteLine($"Name: {Name}");
        //    Console.WriteLine("BirthDay: " + BirthDat.ToShortDateString());
        //}
    }


    class Employee : Human
    {
        new int id;

        public int Salary { get; set; }

        public Employee():base ("", DateTime.Now) { }

        public Employee(string n, DateTime d, int s) : base(n, d)
        {
            Salary = s;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSalary : {Salary}";
        }

        //public override void Work()
        //{

        //    Console.WriteLine("Im work in Fabric");
        //}

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Salary: {Salary}");
        //}
    }

    class Specialist : Human
    {
    
        public int Rating { get; set; }

        public Specialist(string n, DateTime d, int r) : base(n, d)
        {
            Rating = r;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nRating : {Rating}";
        }

        //public override void Work()
        //{
        //    Console.WriteLine("Im work in Bank");
        //}

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Rating : {Rating}");
        //}
    }


    class Doctor : Human
    {

        public int Pacient { get; set; }
        

        public Doctor(string n, DateTime d, int p) : base(n, d)
        {
            Pacient = p;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPacient : {Pacient}";
        }

        //public override void Work()
        //{
        //    Console.WriteLine("Im work in Hospital");
        //}



        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($"Pacient : {Pacient}");
        //}
    }

    class Director : Employee, IManager
    {
        public Director(string n, DateTime d, int s) : base(n, d, s) {  }

        public List<IWork> Workers { get; set ; }

        public void Organize()
        {
            Console.WriteLine("I`m Organize");
        }

        public void Planing()
        {
            Console.WriteLine("I`m planing");
        }
    }

    class Seller : Employee, IWork
    {
        public bool IsWorking { get; set; }

        public string Work()
        {
            return IsWorking ? "Я працюю, і продаю товар" : "Я зараз не працюю";
        }
    }

    class Supervisor : Employee, IWork
    {
        public bool IsWorking { get; set; }

        public string Work()
        {
            return IsWorking ? "Я працюю, і керую відділом" : "Я зараз у відпустці";
        }
    }

}
