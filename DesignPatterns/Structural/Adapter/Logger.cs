using System;

namespace DesignPatterns.Structural.Adapter
{
    //Target Class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log padrão - {0}", message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão - {0}", exception.Message);
        }
    }
}
