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
            var instance = new Rectangle();
            

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");

            string Choice = Console.ReadLine();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                    

                    break;

                default:
                    Console.WriteLine("try again");
                    Main(null);
                    break;

            }

        }
    }
}