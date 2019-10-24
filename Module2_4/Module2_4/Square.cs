using System;

namespace Module2_4
{
    class Square : Figure
    {

        public Square(double parameter) : base(parameter)
        {
        }
        public static new void Perimeter()
        {
            Display("Perimeter of square: ", 4 * Parameter);
        }
        public static new void Area()
        {
            Display("Area of square: ", Math.Pow(Parameter, 2));
            //Console.WriteLine(Math.Pow(Parameter, 2));
        }
    }
}