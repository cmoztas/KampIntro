using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDict<int, string> myDict = new MyDict<int, string>();

            myDict.Add(1, "Çağkan");
            myDict.Add(2, "Mert");
            myDict.Add(3, "Öztaş");

            Console.WriteLine($"Key 1'e karşılık gelen değer: {myDict.GetValue(1)}");
            Console.WriteLine($"myDict boyutu: {myDict.Count}");
        }
    }
}