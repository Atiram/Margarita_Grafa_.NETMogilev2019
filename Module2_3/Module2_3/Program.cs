using System;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            double firstPoint = 0;
            double secondPoint = 0;
            double container;
            Console.WriteLine("Input firstPoint");
            firstPoint = Input();
            Console.WriteLine("Input secondPoint");
            secondPoint = Input();

            // Swap.
            container = firstPoint;
            firstPoint = secondPoint;
            secondPoint = container;

            // Output data.
            Console.WriteLine("firstPoint=" + firstPoint);
            Console.WriteLine("secondPoint=" + secondPoint);
            Console.ReadKey();
        }
        public static double Input()
        {
            double inputPoint;
            while (!(double.TryParse(Console.ReadLine().Replace(".", ","), out inputPoint)))
                Console.WriteLine("Incorrect data. Try again.");
            return inputPoint;
        }
    }
}