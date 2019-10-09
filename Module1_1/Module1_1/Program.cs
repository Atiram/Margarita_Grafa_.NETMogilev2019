using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input data
            bool check = true;
            int firstPoint = 0;
            int secondPoint = 0;
            while (check)
            {
                Console.WriteLine("Input integer firstPoint");
                if (int.TryParse(Console.ReadLine(), out firstPoint))
                    check = false;
                else
                    Console.WriteLine("Incorrect data.Try again.");
            }

            check = true;
            while (check)
            {
                Console.WriteLine("Input integer secondPoint");
                if (int.TryParse(Console.ReadLine(), out secondPoint))
                    check = false;
                else
                    Console.WriteLine("Incorrect data.Try again.");
            }

            //Swap
            firstPoint += secondPoint;
            secondPoint = firstPoint - secondPoint;
            firstPoint -= secondPoint;

            //Output data
            Console.WriteLine("firstPoint=" + firstPoint);
            Console.WriteLine("secondPoint=" + secondPoint);
            Console.ReadKey();
        }
    }
}
