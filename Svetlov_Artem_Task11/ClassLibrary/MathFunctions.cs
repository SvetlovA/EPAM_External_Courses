using System;

namespace ClassLibrary
{
    public class MathFunctions
    {
        /// <summary>
        /// Factorial
        /// </summary>
        /// <param name="number"> Input number</param>
        /// <returns> Factorial of number</returns>
        public static long Fact(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            if (number == 0)
            {
                return 1;
            }
            return number * Fact(number - 1);   
        }

        /// <summary>
        /// Power
        /// </summary>
        /// <param name="number"> Input number</param>
        /// <param name="power"> Power</param>
        /// <returns> Power</returns>
        public static double Pow(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
