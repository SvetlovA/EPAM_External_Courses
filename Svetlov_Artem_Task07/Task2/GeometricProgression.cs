using System;

namespace Task2
{
    /// <summary>
    /// Class GeometricalProgression
    /// </summary>
    class GeometricalProgression : ISeries
    {
        private double _start;
        private double _step;
        private int _currentIndex;

        /// <summary>
        /// Constructor of class FeometricalProgression
        /// </summary>
        /// <param name="start"> Strt number</param>
        /// <param name="step"> Step</param>
        public GeometricalProgression(double start, double step)
        {
            _start = start;
            _step = step;
            _currentIndex = 1;
        }

        /// <summary>
        /// Get current element
        /// </summary>
        /// <returns> Current element</returns>
        public double GetCurrent()
        {
            return _start * Math.Pow(_step, _currentIndex - 1);
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
            _currentIndex = 1;
        }
    }
}
