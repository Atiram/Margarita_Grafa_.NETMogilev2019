using System;

namespace Module4_8
{
    class Program
    {
        private const double EPSILON = .001;
        static void Main(string[] args)
        {
            // Input data.
            Console.Write("Begin point x = ");
            double beginXPoint;
            InputData(out beginXPoint);
            double endXPoint;
            do
            {
                Console.Write("End point x = ");
                InputData(out endXPoint);
            }
            while (beginXPoint > endXPoint);

            // Calculation and output the solve of the equation.
            double axesX = endXPoint - beginXPoint;
            SolveEquations(beginXPoint, endXPoint, ref axesX);
        }

        // Finding the solve.
        public static void SolveEquations(double beginPoint, double endPoint, ref double axesX)
        {
            if (Math.Sign(CalculateFunction(beginPoint)) != Math.Sign(CalculateFunction(endPoint)))
            {

                if (!(CheckExtreme(beginPoint) || CheckExtreme(endPoint)))
                {
                    axesX /= 2;
                    double averegePoint = beginPoint + axesX;
                    if (Math.Sign(CalculateFunction(beginPoint)) == Math.Sign(CalculateFunction(averegePoint)))
                    {
                        beginPoint = averegePoint;
                    }

                    if (Math.Abs(CalculateFunction(averegePoint)) > EPSILON)
                    {
                        SolveEquations(beginPoint, endPoint, ref axesX);
                    }
                    else
                    {
                        // Output of solution.
                        Console.WriteLine(averegePoint);
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect data");
            }
        }

        public static bool CheckExtreme(double value)
        {
            if (Math.Abs(CalculateFunction(value)) < EPSILON)
            {
                Console.WriteLine(value);
                return true;
            }
            return false;
        }

        public static double CalculateFunction(double x)
        {
            return 2 * x - 3;
        }

        //Verification of the double number.
        public static bool IsValidData(out double inputNumber)
        {
            return ((double.TryParse(Console.ReadLine().Replace('.', ','), out inputNumber)));
        }

        // Input of the double number.
        public static void InputData(out double newNumber)
        {
            while (!IsValidData(out newNumber))
            {
                Console.WriteLine("Incorrect data. Try again.");
            }
        }
    }
}