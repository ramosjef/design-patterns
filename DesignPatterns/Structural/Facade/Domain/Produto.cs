namespace DesignPatterns.Structural.Facade.Domain
{
    public class Produto
    {
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; internal set; }
        public decimal Valor { get; internal set; }
    }
}