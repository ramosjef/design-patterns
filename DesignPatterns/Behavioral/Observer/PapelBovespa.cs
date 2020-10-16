namespace DesignPatterns.Behavioral.Observer
{
    //Concrete subject
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string simbolo, decimal valor)
            : base(simbolo, valor)
        {
        }
    }
}
