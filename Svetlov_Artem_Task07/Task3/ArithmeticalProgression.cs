using System;

namespace Task3
{
    /// <summary>
    /// Class ArithmeticalProgression 
    /// </summary>
    class ArithmeticalProgression : ISeries, IIndexable
    {
        private double[] _progression;
        private int _progressionIndex;
        private double _start;
        private double _step;
        private int _currentIndex;

        /// <summary>
        /// Length of array
        /// </summary>
        public int Length
        {
            get
            {
                return _progression.Length;
            }
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index"> Index</param>
        /// <returns> Element of array</returns>
        public double this[int index]
        {
            get
            {
                return _progression[index];
            }
        }

        /// <summary>
        /// Constructor of class ArithmeticalProgression
        /// </summary>
        /// <param name="start"></param>
        /// <param name="step"></param>
        public ArithmeticalProgression(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 0;
            _progressionIndex = 0;
        }

        /// <summary>
        /// Get current element of progression
        /// </summary>
        /// <returns> Element of progression</returns>
        public double GetCurrent()
        {
            Array.Resize(ref _progression, _progressionIndex + 1);
            _progression[_progressionIndex] = _start + _step * _currentIndex;
            return _progression[_progressionIndex]; 
        }

        /// <summary>
        /// Move to next element
        /// </summary>
        /// <returns> Move or not move</returns>
        public bool MoveNext()
        {
            _currentIndex++;
            _progressionIndex++;
            return true;
        }

        /// <summary>
        /// Reset
        /// </summary>
        public void Reset()
        {
            _currentIndex = 0;
        }
    }
}
