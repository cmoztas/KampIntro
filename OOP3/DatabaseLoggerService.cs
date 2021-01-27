using System;

namespace OOP3
{
    internal class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");
        }
    }
}