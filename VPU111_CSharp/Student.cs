using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    class StudentCard : IComparable, ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();  
        }

        public int CompareTo(object x)
        {
            StudentCard sc = (StudentCard)x;   
            if (sc != null)
            {
                return (Series + Number.ToString()).CompareTo(sc.Series + sc.Number.ToString());
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Series + " " + Number;
        }
    }

    internal class Student : IComparable, ICloneable
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public static IComparer FromBirthDate { get { return new DateComparer(); } }

        public override string ToString()
        {
            return $"{LastName.PadRight(15)} {FirstName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            if (student != null)
            {
                return LastName.CompareTo(student.LastName);
            }
            else
                throw new NotImplementedException();
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = (StudentCard)StudentCard.Clone();
            return temp;
        }

        public override int GetHashCode()
        {
            return $"{LastName} {FirstName}".GetHashCode();

        }
    }


    class Group : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                FirstName = "Oleg",
                LastName = "Ivanov",
                BirthDay = new DateTime(1990, 2, 12),
                StudentCard = new StudentCard
                {
                    Series = "AB",
                    Number = 123456
                }
            },
            new Student
            {
                FirstName = "Olga",
                LastName = "Petrova",
                BirthDay = new DateTime(1990, 1, 4),
                StudentCard = new StudentCard
                {
                    Series = "AB",
                    Number = 123450
                }
            },
            new Student
            {
                FirstName = "Petro",
                LastName = "Fedoriv",
                BirthDay = new DateTime(1993, 1, 14),
                StudentCard = new StudentCard
                {
                    Series = "AC",
                    Number = 123456
                }
            },
            new Student
            {
                FirstName = "Irina",
                LastName = "Frolova",
                BirthDay = new DateTime(1985, 5, 8),
                StudentCard = new StudentCard
                {
                    Series = "AA",
                    Number = 123456
                }
            }
        };

        

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }


    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student && y is Student)
            {
                return (x as Student).BirthDay.CompareTo((y as Student).BirthDay);
            }
            throw new NotImplementedException();
        }
    }


    class StudentCardComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).StudentCard.CompareTo((y as Student).StudentCard);
            }
            throw new NotImplementedException();
        }
    }



    class GarbageMaker : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public void Make()
        {
            for (int i = 0; i < 100000; i++)
            {
                Student s = new Student();
            }
        }
    }
}


