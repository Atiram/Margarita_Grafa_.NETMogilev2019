using System;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            Console.WriteLine("Input number");
            int number = InputNumber();
            int newNumber = 0;
            Console.WriteLine("Input removing number");
            int removeNumber;
            while ((removeNumber = InputNumber()) >= 10)
            {
                Console.WriteLine("Incorrect data.Try again.");
            }
            int[] arrayFromNumber = new int[GetLength(number)];

            // Creating an array from number.
            for (int i = 0; i < arrayFromNumber.Length; i++)
            {
                arrayFromNumber[i] = number % 10;
                number /= 10;
            }

            // Creating a new array without removingNumber.
            for (int i = arrayFromNumber.Length - 1; i >= 0; i--)
            {
                if (arrayFromNumber[i] != removeNumber)
                {
                    newNumber = newNumber * 10 + arrayFromNumber[i];
                }
            }

            // Output data.
            Console.WriteLine("New number after removing {0} : {1}", removeNumber, newNumber);
            Console.ReadKey();
        }

        // Verification of the integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input of the unsigned integer number.
        public static int InputNumber()
        {
            int newNumber;
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