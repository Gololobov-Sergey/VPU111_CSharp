using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    class StudentCard : IComparable<StudentCard>, ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(StudentCard x)
        {

            return (Series + Number.ToString()).CompareTo(x.Series + x.Number.ToString());

        }

        public override string ToString()
        {
            return Series + " " + Number;
        }
    }

    internal class Student : IComparable<Student>, ICloneable
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public static IComparer<Student> FromBirthDate { get { return new DateComparer(); } }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"{LastName.PadRight(15)} {FirstName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public int CompareTo(Student obj)
        {
            return LastName.CompareTo(obj.LastName);
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

        //public void Exam(DateTime dateExam)
        //{
        //    Console.WriteLine($"Екзамен для {LastName} {FirstName} назначено на {dateExam.ToShortDateString()}") ;
        //}

        public void Exam(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Екзамен від {((Teacher)sender).Name} по {e.Subject} для {LastName} {FirstName} назначено на {e.DateExam.ToShortDateString()}");
        }
    }

    //public delegate void ExamDelegate(DateTime dt);

    class ExamEventArgs : EventArgs
    {
        public DateTime DateExam { get; set; }

        public string Subject { get; set; }
    }



    class Teacher
    {
        SortedList<string, EventHandler<ExamEventArgs>> list = new SortedList<string, EventHandler<ExamEventArgs>>();

        public event EventHandler<ExamEventArgs> ExamEvent
        {
            add
            {
                list.Add(((Student)value.Target).FirstName, value);
            }

            remove
            {
                list.Remove(((Student)value.Target).FirstName);
            }
        }

        public string Name { get; set; }

        public void SetExam(ExamEventArgs e)
        {
            //if (ExamEvent != null)
            //{
            //    ExamEvent(this, e);
            //}

            foreach (var item in list.Keys)
            {
                list[item](this, e);
            }
        }




        //public event ExamDelegate ExamEvent;

        //public void SetExam(string dateExam)
        //{
        //    if(ExamEvent != null)
        //    {
        //        ExamEvent(DateTime.Parse(dateExam));
        //    }
        //}
    }

    class Group /*: IEnumerable*/
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

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return students.GetEnumerator();
        //}


        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Length; i++)
            {
                yield return students[i];
            }
        }

        public IEnumerable<Student> GetStudentsTop3()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if(i == 3)
                {
                    yield break;
                }
                yield return students[i];
            }
        }
    }


    class DateComparer : IComparer<Student>
    {
        //public int Compare(object x, object y)
        //{
        //    if(x is Student && y is Student)
        //    {
        //        return (x as Student).BirthDay.CompareTo((y as Student).BirthDay);
        //    }
        //    throw new NotImplementedException();
        //}

        public int Compare(Student x, Student y)
        {
            return x.BirthDay.CompareTo(y.BirthDay);
        }
    }


    class StudentCardComparer : IComparer<Student>
    {
        //public int Compare(object x, object y)
        //{
        //    if (x is Student && y is Student)
        //    {
        //        return (x as Student).StudentCard.CompareTo((y as Student).StudentCard);
        //    }
        //    throw new NotImplementedException();
        //}

        public int Compare(Student x, Student y)
        {
            return x.StudentCard.CompareTo(y.StudentCard);
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


