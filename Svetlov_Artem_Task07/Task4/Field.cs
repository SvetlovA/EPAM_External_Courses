using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Field
    {
        private int _width;
        private int _height;

        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        public Field(int width, int height)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Width of field
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
        }

        /// <summary>
        /// Height of field
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
        }

        /// <summary>
        /// Delete field
        /// </summary>
        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Resize field
        /// </summary>
        /// <param name="newWidth">New width</param>
        /// <param name="newHeight">New height</param>
        public void Resize(int newWidth, int newHeight)
        {
            throw new System.NotImplementedException();
        }
    }
}