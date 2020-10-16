namespace DesignPatterns.Creational.AbstractFactory
{
    //Concrete factory
    public class SocorroVeiculoMedioFactory : AutoSocorroAbstractFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoFactory.Criar(Porte.Medio);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoFactory.Criar(porte, modelo);
        }
    }
}
