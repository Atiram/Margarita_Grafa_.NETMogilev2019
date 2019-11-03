using System;

namespace Module3_8
{
    class Program
    {
        private const double EPSILON = .001;
        private static void Main()
        {

            // Input data.
            Console.Write("Begin point x = ");
            double beginPoint = InputDoubleNumber();
            double endPoint;
            do
            {
                Console.Write("End point x = ");
            }
            while (beginPoint > (endPoint = InputDoubleNumber()));

            if (beginPoint < endPoint && Math.Sign(CalculateFunction(beginPoint)) != Math.Sign(CalculateFunction(endPoint)))
            {

                // Calculation.
                if (!(CheckExtreme(beginPoint) || CheckExtreme(endPoint)))
                {
                    double axesX = endPoint - beginPoint;
                    double averegePoint;
                    do
                    {
                        axesX /= 2;
                        averegePoint = beginPoint + axesX;
                        Console.WriteLine(averegePoint);
                        if (Math.Sign(CalculateFunction(beginPoint)) == Math.Sign(CalculateFunction(averegePoint)))
                        {
                            beginPoint = averegePoint;
                        }
                    }
                    while (Math.Abs(CalculateFunction(averegePoint)) > EPSILON);

                    // Output of solution.
                    Console.WriteLine(averegePoint);
                }
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }


            // Input the size of array and output the spiral array.
            Console.WriteLine("Input the size of the square array");
            int sizeOfArray = InputIntNumber();
            Console.WriteLine("The spiral array:");
            DisplayArray(CreateSpiralArray(sizeOfArray));
        }

        private static bool CheckExtreme(double value)
        {
            if (Math.Abs(CalculateFunction(value)) < EPSILON)
            {
                Console.WriteLine(value);
                return true;
            }
            return false;
        }

        private static double CalculateFunction(double x)
        {
            return 4 * x + 16;
        }

        //Verification of the integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return ((int.TryParse(Console.ReadLine(), out inputNumber)) && inputNumber > 0);
        }

        //Verification of the double number.
        public static bool IsValidData(out double inputNumber)
        {
            return ((double.TryParse(Console.ReadLine().Replace('.', ','), out inputNumber)));
        }

        // Input of the double number.
        public static double InputDoubleNumber()
        {
            double newNumber;
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using unsigned interger number.");
            }
            return newNumber;
        }

        // Input of the integer number.
        public static int InputIntNumber()
        {
            int newNumber;
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using unsigned interger number.");
            }
            return newNumber;
        }

        public static int[,] CreateSpiralArray(int sizeOfArray)
        {
            int[,] spiralArray = new int[sizeOfArray, sizeOfArray];
            int startPoint = 0;
            int count = sizeOfArray;
            int value = -sizeOfArray;
            int sum = -1;

            do
            {
                value = -1 * value / sizeOfArray;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    spiralArray[sum / sizeOfArray, sum % sizeOfArray] = startPoint++;
                }
                value *= sizeOfArray;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    spiralArray[sum / sizeOfArray, sum % sizeOfArray] = startPoint++;
                }
            } while (count > 0);

            return spiralArray;
        }

        // Output array with beautiful indent to line up in columns
        public static void DisplayArray(int[,] array)
        {
            int quantityOfIndent = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(quantityOfIndent, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}