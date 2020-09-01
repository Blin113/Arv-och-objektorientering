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

                    var instance = new Rectangle(width, height);

                    Console.WriteLine("area: " + instance.AreaCalc());
                    Console.WriteLine("curcumference: " + instance.CircumferenceCalc());

                    Console.ReadKey();
                    Main(null);

                    break;

                case "2":
                    Console.WriteLine("insert width:");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height:");
                    height = double.Parse(Console.ReadLine());

                    var instance0 = new Triangle(width, height);

                    Console.WriteLine("area: " + instance0.AreaCalc());
                    Console.WriteLine("curcumference: " + instance0.CircumferenceCalc());

                    Console.ReadKey();
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