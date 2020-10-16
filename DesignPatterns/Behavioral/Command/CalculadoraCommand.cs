using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class CalculadoraCommand : Commander
    {
        private char _operador;
        private int _valor;
        private readonly Calculadora _calculadora;

        public CalculadoraCommand(
            Calculadora calculadora,
            char operador,
            int valor)
        {
            _calculadora = calculadora;
            _operador = operador;
            _valor = valor;
        }

        public char Operador
        {
            set => _operador = value;
        }

        public int Operando
        {
            set => _valor = value;
        }

        public override void Desfazer()
        {
            _calculadora.Operacao(Desfazer(_operador), _valor);
        }

        public override void Executar()
        {
            _calculadora.Operacao(_operador, _valor);
        }

        private static char Desfazer(char operador)
        {
            return operador switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new ArgumentException("Operador desconhecido"),
            };
        }
    }
}
