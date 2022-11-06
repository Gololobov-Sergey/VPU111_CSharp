using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    interface IWork
    {
        bool IsWorking { get; set; }
        string Work();
    }

    interface IManager
    {
        List<IWork> Workers { get; set; }
        void Planing();
        void Organize();
    }




    interface IA
    {
        void Print();
    }

    interface IB
    {
        void Print();
    }

    interface IC
    {
        void Print();
    }

    class MyClass11 : IA, IB, IC
    {
        //public void Print()
        //{
        //    Console.WriteLine("Print");
        //}
        void IA.Print()
        {
            Console.WriteLine("Print A");
        }

        void IB.Print()
        {
            Console.WriteLine("Print B");
        }

        public void Print()
        {
            Console.WriteLine("Print C");
        }

    }

}
