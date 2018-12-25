using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Square : Rectangle
    {
        public Square(double lenght) : base(lenght, lenght) { }

        public override string ToString()
        {
            return "Сторона квадрата = " + length + "; Площадь = " + area();
        }
    }
}