using System;

namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int s1, int s2);

        private static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;

            myDelegate2("naber");

            myDelegate += customerManager.ShowAlert;

            myDelegate();


            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            Console.WriteLine(myDelegate3(5, 7));
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
    }

    public class Matematik
    {
        public int Topla(int x, int y)
        {
            return x + y;
        }
    }
}