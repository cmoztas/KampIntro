using System;

namespace OOP3
{
    internal class VehicleLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle loan calculated.");
        }
    }
}