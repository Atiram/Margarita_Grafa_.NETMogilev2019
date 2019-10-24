using System;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            int firstNumber = InputNumber();
            int secondNumber = InputNumber();
            int multiplication = 0;

            // Calculatoin multiplication.
            for (int i = 0; i < Math.Abs(firstNumber); i++)
            {
                multiplication += secondNumber;
            }
            if (firstNumber < 0)
            {
                multiplication = ~multiplication;
                multiplication++;
            }

            // Output data.
            Console.WriteLine("Multiplication is " + multiplication);
            Console.ReadKey();
        }

        // Verification of the integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input of the integer number.
        public static int InputNumber()
        {
            int newNumber;
            Console.WriteLine("Input number");
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using interger number.");
            }
            return newNumber;
        }
    }
}