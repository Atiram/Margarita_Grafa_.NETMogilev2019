using System;

namespace Module4_5
{
    class Program
    {
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        static void Main(string[] args)
        {
            // Input 2 numbers, number of operation and output of the result.
            Console.WriteLine("Input two numbers");
            double firstNumber;
            InputData(out firstNumber);
            double secondNumber;
            InputData(out secondNumber);
            Operation requiredOperation = Operation.Add;
            Console.WriteLine("Input the operation. 1 - Add, 2 - Subtract, 3 - Multiply, 4 - Divide");
            int numberOfOperation;
            InputData(out numberOfOperation);
            switch (numberOfOperation)
            {
                case 1:
                    requiredOperation = Operation.Add;
                    break;
                case 2:
                    requiredOperation = Operation.Subtract;
                    break;
                case 3:
                    requiredOperation = Operation.Multiply;
                    break;
                case 4:
                    requiredOperation = Operation.Divide;
                    break;
                default:
                    Console.WriteLine("Input numbers is incorrect. Add will be required operation.");
                    break;
            }
            DoMathOperation(firstNumber, secondNumber, requiredOperation);

            // Input required month and year.
            Console.WriteLine("Input required year");
            int requiredYear;
            InputData(out requiredYear);
            Console.WriteLine("Input required month");
            int requiredMonth;
            InputData(out requiredMonth);

            // Output required quantity of the days.
            Console.WriteLine("Quantity of the days:");
            OutputNumberOfDays(requiredYear, requiredMonth);
        }

        // Verification of the double number with "," or ".".
        public static bool IsValidData(out double inputNumber)
        {
            return (double.TryParse(Console.ReadLine().Replace(".", ","), out inputNumber));
        }

        // Verification of the integer number.
        public static bool IsValidData(out int inputNumber)
        {
            return (int.TryParse(Console.ReadLine(), out inputNumber));
        }

        // Input double number.
        public static void InputData(out double newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using double number.");
            }
        }

        // Input the integer number.
        public static void InputData(out int newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again using interger number.");
            }
        }

        // Implementation of choosen operation and output the result.
        static void DoMathOperation(double firstNumber, double secondNumber, Operation requiredOperation)
        {
            double result = 0;
            switch (requiredOperation)
            {
                case Operation.Add:
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Result is {result}");
                    break;
                case Operation.Subtract:
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Result is {result}");
                    break;
                case Operation.Multiply:
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Result is {result}");
                    break;
                case Operation.Divide:
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error. You can't divide by 0");
                            break;
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine($"Result is {result}");
                            break;
                        }
                    }
            }
        }

        // Outrut the quantity of the days.
        static void OutputNumberOfDays(int requiredYear, int requiredMonth)
        {
            if ((requiredMonth > 0) && (requiredMonth <= 12) && (requiredYear > 0))
            {
                int daysInMonth = DateTime.DaysInMonth(requiredYear, requiredMonth);
                Console.WriteLine(daysInMonth);
            }
        }
    }
}