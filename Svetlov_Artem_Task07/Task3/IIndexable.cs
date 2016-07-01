namespace Task3
{
    /// <summary>
    /// Interface IIndexable
    /// </summary>
    interface IIndexable
    {
        double this[int index] { get; }
        int Length { get; }
    }
}
