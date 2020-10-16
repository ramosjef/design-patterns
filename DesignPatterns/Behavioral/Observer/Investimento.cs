using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    //Subject
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        protected Investimento(string simbolo, decimal valor)
        {
            Simbolo = simbolo;
            _valor = valor;
        }

        public string Simbolo { get; }

        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;
                _valor = value;
                Notificar();
            }
        }

        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine("Notificando que {0} está recebendo atualizações de {1}", observador.Nome, Simbolo);
        }

        public void Unsubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine("Notificando que {0} Não está recebendo atualizações de {1}", observador.Nome, Simbolo);
        }

        public void Notificar()
        {
            foreach (var investor in _observadores)
            {
                investor.Notificar(this);
            }

            Console.WriteLine("");
        }
    }
}
