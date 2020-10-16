using System.Collections.Generic;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
                VeiculoFactory.Criar(Porte.Pequeno, "Celta"),
                VeiculoFactory.Criar(Porte.Medio, "Jetta"),
                VeiculoFactory.Criar(Porte.Grande, "BMW X6"),
            };

            veiculosSocorro.ForEach(veiculo => AutoSocorro.CriarAutoSocorro(veiculo).RealizarAtendimento());
        }
    }
}
