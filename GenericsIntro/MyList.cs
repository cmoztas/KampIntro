namespace GenericsIntro
{
    /// <summary>
    /// List<> replica.
    /// </summary>
    /// <typeparam name="T">Variable type you sent.</typeparam>
    internal class MyList<T>
    {
        private T[] items;

        public MyList()
        {
            items = new T[0];
        }

        /// <summary>
        /// Add item to your list.
        /// </summary>
        /// <param name="item">List item</param>
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        /// <summary>
        /// Returns length / count of list.
        /// </summary>
        public int Length
        {
            get { return items.Length; }
        }

        /// <summary>
        /// Returns all items of list.
        /// </summary>
        public T[] GetItems
        {
            get { return items; }
        }
    }
}