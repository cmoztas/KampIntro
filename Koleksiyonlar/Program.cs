using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> isimler = new List<string>()
            {
                "Çağkan", "Selin", "Ece", "Timuçin"
            };
            isimler.Add("Kağan");

            foreach (string birey in isimler)
            {
                Console.WriteLine(birey);
            }
        }
    }
}