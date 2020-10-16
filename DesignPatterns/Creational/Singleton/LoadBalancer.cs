using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        public LoadBalancer()
        {
            _servers = new List<Server>()
            {
                new Server("Server I", "120.14.220.18"),
                new Server("Server II", "120.14.220.19"),
                new Server("Server III", "120.14.220.20"),
                new Server("Server IV", "120.14.220.21"),
                new Server("Server V", "120.14.220.22"),
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
