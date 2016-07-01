using System;

namespace Task1
{
    /// <summary>
    /// Class Circle
    /// </summary>
    class Circle : IFigure
    {
        private int _x;
        private int _y;
        private double _radius;

        /// <summary>
        /// Coordinate X
        /// </summary>
        public virtual int X
        {
            get
            {
                return _x;
            }
        }

        /// <summary>
        /// Coordinate Y
        /// </summary>
        public virtual int Y
        {
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Radius
        /// </summary>
        public virtual double Radius
        {
            get
            {
                return _radius;
            }
        }

        /// <summary>
        /// Constructor of class Circle
        /// </summary>
        /// <param name="X"> Coordinate X</param>
        /// <param name="Y"> Coordinate Y</param>
        /// <param name="Radius"> Radius</param>
        public Circle(int X, int Y, double Radius)
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
        /// Get name of figure
        /// </summary>
        /// <returns> Name of figure</returns>
        public virtual string GetFigure()
        {
            return "Это окружность";
        }

        /// <summary>
        /// Get length of circle
        /// </summary>
        /// <returns> Length of circle</returns>
        public virtual double GetLength()
        {
            return 2 * Math.PI * _radius;
        }

        /// <summary>
        /// Get area of circle
        /// </summary>
        /// <returns> Area of circle</returns>
        public virtual double GetArea()
        {
            return 0;
        }
    }
}
