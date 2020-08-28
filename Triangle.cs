using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Triangle : Shape
    {
        public Triangle(int w, int h, int a, int c) : base(w, h, a, c)
        {

        }

        public void AreaCalc(ref int width, ref int height, ref int area)
        {
            area = (width * height) / 2;
        }

        public void CircumferenceCalc(ref int width, ref int circumference)
        {
            circumference = width * 3;
        }
    }
}