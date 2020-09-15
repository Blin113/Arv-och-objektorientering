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

        public override void AreaCalc()
        {
            double area = (width * height) / 2;

            Console.WriteLine("area: " + area);
        }

        public override void CircumferenceCalc()
        {
            double x = (width * width) + (height * height);

            double hyp = Math.Sqrt(x);

            double circumference = width + height + hyp;

            Console.WriteLine("circumference: " + circumference);
        }
    }
}