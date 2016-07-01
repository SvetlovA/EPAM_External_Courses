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
        /// <param name="X"> Coordinate X</param>
        /// <param name="Y"> Coordinate Y</param>
        /// <param name="Radius"> Radius of circle</param>
        public Round(double X, double Y, double Radius)
        {
            _x = X;
            _y = Y;
            if (Radius > 0)
            {
                _radius = Radius;
            }
            else
            {
                throw new Exception("Вы ввели значение внутреннего радиуса меньше нуля!!!");
            }
        }

        /// <summary>
        /// Area of circle
        /// </summary>
        public double AreaOfCircle
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
