using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Connection : IDisposable
    {
        public bool Opened { get; private set; }
        public string ConnectionString { get; private set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando comando {0}", command);
        }

        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão fechada");
        }

        public void Dispose()
        {
            Close();
        }
    }
}