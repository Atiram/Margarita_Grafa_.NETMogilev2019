using System;

namespace Module4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input data.
            Console.WriteLine("Input the length of the array");
            InputData(out uint arrayLength);
            if (arrayLength > 0)
            {
                Console.WriteLine($"Input {arrayLength} elements of the array");
                double[] workingArray = new double[arrayLength];
                for (int i = 0; i < workingArray.Length; i++)
                {
                    InputData(out workingArray[i]);
                }

                // Using methods.
                Console.WriteLine($"Maximum of the array {SearchMax(workingArray)}");
                Console.WriteLine($"Minimum of the array {SearchMin(workingArray)}");
                Console.WriteLine($"Sum of the array's elements {CalculateSum(workingArray)}");
                Console.WriteLine($"Difference between maximun and minimum {CalculateDifferenceMaxMin(workingArray)}");
                Console.WriteLine("Array after modification ");
                ModificateArray(workingArray);
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

        // Input unsigned int number.
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
                Console.WriteLine("Incorrect data. Try again.");
            }
        }

        // Finding maximum element in the array. 
        public static double SearchMax(double[] workArray)
        {
            double max = workArray[0];
            for (int i = 1; i < workArray.Length; i++)
            {
                if (max < workArray[i])
                {
                    max = workArray[i];
                }
            }
            return max;
        }

        // Finding minimum element in the array.
        public static double SearchMin(double[] workArray)
        {
            double min = workArray[0];
            for (int i = 1; i < workArray.Length; i++)
            {
                if (min > workArray[i])
                {
                    min = workArray[i];
                }
            }
            return min;
        }

        // Calculation sum of the array's elements.
        public static double CalculateSum(double[] workArray)
        {
            double sum = workArray[0];
            for (int i = 1; i < workArray.Length; i++)
            {
                sum += workArray[i];
            }
            return sum;
        }

        // Calculation difference between maximum and minimum element.
        public static double CalculateDifferenceMaxMin(double[] workArray)
        {
            return SearchMax(workArray) - SearchMin(workArray);
        }

        // Add maximum element and subtract minimum element.
        public static double[] ModificateArray(double[] workArray)
        {
            double max = SearchMax(workArray);
            double min = SearchMin(workArray);
            for (int i = 0; i < workArray.Length; i++)
            {
                if (workArray[i] % 2 == 0)
                {
                    workArray[i] += max;
                }
                else
                {
                    workArray[i] -= min;
                }
            }
            return workArray;
        }
    }
}