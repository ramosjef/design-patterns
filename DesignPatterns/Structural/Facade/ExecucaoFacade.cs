using DesignPatterns.Structural.Facade.CrossCutting;
using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var produtos = new List<Produto>()
            {
                new Produto( "Tenis adidas", new Random().Next(500)),
                new Produto ("Camisa boliche",  new Random().Next(500)),
                new Produto ("Raquete tenis",  new Random().Next(500)),
            };

            var pedido = new Pedido()
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento()
            {
                CartaoCredito = "5555 5555 5555 5555",
            };

            //Resolver com DI
            var pagamentoService = new PagamentoCartaoCreditoService(
                new PagamentoCartaoCreditoFacade(
                    new PayPalGateway(),
                    new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);
            Console.WriteLine(pagamentoResult.Status);
        }
    }
}
