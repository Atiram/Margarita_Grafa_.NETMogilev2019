using System;

namespace Module4_4
{
    class Program
    {
        const int INCREASE_NUMBER = 10;
        static void Main(string[] args)
        {
            // Input and increasing 3 numbers.
            Console.WriteLine("Input 3 numbers");
            (int, int, int) tupleOfNumbers;
            InputData(out tupleOfNumbers);
            IncreaseOfTen(ref tupleOfNumbers);
            Console.WriteLine($"Numbers after increasing of 10: {tupleOfNumbers.Item1}, {tupleOfNumbers.Item2}, {tupleOfNumbers.Item3}");

            // Input radius, calculation and output of the circumference and the area of circle.
            Console.WriteLine("Input radius");
            int radius;
            InputData(out radius);
            (double, double) tupleCirlceParametrs;
            CalculateCirceParametrs(radius, out tupleCirlceParametrs);
            Console.WriteLine($"Circumference of the circle is {tupleCirlceParametrs.Item1}");
            Console.WriteLine($"Area of the circle is {tupleCirlceParametrs.Item2}");

            // Intut the length and the array of this length.
            Console.WriteLine("Input the length of the array");
            uint arrayLength;
            InputData(out arrayLength);
            Console.WriteLine($"Input {arrayLength} elements of the array");
            int[] workingArray = new int[arrayLength];
            for (int i = 0; i < workingArray.Length; i++)
            {
                InputData(out workingArray[i]);
            }

            // Search of the minElement and maxElement, calculate sum of the elements.
            (int, int, int) tupleArrayValues;
            CalculateArrayValues(workingArray, out tupleArrayValues);
            Console.WriteLine($"Minimum is {tupleArrayValues.Item1}");
            Console.WriteLine($"Maximum is {tupleArrayValues.Item2}");
            Console.WriteLine($"Sum of the elements is {tupleArrayValues.Item3}");
        }

        // Verification of the unsigned integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Verification of the integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input the unsigned integer.
        public static void InputData(out uint newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using unsigned interger number.");
            }
        }

        // Input integer number.
        public static void InputData(out int newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
        }

        // Input tuple number.
        public static void InputData(out (int, int, int) newNumber)
        {
            while (!IsValidData(out newNumber.Item1))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
            while (!IsValidData(out newNumber.Item2))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
            while (!IsValidData(out newNumber.Item3))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
        }

        // Increasing the number of 10.
        public static void IncreaseOfTen(ref (int, int, int) workingTuple)
        {
            workingTuple.Item1 += INCREASE_NUMBER;
            workingTuple.Item2 += INCREASE_NUMBER;
            workingTuple.Item3 += INCREASE_NUMBER;
        }

        //Calculation of circumference and area of the circle.
        public static void CalculateCirceParametrs(int radius, out (double, double) workingTuple)
        {
            workingTuple.Item1 = 2 * radius * Math.PI;
            workingTuple.Item2 = radius * radius * Math.PI;
        }

        // Calculation of min element, max element and sum of the elemetns.
        public static void CalculateArrayValues(int[] array, out (int, int, int) workingTuple)
        {
            int min = array[0];
            int max = array[0];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
                sum += array[i];
            }
            workingTuple.Item1 = min;
            workingTuple.Item2 = max;
            workingTuple.Item3 = sum;
        }
    }
}