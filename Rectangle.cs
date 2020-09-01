using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w, h)
        {

        }

        public double AreaCalc()
        {
            double area = width * height;

            return area;
        }

        public double CircumferenceCalc()
        {
            double circumference = (width * 2) + (height * 2);

            return circumference;
        }

    }
}