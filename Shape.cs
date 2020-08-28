using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Shape
    {
        private int width;
        private int height;
        private int area;
        private int circumference;

        public Shape(int w, int h, int a, int c)
        {
            width = w;
            height = h;
            area = a;
            circumference = c;
        }

        public Shape(int w, int h)
        {
            width = w;
            height = h;
        }

        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    height = 0;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Area
        {
            get { return area; }
            set
            {
                if (value < 0)
                {
                    area = 0;
                }
                else
                {
                    area = value;
                }
            }
        }

        public int Circumference
        {
            get { return circumference; }
            set
            {
                if (value < 0)
                {
                    circumference = 0;
                }
                else
                {
                    circumference = value;
                }
            }
        }
    }
}