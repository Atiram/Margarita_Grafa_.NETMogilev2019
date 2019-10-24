using System;

namespace Module2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure;
            Console.WriteLine("Input type of figure: triangle 1, square 2, circle 3");
            switch (Input(3))
            {
                case 1:
                    figure = new Triangle(Input());
                    break;
                case 2:
                    figure = new Square(Input());
                    break;
                case 3:
                    figure = new Circle(Input());
                    break;
                default:
                    figure = new Square(Input());
                    break;
            }
            Console.WriteLine("Input type of characteristic: perimeter 1, area 2");
            switch (Input(2))
            {
                case 1:
                    if (!(figure is Triangle)) Triangle.Perimeter();
                    if (!(figure is Square)) Square.Perimeter();
                    if (!(figure is Circle)) Circle.Perimeter();
                    break;
                case 2:
                    if (!(figure is Triangle)) Triangle.Area();
                    if (!(figure is Square)) Square.Area();
                    if (!(figure is Circle)) Circle.Area();
                    break;
            }
            Console.ReadKey();
        }
        public static double Input()
        {
            double inputValue;
            Console.WriteLine("Input side/radius of the figure");
            while (!(double.TryParse(Console.ReadLine(), out inputValue)))
                Console.WriteLine("Incorrect data. Try again.");
            return inputValue;
        }
        public static uint Input(uint condition)
        {
            uint inputValue;
            while (!(uint.TryParse(Console.ReadLine(), out inputValue)) || !(inputValue <= condition && inputValue > 0))
                Console.WriteLine("Incorrect data. Try again.");
            return inputValue;
        }
    }
}
