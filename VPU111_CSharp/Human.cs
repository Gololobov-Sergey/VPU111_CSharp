using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    internal /*sealed*/ class Human
    {
        protected int id;
        public string Name { get; set; }
        public DateTime BirthDat { get; set; }

        public Human(string n, DateTime d)
        {
            Name = n;
            BirthDat = d;
        }

        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(BirthDat.ToShortDateString());
        }
    }


    class Employee : Human
    {
        new int id;

        public int Salary { get; set; }

        public Employee(string n, DateTime d, int s) : base(n, d)
        {
            Salary = s;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine(Salary);
        }
    }
}
