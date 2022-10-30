using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPU111_CSharp
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }


        public static Point operator -(Point p)
        {
            return new Point() { X = -p.X, Y = -p.Y };
        }


        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point() { X = p1.X - p2.X, Y = p1.Y - p2.Y };
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }

        public static Point operator *(Point p1, int n)
        {
            return new Point() { X = p1.X * n, Y = p1.Y * n };
        }

        public static Point operator *(int n, Point p1)
        {
            return p1 * n;
        }

        public override bool Equals(object obj)
        {
            return X == (obj as Point).X && Y == (obj as Point).Y;
        }

        public static bool operator==(Point p1, Point p2)
        {
            return (p1.X == p2.X && p1.Y == p2.Y);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1.X == p2.X && p1.Y == p2.Y);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator true(Point p1)
        {
            return p1.X != 0 || p1.Y != 0 ? true : false;
        }

        public static bool operator false(Point p1)
        {
            return p1.X == 0 && p1.Y == 0 ? true : false;
        }

        public static Point operator &(Point p1, Point p2)
        {
            return new Point();
        }

        public static /*explicit*/ implicit operator float(Point p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }


        public static explicit /*implicit*/ operator Point(float p)
        {
            return new Point();
        }
    }


    class Polygon
    {
        Point[] points;

        public Polygon(int count)
        {
            points = new Point[count];
            for (int i = 0; i < count; i++)
            {
                points[i] = new Point() 
                { 
                    X = (new Random()).Next(20), 
                    Y = (new Random()).Next(20) 
                };
            }
        }

        public Point this[int i] 
        {
            get
            {
                return points[i];
            }
            set
            {
                points[i] = value;
            }
        }


        public Point this[string s]
        {
            get
            {
                return s switch
                {
                    "one"   => points[1],
                    "two"   => points[2],
                    "three" => points[3],
                    _       => points[0]
                };
            }
            set
            {
               int i = s switch
               {
                   "one" => 1,
                   "two" => 2,
                   "three" => 3,
                   _ => 0
               };
                points[i] = value;
            }
        }

        public Point this[int i, string j]
        {
            get
            {
                return points[i];
            }
            set
            {
                points[i] = value;
            }
        }

    }

}
