using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoBoletoService : IPagamento
    {
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoService(IPagamentoBoletoFacade pagamentoBoletoFacade)
        {
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via boleto - valor R$ {0}", pagamento.Valor);

            pagamento.LinhaDigitavelBoleto = _pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando pagamento";
            return pagamento;
        }
    }
}
