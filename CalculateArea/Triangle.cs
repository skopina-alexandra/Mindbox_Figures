using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {

        public double a;
        public double b;
        public double c;


        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be positive numbers");
            }

            if (a + b > c && a + c > b && c + b > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                return;
            }

            throw new ArgumentException("Triangle does not exist");
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

       public bool IsRight()
        {
            if (a > b && a > c)
            {
                return thePythagoreanTheoremIsSatisfied(b, c, a); 
            }

            if (b > c && b > a)
            {
                return thePythagoreanTheoremIsSatisfied(a, c, b);
            }

            return thePythagoreanTheoremIsSatisfied(a, b, c);

        }

        private bool thePythagoreanTheoremIsSatisfied (double a, double b, double c)//c is the longest side 
        {
            return c * c == a * a + b * b;
        } 

    }
}
