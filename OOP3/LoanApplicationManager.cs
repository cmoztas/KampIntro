using System.Collections.Generic;

namespace OOP3
{
    internal class LoanApplicationManager
    {
        // Method Injection
        public void Apply(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            loanManager.Calculate();

            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void PreInformation(List<ILoanManager> loans)
        {
            foreach (ILoanManager loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}