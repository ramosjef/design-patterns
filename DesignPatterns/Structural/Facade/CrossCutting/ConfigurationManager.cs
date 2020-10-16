using System;

namespace DesignPatterns.Structural.Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string key)
        {
            return Guid.NewGuid().ToString();
        }
    }
}