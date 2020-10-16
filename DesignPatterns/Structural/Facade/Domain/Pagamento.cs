namespace DesignPatterns.Structural.Facade.Domain
{
    public class Pagamento
    {
        public Pagamento()
        {
        }

        public string CartaoCredito { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
    }
}