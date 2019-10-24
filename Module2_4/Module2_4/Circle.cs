using System;

namespace Module2_4
{
    class Circle : Figure
    {
        public Circle(double parameter) : base(parameter)
        {
        }
        public static new void Perimeter()
        {
            Display("Perimeter of cicrle: ", 2 * Math.PI * Parameter);
        }
        public static new void Area()
        {
            Display("Area of circle: ", Math.Pow(Parameter, 2) * Math.PI);
        }
    }
}