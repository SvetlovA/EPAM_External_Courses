using System;

namespace Task3
{
    /// <summary>
    /// Class Triangle
    /// </summary>
    class Triangle
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Constructor of class triangle
        /// </summary>
        /// <param name="parA"> Side a</param>
        /// <param name="parB"> Side b</param>
        /// <param name="parC"> Side c</param>
        public Triangle(double parA, double parB, double parC)
        {
            if (parA >= parB + parC || parB >= parA + parC || parC >= parA + parB)
            {
                throw new Exception("По данным сторонам нельзя построить треугольник!!!!");
            }
            else
            {
                _a = parA;
                _b = parB;
                _c = parC;
            }
        }

        /// <summary>
        /// Side a
        /// </summary>
        public double A
        {
            get
            {
                return _a;
            }
        }

        /// <summary>
        /// Side b
        /// </summary>
        public double B
        {
            get
            {
                return _b;
            }
        }

        /// <summary>
        /// Side c
        /// </summary>
        public double C
        {
            get
            {
                return _c;
            }
        }

        /// <summary>
        /// Perimeter of tiangle
        /// </summary>
        /// <returns> Perimeter</returns>
        public double GetPerimeter()
        {
            return _a + _b + _c;
        }

        /// <summary>
        /// Area of tringle
        /// </summary>
        /// <returns> Area</returns>
        public double GetArea()
        {
            double halfPerimetr = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - _a) * (halfPerimetr - _b) * (halfPerimetr - _c)); 
        }
    }
}
