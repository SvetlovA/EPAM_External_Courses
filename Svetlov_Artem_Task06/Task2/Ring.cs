using System;

namespace Task2
{
    /// <summary>
    /// Class Ring
    /// </summary>
    class Ring : Round
    {
        private double _extaernalRadius;

        /// <summary>
        /// Constructor of class Ring
        /// </summary>
        /// <param name="X"> Coordinate X</param>
        /// <param name="Y"> Coordinate Y</param>
        /// <param name="Radius"> Interior radius</param>
        /// <param name="ExtarnalRadius"> External radius</param>
        public Ring(double X, double Y, double Radius, double ExtarnalRadius) : base(X, Y, Radius)
        {
            if (ExtarnalRadius > 0 && ExternalRadius > Radius)
            {
                _extaernalRadius = ExtarnalRadius;
            }
            else
            {
                throw new Exception("Вы ввели значение радиуса меньше нуля или меньше внутреннего радиуса!!!");
            }
        }

        /// <summary>
        /// Area of ring
        /// </summary>
        public double AreaOfRing
        {
            get
            {
                return Math.PI* Math.Pow(_extaernalRadius, 2) - AreaOfCircle;
            }
        }

        /// <summary>
        /// External radius
        /// </summary>
        public double ExternalRadius
        {
            get
            {
                return _extaernalRadius;
            }
        }

        /// <summary>
        /// Length of interior and external circles
        /// </summary>
        public double LengthOfRing
        {
            get
            {
                return (2 * Math.PI * _extaernalRadius) + LengthOfCircle;
            }
        }
    }
}
