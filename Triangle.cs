using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Triangle : Shape
    {
        public Triangle(double w, double h) : base(w, h)
        {

        }

        public double AreaCalc()
        {
            double area = (width * height) / 2;

            return area;
        }

        public double CircumferenceCalc()
        {
            double x = (width * width) + (height * height);

            double hyp = Math.Sqrt(x);

            double circumference = width + height + hyp;

            return circumference;
        }
    }
}