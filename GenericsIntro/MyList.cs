namespace GenericsIntro
{
    internal class MyList<T>
    {
        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }
        
        public void Add(T item)
        {
            T[] tempArray = _items;
            _items = new T[_items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }

            // ^1 = _items.Length - 1
            _items[^1] = item;
        }
        
        public int Length => _items.Length;
        
        public T[] GetItems => _items;
    }
}