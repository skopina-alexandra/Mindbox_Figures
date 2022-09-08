using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        public double radius;

        public Circle(double radius)
        {   
            if (radius <= 0 )
            {
                throw new ArgumentException("Radius must be a positive number");
            }

            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

    }
}
