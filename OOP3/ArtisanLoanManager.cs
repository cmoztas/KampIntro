using System;

namespace OOP3
{
    internal class ArtisanLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Artisan loan calculated.");
        }
    }
}