using System;

namespace DesignPatterns.Structural.Adapter
{
    //Adaptee Class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("Log customizado - {0}", exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Log customizado - {0}", message);
        }
    }
}
