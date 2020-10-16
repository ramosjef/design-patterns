using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PagamentoTransferenciaFacade : IPagamentoTransferenciaFacade
    {
        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            return true;
        }
    }
}
