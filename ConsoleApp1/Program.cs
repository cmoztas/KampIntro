using System;
using System.Dynamic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            switch (Console.ReadLine())
            {
                case "1": 
                    Console.WriteLine("case 1 seçildi.");
                case "2":
                    Console.WriteLine("case 2 seçildi.");
                case "3":
                    Console.WriteLine("case 3 seçildi.");
                default: 
                    Console.WriteLine("Başka bir şey yazıldı.");
            }

        }
    }
}