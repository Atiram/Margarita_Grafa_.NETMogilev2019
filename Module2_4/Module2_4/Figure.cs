using System;

namespace Module2_4
{
    class Figure
    {
        public static double Parameter { get; set; }

        public Figure(double parameter)
        {
            Parameter = parameter;
        }
        public static void Perimeter() { }
        public static void Area() { }

        public static void Display(string type, double calculate)
        {
            Console.WriteLine(type + calculate);
        }
    }
}
