using System;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            uint quantityOfNumbers = InputNumber();

            // Verification if quantity of numbers is 0.
            if (quantityOfNumbers != 0)
            {
                // Calculation.
                int[] arrayOfEvenNumbers = new int[quantityOfNumbers];
                for (int i = 0; i < arrayOfEvenNumbers.Length; i++)
                {
                    arrayOfEvenNumbers[i] = i * 2;
                }

                // Ouput data.
                Console.WriteLine("The number is {0} and the array of even numbers is: ", quantityOfNumbers);
                for (int i = 0; i < arrayOfEvenNumbers.Length; i++)
                {
                    Console.Write(arrayOfEvenNumbers[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("The number is {0} and there no elements in the array of even numbers", quantityOfNumbers);
            }
            Console.ReadKey();
        }

        // Verification of the unsigned integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input of the unsigned integer number.
        public static uint InputNumber()
        {
            uint newNumber;
            Console.WriteLine("Input number");
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using unsigned interger number.");
            }
            return newNumber;
        }
    }
}