using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_6_OPP.First_Project
{
    internal class _3D_Point :IComparable, ICloneable
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public _3D_Point(int a, int b) : this(a, b, 0) { }

        public _3D_Point(int a, int b, int c)
        {
           this.a = a;
           this.b = b;
           this.c = c;
        }

        public override string ToString()
        {
            return $"Point Coordinates:{a},{b},{c}";
        }
        public bool compare_twoPoint(_3D_Point point)
        {
            return a == point.a && b == point.b && c == point.c;
        }

        public int CompareTo(object? obj)
        {
            _3D_Point? other =(_3D_Point?)obj;
            if (a != other?.a)
            { return a.CompareTo(other?.a); }

            else
            { return b.CompareTo(other?.b); }
        }

        public object Clone()
        {
            return new _3D_Point(this.a, this.b, this.c);
        }
    }
}
