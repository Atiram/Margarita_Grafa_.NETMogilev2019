using System;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            int number = InputNumber();
            int[] reverseArray = new int[GetLength(number)];
            long palindrome = 0;

            // Creating an array from inputed number.
            for (int i = 0; i < reverseArray.Length; i++)
            {
                reverseArray[i] = number % 10;
                number /= 10;
            }

            // Calculation of the palindrome using the array.
            for (int i = 0; i < reverseArray.Length; i++)
            {
                palindrome = palindrome * 10 + reverseArray[i];
            }

            // Output palindrome.
            Console.WriteLine($"Palindrome: {palindrome}");
            Console.ReadKey();
        }

        // Verification of the  integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input of the unsigned integer number.
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

        // Calculation a number of digits in inputed number for creating an array.
        public static int GetLength(int number)
        {
            int numberOfDigits = (number == 0) ? 1 : 0;
            while (number != 0)
            {
                numberOfDigits++;
                number /= 10;
            }
            return numberOfDigits;
        }
    }
}