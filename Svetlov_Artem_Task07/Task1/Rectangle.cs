using System;

namespace Task1
{
    /// <summary>
    /// Class Rectangle
    /// </summary>
    class Rectangle : IFigure
    {
        private double _width;
        private double _height;

        /// <summary>
        /// Width
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
        }

        /// <summary>
        /// Height
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
        }

        /// <summary>
        /// Constructor of class Rectangle
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public Rectangle(double Width, double Height)
        {
            if (Width <= 0)
            {
                throw new Exception("Ширина не может иметь отрицательное или нулевое значение!!!");
            }
            else
            {
                _width = Width;
            }
            if (Height <= 0)
            {
                throw new Exception("Высота не может иметь отрицательное или нулевое значение!!!");
            }
            else
            {
                _height = Height;
            }
        }

        /// <summary>
        /// Get figure
        /// </summary>
        /// <returns> Name of figure</returns>
        public string GetFigure()
        {
            return "Это прямоугольник!";
        }

        /// <summary>
        /// Get perimetr of rectangle
        /// </summary>
        /// <returns> Perimetr</returns>
        public double GetLength()
        {
            return (2 * _width) + (2 * _height);
        }

        /// <summary>
        /// Get area of rectangle
        /// </summary>
        /// <returns> Area</returns>
        public double GetArea()
        {
            return _width * _height;
        }
    }
}
