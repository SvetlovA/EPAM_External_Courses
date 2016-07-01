using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Monster : IPerson, IFieldElements
    {
        private float _damage;
        private float _speed;
        private int _x;
        private int _y;

        private int _height;

        private int _width;

        /// <summary>
        /// Constructor of class Monster
        /// </summary>
        /// <param name="X">Coordinate X</param>
        /// <param name="Y">Coordinate Y</param>
        /// <param name="Width">Width of monster</param>
        /// <param name="Height">Height of monster</param>
        public Monster(int X, int Y, int Width, int Height)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Damage of monster
        /// </summary>
        public float Damage
        {
            get
            {
                return _damage;
            }
        }

        /// <summary>
        /// Speed of monster
        /// </summary>
        public float Speed
        {
            get
            {
                return _speed;
            }
        }

        /// <summary>
        /// Get coordinate X
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
        }

        /// <summary>
        /// Get coordinate Y
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
        }

        /// <summary>
        /// Height of monster
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
        }

        /// <summary>
        /// Width of monster
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
        }

        /// <summary>
        /// Make damage
        /// </summary>
        /// <param name="player">Who causes damage</param>
        public void MakeDamage(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Field field)
        {
            throw new NotImplementedException();
        }
    }
}