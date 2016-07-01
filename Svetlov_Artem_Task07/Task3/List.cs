namespace Task3
{
    /// <summary>
    /// Class List
    /// </summary>
    class List : ISeries, IIndexable
    {
        private double[] _series;
        private int _currentIndex;

        /// <summary>
        /// Length of array
        /// </summary>
        public int Length
        {
            get
            {
                return _series.Length;
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
                return _series[index];
            }
        }

        /// <summary>
        /// Constructor of class List
        /// </summary>
        /// <param name="series"></param>
        public List(double[] series)
        {
            _series = series;
            _currentIndex = 0;
        }

        /// <summary>
        /// Get current element
        /// </summary>
        /// <returns> Element</returns>
        public double GetCurrent()
        {
            return _series[_currentIndex];
        }

        /// <summary>
        /// Move to next element
        /// </summary>
        /// <returns> Move or not move</returns>
        public bool MoveNext()
        {
            _currentIndex = _currentIndex < _series.Length - 1 ? _currentIndex + 1 : 0;
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
