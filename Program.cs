using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape obj;

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");

            string Choice = Console.ReadLine();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                    Console.WriteLine("insert width:");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height:");
                    double height = double.Parse(Console.ReadLine());

                    //var instance = new Rectangle(width, height);

                    //Shape shape = new Shape(width, height);

                    //Rectangle S = new Rectangle(width, height);

                    //S.AreaCalc();
                    //S.CircumferenceCalc();

                    obj = new Rectangle(width, height);

                    obj.AreaCalc();
                    obj.CircumferenceCalc();


                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "2":
                    Console.WriteLine("insert width:");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height:");
                    height = double.Parse(Console.ReadLine());

                    //var instance0 = new Triangle(width, height);

                    //Triangle S0 = new Triangle(width, height);

                    //Console.WriteLine("area: " + S0.AreaCalc());
                    //Console.WriteLine("curcumference: " + S0.CircumferenceCalc());

                    obj = new Triangle(width, height);

                    obj.AreaCalc();
                    obj.CircumferenceCalc();

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                default:
                    Console.WriteLine("try again");
                    Main(null);
                    break;

            }

        }
    }
}