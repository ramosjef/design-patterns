namespace DesignPatterns.Creational.AbstractFactory
{
    //Concrete factory
    public class SocorroVeiculoGrandeFactory : AutoSocorroAbstractFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoFactory.Criar(Porte.Grande);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoFactory.Criar(porte, modelo);
        }
    }
}
