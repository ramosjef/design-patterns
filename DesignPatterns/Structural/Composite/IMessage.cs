using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public interface IMessage
    {
        string Nome { get; set; }
        void ExibirMensagens(int sub);
        //void AdicionarFilha(IMessage filha);
        //void RemoverFilha(IMessage filha);
        //IMessage ObterFilha(int index);
        //IMessage ObterFilha(string nome);
        //List<IMessage> ObterLista();
    }
}
