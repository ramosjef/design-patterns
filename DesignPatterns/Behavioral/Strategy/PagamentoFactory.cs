using DesignPatterns.Structural.Facade.CrossCutting;
using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            //implementar service locator ou
            //injetar todas as instancias para retornar apenas uma
            return meioPagamento switch
            {
                MeioPagamento.CartaoCredito => new PagamentoCartaoCreditoService(
                    new PagamentoCartaoCreditoFacade(
                        new PayPalGateway(),
                        new ConfigurationManager())),
                MeioPagamento.Boleto => new PagamentoBoletoService(new PagamentoBoletoFacade()),
                MeioPagamento.Transferencia => new PagamentoTransferenciaService(new PagamentoTransferenciaFacade()),
                _ => throw new ApplicationException("Meio de pagamento desconhecido."),
            };
        }
    }
}
