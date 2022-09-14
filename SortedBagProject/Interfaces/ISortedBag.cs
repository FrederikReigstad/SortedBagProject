namespace SortedBagProject.Interfaces
{
    public interface ISortedBag
    {
        /// <summary>
        ///     Returns the current size of the SortedBag
        /// </summary>
        int Count { get; }

        /// <summary>
        ///     Returns true if the SortedBag is empty.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        ///     Contains the values of the SortedBag
        /// </summary>
        List<int> Items { get; }

        /// <summary>
        ///     Adds the given number to the SortedBag.
        /// </summary>
        /// <param name="number">The value to add</param>
        void Add(int number);

        /// <summary>
        ///     Removes and returns the smallest number of the SortedBag.
        ///     If the SortedBag is empty then an InvalidOperationException is thrown.
        /// </summary>
        /// <returns>The smallest number of the SortedBag</returns>
        /// <exception>InvalidOperationException: If the bag is empty</exception>"
        int Fetch();

        /// <summary>
        ///     Returns the smallest number of the SortedBag.
        ///     If the SortedBag is empty then an InvalidOperationException is thrown.
        /// </summary>
        /// <returns>The smallest number of the SortedBag</returns>
        /// <exception>InvalidOperationException: If the bag is empty</exception>"
        int Peek();

        /// <summary>
        ///     Empties the bag.
        /// </summary>
        void Clear();
    }
}
