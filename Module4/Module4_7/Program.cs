using System;

namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input the length and the array of this length.
            Console.WriteLine("Input the length of the array");
            uint arrayLength;
            InputData(out arrayLength);
            Console.WriteLine($"Input {arrayLength} elements of the array");
            int[] workingArray = new int[arrayLength];
            for (int i = 0; i < workingArray.Length; i++)
            {
                InputData(out workingArray[i]);
            }

            // Input of the direction of sorting.
            int sortDirection;
            do
            {
                Console.WriteLine("Input sort direction. 1 - sort from min to max, 2 - sort from max to min");
                InputData(out sortDirection);
            } while ((sortDirection != 1) && (sortDirection != 2));
            if (sortDirection == 1)
            {
                SortArrayMinToMax(workingArray);
            }
            else
            {
                SortArrayMaxToMin(workingArray);
            }


            // Output of the array.
            Console.WriteLine(String.Join(" ", workingArray));
        }

        // Verification of the unsigned integer number.
        public static bool IsValidData(out uint inputNumber)
        {
            return (uint.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Verification of the int number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input of the unsigned integer number.
        public static void InputData(out uint newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
        }

        // Input of the integer number.
        public static void InputData(out int newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
        }

        // Sort from min to max.
        public static int[] SortArrayMinToMax(int[] myArray)
        {
            int tempContainer;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        tempContainer = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = tempContainer;
                    }
                }
            }
            return myArray;
        }

        // Sort fron max to min.
        public static int[] SortArrayMaxToMin(int[] myArray)
        {
            int tempContainer;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        tempContainer = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = tempContainer;
                    }
                }
            }
            return myArray;
        }
    }
}