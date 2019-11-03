using System;

namespace Module4_6
{
    class Program
    {
        const int INCREASE_NUMBER = 5;
        static void Main(string[] args)
        {
            // Input the length and the array of this length.
            Console.WriteLine("Input the length of the array");
            uint arrayLength;
            InputData(out arrayLength);
            if (arrayLength > 0)
            {
                Console.WriteLine($"Input {arrayLength} elements of the array");
                double[] workingArray = new double[arrayLength];
                for (int i = 0; i < workingArray.Length; i++)
                {
                    InputData(out workingArray[i]);
                }

                // Using method and output the array.
                IncreaseArray(workingArray);
                Console.WriteLine(String.Join(" ", workingArray));
            }
            else
            {
                Console.WriteLine("Length is 0. There 0 elements in the array.");
            }
        }

        // Verification of the unsigned integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Verification of the double number with "," or ".".
        public static bool IsValidData(out double inputNumber)
        {
            return (double.TryParse(Console.ReadLine().Replace(".", ","), out inputNumber));
        }

        // Input unsigned integer number.
        public static void InputData(out uint newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using unsigned interger number.");
            }
        }

        // Input double number.
        public static void InputData(out double newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using double number.");
            }
        }

        // Increasing the number of increaseNumber.
        public static double[] IncreaseArray(double[] myArray)
        {
            for (var i = 0; i < myArray.Length; i++)
            {
                myArray[i] += INCREASE_NUMBER;
            }
            return myArray;
        }
    }
}