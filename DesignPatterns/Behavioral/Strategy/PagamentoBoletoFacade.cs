using System;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoBoletoFacade : IPagamentoBoletoFacade
    {
        public string GerarBoleto()
        {
            return new string(Enumerable.Repeat("0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
