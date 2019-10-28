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
            int removeNumber = InputRemoveNumber();
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
            Console.WriteLine($"New number after removing {removeNumber} : {newNumber}");
            Console.ReadKey();
        }

        // Verification of the natural number.
        public static bool IsValidData(out int inputNumber)
        {
            return ((int.TryParse(Console.ReadLine(), out inputNumber)) && (inputNumber > 0));
        }

        // Input of the natural number.
        public static int InputNumber()
        {
            int newNumber;
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
            return newNumber;
        }

        // Verification of the removing number.
        public static bool IsValidRemoveNumber(out int inputNumber)
        {
            return ((int.TryParse(Console.ReadLine(), out inputNumber)) && (inputNumber >= 0) && (inputNumber<10));
        }

        // Input of the removing number.
        public static int InputRemoveNumber()
        {
            int newNumber;
            while (!IsValidRemoveNumber(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
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