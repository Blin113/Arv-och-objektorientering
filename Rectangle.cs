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

        public override void AreaCalc()
        {
            double area = width * height;

            Console.WriteLine("area: " + area);
        }

        public override void CircumferenceCalc()
        {
            double circumference = (width * 2) + (height * 2);

            Console.WriteLine("circumference: " + circumference);
        }
    }
}