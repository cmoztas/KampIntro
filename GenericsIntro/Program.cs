using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            Console.WriteLine(myList.Length);

            myList.Add("Anan");
            myList.Add("Bacın");
            myList.Add("Gardaşın");

            Console.WriteLine(myList.Length);

            foreach (string item in myList.GetItems)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine(item);
            }
        }
    }
}
