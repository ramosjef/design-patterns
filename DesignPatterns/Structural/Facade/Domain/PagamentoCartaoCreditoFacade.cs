using DesignPatterns.Structural.Facade.CrossCutting;

namespace DesignPatterns.Structural.Facade.Domain
{
    internal class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfigurationManager _configurationManager;

        public PagamentoCartaoCreditoFacade(
            IPayPalGateway payPalGateway,
            IConfigurationManager configurationManager)
        {
            _payPalGateway = payPalGateway;
            _configurationManager = configurationManager;
        }

        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            var apiKey = _configurationManager.GetValue("apiKey");
            var encriptionKey = _configurationManager.GetValue("encriptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            var result = _payPalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Valor);
            return result; 
        }
    }
}