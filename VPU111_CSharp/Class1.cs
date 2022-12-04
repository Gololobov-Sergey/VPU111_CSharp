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

    static class ExtensionMethod
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
}
