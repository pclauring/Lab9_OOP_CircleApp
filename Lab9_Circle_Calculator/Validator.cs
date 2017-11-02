using System;

namespace Lab9_Circle_Calculator
{
    class Validator
    {
        public static double GetValidDouble()
        {
            bool success = false;
            while (!success)
            {
                success = double.TryParse(Console.ReadLine(), out double radius);
                if (radius > 0)
                {
                    return radius;
                }
                Console.WriteLine("That is not a valid radius... please try again.");
                success = false;
            }
            return 0;
        }


    }
}
