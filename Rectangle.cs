using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Rectangle : Figure
    {
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double length { get; set; }
        public double width { get; set; }

        public override double area()
        {
            return length * width;
        }

        public override string ToString()
        {
            return "Длина прямоугольника = " + length + "; Ширина прямоугольника = " + width + "; Площадь прямоугольника= " + area();
        }
    }
}
