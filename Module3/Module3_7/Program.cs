using System;
using System.Text;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input length and creation an array of this length.
            Console.WriteLine("Input length of the array");
            double[] arrayForChoosingElemetns = new double[InputLength()];
            StringBuilder arrayElements = new StringBuilder();
            if (arrayForChoosingElemetns.Length != 0)
            {
                // Input the array.
                Console.WriteLine($"Input {arrayForChoosingElemetns.Length} elements of the array");
                for (int i = 0; i < arrayForChoosingElemetns.Length; i++)
                {
                    arrayForChoosingElemetns[i] = InputNumber();
                }

                // Output the required elements.
                Console.WriteLine("Required elemetns: ");
                for (int i = 1; i < arrayForChoosingElemetns.Length; i++)
                {
                    if (arrayForChoosingElemetns[i - 1] < arrayForChoosingElemetns[i])
                    {
                        arrayElements.Insert(arrayElements.Length, $"{arrayForChoosingElemetns[i]} ");
                    }
                }
                Console.WriteLine(arrayElements);
            }
            else
            {
                Console.WriteLine("The lenght is 0. There are 0 elements in the array.");
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
        public static double InputNumber()
        {
            double newNumber;
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
            return newNumber;
        }
    }
}