using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ExecucaoStrategy
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

            var cartao = new Pagamento()
            {
                CartaoCredito = "1234 1324 4546 45457",
            };
            var transferencia = new Pagamento();
            var boleto = new Pagamento();

            var pedidoBoleto = new PedidoService(PagamentoFactory.CreatePagamento(MeioPagamento.Boleto));
            var resBoleto = pedidoBoleto.RealizarPagamento(pedido, boleto);
            Console.WriteLine(resBoleto.Status);

            var pedidoCartao = new PedidoService(PagamentoFactory.CreatePagamento(MeioPagamento.CartaoCredito));
            var resCartao = pedidoCartao.RealizarPagamento(pedido, cartao);
            Console.WriteLine(resCartao.Status);

            var pedidoTransferencia = new PedidoService(PagamentoFactory.CreatePagamento(MeioPagamento.Transferencia));
            var resTransf = pedidoTransferencia.RealizarPagamento(pedido, transferencia);
            Console.WriteLine(resTransf.Status);
        }
    }
}
