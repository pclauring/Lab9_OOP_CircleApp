using System;

namespace Lab9_Circle_Calculator
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to the Circle Tester");
                Console.Write("Enter radius: ");

                double radius = Validator.GetValidDouble();

                Circle circleNew = new Circle(radius);

                Console.WriteLine($"Circumference: {circleNew.GetFormattedCircumference()}");
                Console.WriteLine($"Area: {circleNew.GetFormattedArea()}");
                Console.WriteLine($"{Circle.numberOfCircles} circle objects have been created...");

                Console.Write("Continue? (y/n): ");
                repeat = GetYesorNo();
            } while (repeat);
        }
        private static bool GetYesorNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    valid = false;
                    repeat = true;
                }
                else if (answer == "n" || answer == "no")

                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.Write("Did not enter a valid input. Please enter (y/n): ");
                }
            }

            return repeat;
        }
    }
}
