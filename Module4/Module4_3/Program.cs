using System;

namespace Module4_3
{
    class Program
    {
        const int INCREASE_NUMBER = 10;
        static void Main(string[] args)
        {
            // Input and increasing and output of 3 numbers.
            Console.WriteLine("Input 3 numbers");
            int firstPoint;
            int secondPoint;
            int thirdPoint;
            InputData(out firstPoint);
            InputData(out secondPoint);
            InputData(out thirdPoint);
            IncreaseOfTen(ref firstPoint, ref secondPoint, ref thirdPoint);
            Console.WriteLine("The numbers after increasing of 10: ");
            Console.WriteLine($"{firstPoint} {secondPoint} {thirdPoint}");

            // Input radius, calculation and output of the circumference and the area of circle.
            double circumferenceCircle;
            double areaCircle;
            int radiusCircle;
            do
            {
                Console.WriteLine("\nInput radius of the circle");
                InputData(out radiusCircle);
            } while (radiusCircle < 0);
            CalculateCirceParametrs(radiusCircle, out circumferenceCircle, out areaCircle);
            Console.WriteLine($"Circumference of the circle is {circumferenceCircle}");
            Console.WriteLine($"Area of the circle is {areaCircle}");

            // Input the length and the array of this length.
            Console.WriteLine("\nInput the length of the array");
            uint arrayLength;
            InputData(out arrayLength);
            Console.WriteLine($"Input {arrayLength} elements of the array");
            int[] workingArray = new int[arrayLength];
            for (int i = 0; i < workingArray.Length; i++)
            {
                InputData(out workingArray[i]);
            }

            // Search of the minElement and maxElement, calculate sum of the elements.
            int mininumElement;
            int maxiumElement;
            int sumElements;
            if (arrayLength > 0)
            {
                CalculateArrayValues(workingArray, out mininumElement, out maxiumElement, out sumElements);
                Console.WriteLine($"Minimum is {mininumElement}");
                Console.WriteLine($"Maximum is {maxiumElement}");
                Console.WriteLine($"Sum of the elements is {sumElements}");
            }
            else
            {
                Console.WriteLine("Array has no elements");
            }
            Console.ReadKey();
        }

        // Verification of the unsigned integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Verification of the unsigned integer number.
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

        // Increasing the number of 10.
        public static void IncreaseOfTen(ref int firstNumber, ref int secondNumber, ref int thrirdNumber)
        {
            firstNumber += INCREASE_NUMBER;
            secondNumber += INCREASE_NUMBER;
            thrirdNumber += INCREASE_NUMBER;
        }

        //Calculation of circumference and area of the circle.
        public static void CalculateCirceParametrs(int radius, out double circumference, out double area)
        {
            circumference = 2 * radius * Math.PI;
            area = radius * radius * Math.PI;
        }

        // Calculation of min element, max element and sum of the elemetns.
        public static void CalculateArrayValues(int[] array, out int min, out int max, out int sum)
        {
            min = array[0];
            max = array[0];
            sum = 0;
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
        }
    }
}