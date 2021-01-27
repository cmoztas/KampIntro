using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LoanApplicationManager loanApplicationManager = new LoanApplicationManager();

            loanApplicationManager.Apply(new ArtisanLoanManager(), 
                new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});

            List<ILoanManager> loans = new List<ILoanManager> { new MortgageLoanManager(), new VehicleLoanManager() };
            //loanApplicationManager.PreInformation(loans);
        }
    }
}