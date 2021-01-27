using System;

namespace OOP3
{
    internal class PersonalLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal loan calculated.");
        }
    }
}