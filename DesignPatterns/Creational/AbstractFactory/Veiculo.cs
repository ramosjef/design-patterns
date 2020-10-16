using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    //Abstract Product
    public abstract class Veiculo
    {
        public Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Porte = porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }

    //Concrete Product
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte) { }
    }

    //Concrete Product
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte) { }
    }

    //Concrete Product
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte) { }
    }

    public class VeiculoFactory
    {
        public static Veiculo Criar(Porte porte, string modelo)
        {
            return porte switch
            {
                Porte.Pequeno => new VeiculoPequeno(modelo, porte),
                Porte.Medio => new VeiculoMedio(modelo, porte),
                Porte.Grande => new VeiculoGrande(modelo, porte),
                _ => throw new ApplicationException("Porte de veiculo desconhecido."),
            };
        }
    }
}
