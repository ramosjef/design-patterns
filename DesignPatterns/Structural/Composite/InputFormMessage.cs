using System;

namespace DesignPatterns.Structural.Composite
{
    public class InputFormMessage : IMessage
    {
        public string Nome { get; set; }

        public InputFormMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
