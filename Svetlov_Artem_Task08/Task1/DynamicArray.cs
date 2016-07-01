using System;

namespace Task1
{
    /// <summary>
    /// Class Dynamic Array
    /// </summary>
    /// <typeparam name="T"> Type of array</typeparam>
    class DynamicArray<T> where T : new()
    {
        private T[] _array;
        private int _capacity;
        private int _length;

        /// <summary>
        /// The real capacity of array
        /// </summary>
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        /// <summary>
        /// Length of array
        /// </summary>
        public int Length
        {
            get
            {
                return _length;
            }
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index"> Index</param>
        /// <returns> Value of array</returns>
        public T this[int index]
        {
            get
            {
                if (index >= _length)
                {
                    throw new ArgumentOutOfRangeException("Индекс находится за пределами массива!!!");
                }
                else
                {
                    return _array[index];
                }
            }
            set
            {
                if (index >= _length)
                {
                    throw new ArgumentOutOfRangeException("Индекс находится за пределами массива!!!");
                }
                else
                {
                    _array[index] = value;
                }
            }
        }

        /// <summary>
        /// Constructor of class DynamicArray
        /// </summary>
        public DynamicArray()
        {
            _array = new T[8];
            _capacity = 8;
            _length = 0;
        }

        /// <summary>
        /// Constructor of class DynamicArray
        /// </summary>
        /// <param name="size"> Size of array</param>
        public DynamicArray(int size)
        {
            _array = new T[size];
            _capacity = size;
            _length = 0;
        }

        /// <summary>
        /// Constructor of class DynamicArray
        /// </summary>
        /// <param name="array"> Array</param>
        public DynamicArray(T[] array)
        {
            _array = array;
            _capacity = array.Length;
            for (int i = 0; i < _array.Length; i++)
            {
                if (!Equals(_array[i], default(T)))
                {
                    _length++;
                }
                else
                {
                    for (int j = i; j < _array.Length - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                }
            }
        }

        /// <summary>
        /// Add new element
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (_length >= _capacity)
            {
                Array.Resize(ref _array, _capacity = _capacity == 0 ? 1 : _capacity *= 2);
            }
            _array[_length++] = element;
        }

        /// <summary>
        /// Add array to the end of array
        /// </summary>
        /// <param name="addArray"> Added array</param>
        public void AddRange(T[] addArray)
        {
            if (_length + addArray.Length > _capacity)
            {
                Array.Resize(ref _array, _capacity = _length + addArray.Length);
            }
            addArray.CopyTo(_array, _length);
            _length += addArray.Length;
        }

        /// <summary>
        /// Remove element of array
        /// </summary>
        /// <param name="element"> Removing element</param>
        /// <returns> Remove or not remove</returns>
        public bool Remove(T element)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (Equals(_array[i], element))
                {
                    for (int j = i; j < _length - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                    _length--;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Insert new elemenent to array
        /// </summary>
        /// <param name="element"> Element to add</param>
        /// <param name="position"> Position to add</param>
        /// <returns> Added or not added</returns>
        public bool Insert(T element, int position)
        {
            if (position < _capacity)
            {
                if (position <= _length)
                {
                    if (_length == _capacity)
                    {
                        Array.Resize(ref _array, _capacity += 1);
                    }
                    T last = _array[_length = _length == 0 ? 0 : _length - 1];
                    for (int i = _length; i > position; i--)
                    {
                        _array[i] = _array[i - 1];
                    }
                    _array[_length] = last;
                    _array[position] = element;
                    _length++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Аргумент находится за пределами массива!!!");
            }
        }
    }
}
