using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : Shape
    {

        public Rectangle(int w, int h, int a, int c) : base(w, h, a, c)
        {

        }

        public void AreaCalc(ref int width, ref int height, ref int area)
        {
            Console.WriteLine("insert width:");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("insert height:");
            height = int.Parse(Console.ReadLine());


            area = width * height;

            Console.WriteLine("area: " + area);
        }

        public void CircumferenceCalc(ref int width, ref int height, ref int circumference)
        {
            Console.WriteLine("insert width:");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("insert height:");
            height = int.Parse(Console.ReadLine());


            circumference = (width * 2) + (height * 2);

            Console.WriteLine("circumference: " + circumference);
        }

    }
}