using System;

namespace OOP3
{
    internal class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms sent.");
        }
    }
}