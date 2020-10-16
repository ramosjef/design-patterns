namespace DesignPatterns.Creational.AbstractFactory
{
    //Concrete factory
    public class SocorroVeiculoPequenoFactory : AutoSocorroAbstractFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoFactory.Criar(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoFactory.Criar(porte, modelo);
        }
    }
}
