using System;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input length and creation an array of this length.
            Console.WriteLine("Input length of the array");
            double[] arrayForChangeSign = new double[InputLength()];

            // Input the array and verification if the length of the array is 0.
            if (arrayForChangeSign.Length != 0)
            {
                Console.WriteLine($"Input {arrayForChangeSign.Length} elements of the array");
                for (int i = 0; i < arrayForChangeSign.Length; i++)
                {
                    arrayForChangeSign[i] = InputDoubleNumber();
                }

                // Calculation
                for (int i = 0; i < arrayForChangeSign.Length; i++)
                {
                    arrayForChangeSign[i] *= -1;
                }

                // Output data.
                Console.WriteLine($"Array length: {arrayForChangeSign.Length}. Array:");
                for (int i = 0; i < arrayForChangeSign.Length; i++)
                {
                    Console.Write(arrayForChangeSign[i] + " ");
                }
            }
            else
            {
                Console.WriteLine($"Array length: {arrayForChangeSign.Length}. There no elements in the array.");
            }
            Console.ReadKey();
        }

        // Verification of the unsigned integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input the length of the array.
        public static uint InputLength()
        {
            uint newNumber;
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using unsigned interger number.");
            }
            return newNumber;
        }

        // Verification of the double number with "," or ".".
        public static bool IsValidData(out double inputNumber)
        {
            return (double.TryParse(Console.ReadLine().Replace(".", ","), out inputNumber));
        }

        // Input elements of the array.
        public static double InputDoubleNumber()
        {
            double newNumber;
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using double number.");
            }
            return newNumber;
        }
    }
}