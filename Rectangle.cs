using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : Shape
    {

        public Rectangle(int w, int h) : base(w, h)
        {

        }

        public void AreaCalc(ref int width, ref int height)
        {
            Console.WriteLine("insert width:");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("insert height:");
            height = int.Parse(Console.ReadLine());


            int area = width * height;

            Console.WriteLine("area: " + area);
        }

        public void CircumferenceCalc(ref int width, ref int height)
        {
            Console.WriteLine("insert width:");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("insert height:");
            height = int.Parse(Console.ReadLine());


            int circumference = (width * 2) + (height * 2);

            Console.WriteLine("circumference: " + circumference);
        }

    }
}