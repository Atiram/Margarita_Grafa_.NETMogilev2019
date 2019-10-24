using System;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 2 constant variable for calculation Fibonacci numbers.
            const int firstFibonachiNumber = 0;
            const int secondFibonachiNumber = 1;

            // Input data.
            uint quantityOfNumbers = InputNumber();

            // Calculation and Ouput data.
            int[] ArrayOfFibonacciNumbers = new int[quantityOfNumbers];
            if (quantityOfNumbers == 0)
            {
                Console.WriteLine("No elements in the array of Fibonacci numbers");
            }
            else if (quantityOfNumbers == 1)
            {
                ArrayOfFibonacciNumbers[0] = firstFibonachiNumber;
                DisplayArray(ArrayOfFibonacciNumbers);
            }
            else
            {
                ArrayOfFibonacciNumbers[0] = firstFibonachiNumber;
                ArrayOfFibonacciNumbers[1] = secondFibonachiNumber;
                for (int i = 2; i < ArrayOfFibonacciNumbers.Length; i++)
                {
                    ArrayOfFibonacciNumbers[i] = ArrayOfFibonacciNumbers[i - 1] + ArrayOfFibonacciNumbers[i - 2];
                }
                DisplayArray(ArrayOfFibonacciNumbers);
            }
            Console.ReadKey();
        }

        // Verification of the integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input of the integer number.
        public static uint InputNumber()
        {
            uint newNumber;
            Console.WriteLine("Input number");
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using interger number.");
            }
            return newNumber;
        }

        // Output of the array.
        public static void DisplayArray(int[] myArray)
        {
            Console.WriteLine("Array of Fibonacci numbers: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + " ");
        }
    }
}