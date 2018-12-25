using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Circle : Figure
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double area()
        {
            return 2 * Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return "Радиус круга = " + radius + ";Площадь = " + area();
        }
    }
}
