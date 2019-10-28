using System;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 2 constant variable for calculation Fibonacci numbers.
            const int FIRST_FIBONACHI_NUMBER = 0;
            const int SECOND_FIBONACHI_NUMBER = 1;

            // Input data.
            uint quantityOfNumbers = InputNumber();

            // Calculation and Ouput data.
            int[] arrayOfFibonacciNumbers = new int[quantityOfNumbers];
            if (quantityOfNumbers == 0)
            {
                Console.WriteLine("No elements in the array of Fibonacci numbers");
            }
            else if (quantityOfNumbers == 1)
            {
                arrayOfFibonacciNumbers[0] = FIRST_FIBONACHI_NUMBER;
                DisplayArray(arrayOfFibonacciNumbers);
            }
            else
            {
                arrayOfFibonacciNumbers[0] = FIRST_FIBONACHI_NUMBER;
                arrayOfFibonacciNumbers[1] = SECOND_FIBONACHI_NUMBER;
                for (int i = 2; i < arrayOfFibonacciNumbers.Length; i++)
                {
                    arrayOfFibonacciNumbers[i] = arrayOfFibonacciNumbers[i - 1] + arrayOfFibonacciNumbers[i - 2];
                }
                DisplayArray(arrayOfFibonacciNumbers);
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