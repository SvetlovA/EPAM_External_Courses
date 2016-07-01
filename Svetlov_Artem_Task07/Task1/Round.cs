using System;

namespace Task1
{
    /// <summary>
    /// Class Round
    /// </summary>
    class Round : Circle
    {
        private int _x;
        private int _y;
        private double _radius;

        /// <summary>
        /// Coordinate X
        /// </summary>
        public override int X
        {
            get
            {
                return _x;
            }
        }

        /// <summary>
        /// Coordinate Y
        /// </summary>
        public override int Y
        {
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Radius
        /// </summary>
        public override double Radius
        {
            get
            {
                return _radius;
            }
        }

        /// <summary>
        /// Constructor of class Round
        /// </summary>
        /// <param name="X"> Coordinate X</param>
        /// <param name="Y"> Coordinate Y</param>
        /// <param name="Radius"> Radius</param>
        public Round(int X, int Y, double Radius) : base(X, Y, Radius)
        {
            _x = X;
            _y = Y;
            if (Radius < 0)
            {
                throw new Exception("Радиус меньше нуля!");
            }
            else
            {
                _radius = Radius;
            }
        }

        /// <summary>
        /// Get area of round
        /// </summary>
        /// <returns> Area</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        /// <summary>
        /// Get name of figure
        /// </summary>
        /// <returns> Name of figure</returns>
        public override string GetFigure()
        {
            return "Это круг!";
        }
    }
}
