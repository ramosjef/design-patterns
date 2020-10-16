namespace DesignPatterns.Creational.Singleton
{
    public class Server
    {
        public string Name { get; private set; }
        public string IP { get; private set; }

        public Server(string name, string ip)
        {
            Name = name;
            IP = ip;
        }
    }
}