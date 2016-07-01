namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        /// <summary>
        /// Ovveride gethascode
        /// </summary>
        /// <returns> Hashcode</returns>
        public override int GetHashCode()
		{
//#error на миллионе комбинаций будет уникально?
//#error лучше поискать msdn hashcode override
			return (y ^ x) + y;
        }
    }
}
