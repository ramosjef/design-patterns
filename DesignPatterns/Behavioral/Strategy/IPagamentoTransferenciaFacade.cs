using DesignPatterns.Structural.Facade.Domain;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface IPagamentoTransferenciaFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
