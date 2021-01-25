namespace MyDictionary
{
    static class SyncArray<T>
    {
        internal static void IncreaseSize(ref T[] array)
        {
            T[] tempValues = array;
            array = new T[array.Length + 1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                array[i] = tempValues[i];
            }
        }
    }
}