using System;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of required operation. \n1 - add three int numbers \n2 - add two int numbers \n3 - add three double numbers \n4 - concatination two strings \n5 - add elements of two arrays");
            uint numberOperation;
            InputData(out numberOperation);
            switch (numberOperation)
            {
                case 1:
                    {
                        Console.WriteLine("Input three integer numbers");
                        InputData(out int firstPoint);
                        InputData(out int secondPoint);
                        InputData(out int thirdPoint);
                        Console.WriteLine($"Result = {AddValues(firstPoint, secondPoint, thirdPoint)}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Input two integer numbers");
                        InputData(out int firstPoint);
                        InputData(out int secondPoint);
                        Console.WriteLine($"Result = {AddValues(firstPoint, secondPoint)}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Input three double numbers");
                        InputData(out double firstPoint);
                        InputData(out double secondPoint);
                        InputData(out double thirdPoint);
                        Console.WriteLine($"Result = {AddValues(firstPoint, secondPoint, thirdPoint)}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Input two strings");
                        string firstString = Console.ReadLine();
                        string secondString = Console.ReadLine();
                        Console.WriteLine($"Result = {AddValues(firstString, secondString)}");
                        break;
                    }
                case 5:
                    {
                        InputData(out int[] firstArray);
                        InputData(out int[] secondArray);
                        Console.WriteLine("Addition of two arrays: ");
                        DisplayArray(AddValues(firstArray, secondArray));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect number of operation.");
                        break;
                    }
            }
        }

        // Verification of the integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
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

        // Input the integer number.
        public static void InputData(out int newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using interger number.");
            }
        }

        // Input the unsigned integer number.
        public static void InputData(out uint newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using interger number.");
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

        // Creation of integer array.
        public static void InputData(out int[] workingArray)
        {
            Console.WriteLine("Input the length of the array");
            uint arrayLength;
            InputData(out arrayLength);
            Console.WriteLine($"Input {arrayLength} elements of the array");
            workingArray = new int[arrayLength];
            for (int i = 0; i < workingArray.Length; i++)
            {
                InputData(out workingArray[i]);
            }
        }

        // Add two or three integer numbers.
        public static int AddValues(int firstNumber, int secondNumber, int thirdNumber = 0)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        // Add three double numbers.
        public static double AddValues(double firstNumber, double secondNumber, double thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        // Concatenation of two stringgs.
        public static string AddValues(string firstString, string secondString)
        {
            return String.Concat(firstString, secondString);
        }

        // Add of the elements of two arrays.
        public static int[] AddValues(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length >= secondArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    firstArray[i] += secondArray[i];
                }
                return firstArray;
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    secondArray[i] += firstArray[i];
                }
                return secondArray;
            }
        }

        // Output of the array.
        public static void DisplayArray(int[] workingArray)
        {
            Console.WriteLine(String.Join(" ", workingArray));
        }
    }
}