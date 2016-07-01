namespace Task2
{
    /// <summary>
    /// Class ArithmeticalProgression
    /// </summary>
    class ArithmeticalProgression : ISeries
    {
        private double _start;
        private double _step;
        private int _currentIndex;

        /// <summary>
        /// Constructor of class ArithmeticalProgression
        /// </summary>
        /// <param name="start"> Start element of progression</param>
        /// <param name="step"> Step</param>
        public ArithmeticalProgression(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 0;
        }

        /// <summary>
        /// Get current element
        /// </summary>
        /// <returns> Current element</returns>
        public double GetCurrent()
        {
            return _start + _step * _currentIndex;
        }

        /// <summary>
        /// Move to next element
        /// </summary>
        /// <returns> Move or not move</returns>
        public bool MoveNext()
        {
            _currentIndex++;
            return true;
        }

        /// <summary>
        /// Reset progression
        /// </summary>
        public void Reset()
        {
            _currentIndex = 0;
        }
    }
}
