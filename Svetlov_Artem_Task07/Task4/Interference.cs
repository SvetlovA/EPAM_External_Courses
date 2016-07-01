using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Interference : IFieldElements
    {
        private int _x;
        private int _y;
        private int _width;
        private int _height;

        /// <summary>
        /// Constructor of class Interference
        /// </summary>
        /// <param name="X">Coordinate X</param>
        /// <param name="Y">Coordinate Y</param>
        /// <param name="Width">Width of interference</param>
        /// <param name="Height">Height of inteerference</param>
        public Interference(int X, int Y, int Width, int Height)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Coordinate X
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
        }

        /// <summary>
        /// Coordinaye Y
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Width of interference
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
        }

        /// <summary>
        /// Height of interference
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
        }
    }
}