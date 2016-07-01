namespace Task2
{
    /// <summary>
    /// Interface ISeries
    /// </summary>
    interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
