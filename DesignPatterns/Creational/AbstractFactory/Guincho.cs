using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //Abstract Product
    public abstract class Guincho
    {
        public Guincho(Porte porte)
        {
            Porte = porte;
        }
        public Porte Porte { get; set; }
        public abstract void Socorrer(Veiculo veiculo);
    }

    //Concrete Product
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo carro pequeno - Modelo {0}", veiculo.Modelo);
        }
    }

    //Concrete Product
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo carro medio - Modelo {0}", veiculo.Modelo);
        }
    }

    //Concrete Product
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo carro grande - Modelo {0}", veiculo.Modelo);
        }
    }

    public class GuinchoFactory
    {
        public static Guincho Criar(Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new GuinchoPequeno(porte),
                Porte.Medio => new GuinchoMedio(porte),
                Porte.Grande => new GuinchoGrande(porte),
                _ => throw new ApplicationException("Porte de guincho desconhecido."),
            };
        }
    }
}
