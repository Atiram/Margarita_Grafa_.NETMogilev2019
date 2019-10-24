using System;

namespace Module2_4
{
    class Triangle : Figure
    {
        public Triangle(double parameter) : base(parameter)
        {
        }
        public static new void Perimeter()
        {
            Display("Perimeter of triangle: ", 3 * Parameter);
        }
        public static new void Area()
        {
            Display("Area of triangle: ", Math.Sqrt(3) * Math.Pow(Parameter, 2) / 4);
        }
    }
}