using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_with_abstraction
{
    internal class Triangle : Shape, IComparable<Triangle>
    {
		private double a;
        public double A
		{
			get { return this.a; }
			set { this.a = value; }
		}

        private double b;
        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        private double c;
        public double C
        {
            get { return this.c; }
            set { this.c = value; }
        }

        public Triangle(string name, double a, double b,double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculatePerimeter()
        {
            double result = a+b+c;
            return result;
        }
        public override double CalculateArea()
        {
            double result = (a * b)/2;
            return result;
        }
        public int CompareTo(Triangle? other)
        {
            double result = a.CompareTo(other.a);
            if (result == 0)
            {
                result = a.CompareTo(other.a);
            }
            return (int)result;
        }
    }
}
