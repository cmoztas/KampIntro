using System;
using System.Linq;

namespace MyDictionary
{
    internal class MyDict<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;

        public MyDict()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            IncreaseArray(ref _keys, ref _values);

            _keys[^1] = key;
            _values[^1] = value;
        }

        public TValue GetValue(TKey key)
        {
            int index = Array.IndexOf(_keys, key);

            return _values[index];
        }

        private void IncreaseArray (ref TKey[] keys, ref TValue[] values)
        {
            SyncArray<TKey>.IncreaseSize(ref keys);
            SyncArray<TValue>.IncreaseSize(ref values);
        }
        

        public int Count => _keys.Length;
    }
}