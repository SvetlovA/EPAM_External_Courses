using System;

namespace Task1
{
    /// <summary>
    /// Class Line
    /// </summary>
    class Line : IFigure
    {
        private int _startX;
        private int _startY;
        private int _endX;
        private int _endY;

        /// <summary>
        /// Coordinate start X
        /// </summary>
        public int StartX
        {
            get
            {
                return _startX;
            }
        }

        /// <summary>
        /// Coordinate start Y
        /// </summary>
        public int StartY
        {
            get
            {
                return _startY;
            }
        }

        /// <summary>
        /// Coordinate end X
        /// </summary>
        public int EndX
        {
            get
            {
                return _endX;
            }
        }

        /// <summary>
        /// Coordinate end Y
        /// </summary>
        public int EndY
        {
            get
            {
                return _endY;
            }
        }

        /// <summary>
        /// Constructor of class Line
        /// </summary>
        /// <param name="StartX"> Coordinate start X</param>
        /// <param name="StartY"> Coordinate start Y</param>
        /// <param name="EndX"> Coordinate end X</param>
        /// <param name="EndY"> Coordinate end Y</param>
        public Line(int StartX, int StartY, int EndX, int EndY)
        {
            _startX = StartX;
            _startY = StartY;
            _endX = EndX;
            _endY = EndY;
        }

        /// <summary>
        /// Get name of figure
        /// </summary>
        /// <returns> Name of figure</returns>
        public string GetFigure()
        {
            return "Это линия!";
        }

        /// <summary>
        /// Get length of line
        /// </summary>
        /// <returns> Length</returns>
        public double GetLength()
        {
            return Math.Sqrt((Math.Pow(_startY - _startX, 2) + Math.Pow(_endY - _endX, 2)));
        }

        /// <summary>
        /// Get area of line
        /// </summary>
        /// <returns> Area of line</returns>
        public double GetArea()
        {
            return 0;
        }
    }
}
