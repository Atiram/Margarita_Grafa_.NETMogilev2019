using System;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            uint quantityOfNumbers = InputQuantity();

            // Calculation.
            int[] arrayOfEvenNumbers = new int[quantityOfNumbers];
            for (int i = 0; i < arrayOfEvenNumbers.Length; i++)
            {
                arrayOfEvenNumbers[i] = i * 2;
            }

            // Ouput data.
            Console.WriteLine($"The number is {quantityOfNumbers} and the array of even numbers is: ");
            for (int i = 0; i < arrayOfEvenNumbers.Length; i++)
            {
                Console.Write(arrayOfEvenNumbers[i] + " ");
            }
            Console.ReadKey();
        }

        // Verification of the quantity of numbers.
        public static bool IsValidQuantity(out uint inputNumber)
        {
            return ((uint.TryParse(Console.ReadLine(), out inputNumber)) && (inputNumber > 0));
        }
                
        // Input of the quantity.
        public static uint InputQuantity()
        {
            uint newNumber;
            Console.WriteLine("Input quantity of even numbers");
            while (!IsValidQuantity(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
            return newNumber;
        }
    }
}