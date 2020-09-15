using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Shape
    {
        protected double width;
        protected double height;

        public Shape(double w, double h)
        {
            width = w;
            height = h;
        }

        public double Width
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

        public double Height
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

        public virtual void AreaCalc()
        {
            
        }

        public virtual void CircumferenceCalc()
        {

        }
    }
}