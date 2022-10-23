using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    internal class Student
    {

        public string Name { get; set; } = "Serg";

        public DateTime BirthDay { get; set; }

        private int age;

        public int Age
        {
            get 
            { 
                return age; 
            }
            set
            {
                if (value >= 0 && value < 120)
                {
                    age = value;
                }
            }
        }

    }
}
