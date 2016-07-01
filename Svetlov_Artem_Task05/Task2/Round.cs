using System;

namespace Task2
{
    /// <summary>
    /// Class Round
    /// </summary>
    class Round
    {
        private double _x;
        private double _y;
        private double _radius;

        /// <summary>
        /// Constuctor of class user
        /// </summary>
        /// <param name="parX"> Coordinate X</param>
        /// <param name="parY"> Coordinate Y</param>
        /// <param name="parRadius"> Radius of circle</param>
        public Round(double parX, double parY, double parRadius)
        {
            _x = parX;
            _y = parY;
            _radius = parRadius;
        }

        /// <summary>
        /// Area of circle
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(_radius, 2);
            }
        }

        /// <summary>
        /// Length of circle
        /// </summary>
        public double LengthOfCircle
        {
            get
            {
                return 2 * Math.PI * _radius;
            }
        }

        /// <summary>
        /// Coordinate X
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }
        } 

        /// <summary>
        /// Coordinate Y
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Radius
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
        }
    }
}
