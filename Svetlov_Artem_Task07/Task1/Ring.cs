using System;

namespace Task1
{
    /// <summary>
    /// Class Ring
    /// </summary>
    class Ring : Round
    {
        private int _x;
        private int _y;
        private double _radius;
        private double _outerRadius;

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
        /// Inner radius
        /// </summary>
        public override double Radius
        {
            get
            {
                return _radius;
            }
        }

        /// <summary>
        /// Outer radius
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
        }

        /// <summary>
        /// Constructor of class Ring
        /// </summary>
        /// <param name="X"> Coordinate X</param>
        /// <param name="Y"> Coordinate Y</param>
        /// <param name="Radius"> Inner radius</param>
        /// <param name="OuterRadius"> Outer radius</param>
        public Ring(int X, int Y, double Radius, double OuterRadius) : base(X, Y, Radius)
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
            if (OuterRadius <= Radius)
            {
                throw new Exception("Внешний радиус меньше внутреннего радиуса");
            }
            else
            {
                _outerRadius = OuterRadius;
            }
        }

        /// <summary>
        /// Get length of ring
        /// </summary>
        /// <returns> Length</returns>
        public override double GetLength()
        {
            return base.GetLength() + 2 * Math.PI * _outerRadius;
        }

        /// <summary>
        /// Get area of ring
        /// </summary>
        /// <returns> Area</returns>
        public override double GetArea()
        {
            return (Math.PI * Math.Pow(_radius, 2)) - base.GetArea();
        }

        /// <summary>
        /// Get name of figure
        /// </summary>
        /// <returns> Name of figure</returns>
        public override string GetFigure()
        {
            return "Это кольцо!";
        }
    }
}
