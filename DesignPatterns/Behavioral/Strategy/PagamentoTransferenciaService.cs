using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            _pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando pagamento via Transferencia - valor R$ {0}", pagamento.Valor);

            if (_pagamentoTransferenciaFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Sucesso no pagamento via transferencia";
                return pagamento;
            }
            pagamento.Status = "Erro ao efetuar pagamento via transferencia";
            return pagamento;
        }
    }
}
