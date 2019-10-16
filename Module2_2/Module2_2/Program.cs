using System;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            uint number = 0;
            Console.WriteLine("Input the number");
            while (!(uint.TryParse(Console.ReadLine(), out number)))
                Console.WriteLine("Incorrect data.Try again.");

            // Output data.
            if ((number % 2 == 0) && (number >= 18))
                Console.WriteLine("Happy eighteenth birthday!");
            if ((number % 2 != 0) && (number < 18) && (number > 13))
                Console.WriteLine("Congratulations on your transfer to high school!");
            Console.ReadKey();
        }
    }
}
