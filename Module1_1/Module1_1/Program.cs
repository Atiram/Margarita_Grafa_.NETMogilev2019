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
            Swap(Input(),Input());
            Console.ReadKey();
        }
        public static int Input()
        {
            int point;
            Console.WriteLine("Input point");
            while (!(int.TryParse(Console.ReadLine(), out point)))
            {
                Console.WriteLine("Incorrect data.Try again.");
            }
            return point;
        }
        public static void Swap(int firstPoint, int secondPoint)
        {
            firstPoint += secondPoint;
            secondPoint = firstPoint - secondPoint;
            firstPoint -= secondPoint;
            Console.WriteLine("firstPoint=" + firstPoint);
            Console.WriteLine("secondPoint=" + secondPoint);
        }
    }
}