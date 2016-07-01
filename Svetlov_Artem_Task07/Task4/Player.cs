using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class Player : IPerson, IFieldElements
    {
        private string _name;
        private float _health;
        private int _bonusCount;
        private float _speed;
        private int _x;
        private int _y;

        private int _height;

        private int _width;

        /// <summary>
        /// Constructor of class Player
        /// </summary>
        /// <param name="name">Name of player</param>
        /// <param name="X">Coordinate X</param>
        /// <param name="Y">Coordinate Y</param>
        /// <param name="Width">Width of player</param>
        /// <param name="Height">Height of player</param>
        public Player(string name, int X, int Y, int Width, int Height)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Name of player
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Player healths
        /// </summary>
        public float Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }

        /// <summary>
        /// Speed of player
        /// </summary>
        public float Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                _speed = value;
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
        /// Height of player
        /// </summary>
        public int Height
        {
            get
            {
                return _height;
            }
        }

        /// <summary>
        /// Width of player
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
        }

        /// <summary>
        /// Take bonus
        /// </summary>
        /// <param name="bonus">Bonus what player take</param>
        public void TakeBonus(IBonus bonus)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Field field)
        {
            throw new NotImplementedException();
        }
    }
}