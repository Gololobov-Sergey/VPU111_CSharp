using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    /// <summary>
    /// Клас вакансії
    /// </summary>
    internal class Job
    {
        /// <summary>
        /// 
        /// </summary>
        public long ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Region.Split(',')[0].PadRight(30)} {Name.PadRight(20)} {Salary.ToString().PadRight(10)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="Job">description</exception>
        public int method(int a, int b)
        {
            return 0;
        }
    }

}
