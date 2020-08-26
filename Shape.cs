using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARv2
{
    class Shape
    {
        protected int width;
        protected int height;

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
    }
}
