using System;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            Console.WriteLine("Input the number of companies");
            uint numberOfCompanies = Input();
            Console.WriteLine("Input tax using persents");
            double tax = InputPercent();
            Console.WriteLine("Input the profit of companies");
            uint profitOfCompanies = Input();

            // Calculation.
            double summaryTax = profitOfCompanies * numberOfCompanies * tax / 100;

            // Output data.
            Console.WriteLine("Summary tax: " + summaryTax);
            Console.ReadKey();
        }
        public static uint Input()
        {
            uint inputValue;
            while (!(uint.TryParse(Console.ReadLine(), out inputValue)))
                Console.WriteLine("Incorrect data. Try again.");
            return inputValue;
        }

        public static double InputPercent()
        {
            double inputValue;
            while (!(double.TryParse(Console.ReadLine().Replace(".", ","), out inputValue)) || (inputValue < 0 || inputValue > 100))
                Console.WriteLine("Incorrect data. Try again.");
            return inputValue;
        }
    }
}