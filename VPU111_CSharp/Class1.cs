using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    class Calc
    {
        public int Sum(int a, int b) => a + b;
        static public int Diff(int a, int b) => a - b;
        public int Mult(int a, int b) => a * b;
        public int Div(int a, int b) => a / b;
    }

    static partial class ExtensionMethod
    {
        public static string MultiString(this string data, int n)
        {
            string d = "";
            for (int i = 0; i < 3; i++)
            {
                d += data;
            }
            return d;
        }
    }


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class ProgrammerAttribute : Attribute
    {
        public string Name { get; set; } = "Serg";

        public DateTime Date { get; set; } = DateTime.Now;


        public ProgrammerAttribute()
        {

        }

        public ProgrammerAttribute(string name, string date)
        {
            Name = name;
            Date = Convert.ToDateTime(date);
        }

        public override string ToString()
        {
            return $"Programmer: {Name}, DateCreate: {Date}";
        }
    }
}
