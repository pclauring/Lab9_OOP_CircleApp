using System;

namespace Lab9_Circle_Calculator
{

    class Circle
    {
        const double PI = Math.PI;

        private double radius;
        public static int numberOfCircles = 0;

        public Circle(double rad)
        {
            radius = rad;
            numberOfCircles++;
        }

        public double getRadius()
        {
            return radius;
        }
        public double GetCircumference()
        {
            return radius * PI * 2;
        }

        public string GetFormattedCircumference()
        {
            return FormatNumber(GetCircumference());
        }

        public double GetArea()
        {
            return Math.Pow(radius, 2) * PI;
        }

        public string GetFormattedArea()
        {
            return FormatNumber(GetArea());
        }

        private String FormatNumber(double x)
        {
            return string.Format("{0:0.00}", x);
        }
    }

}
