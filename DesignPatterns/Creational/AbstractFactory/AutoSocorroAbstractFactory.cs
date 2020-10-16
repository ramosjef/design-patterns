namespace DesignPatterns.Creational.AbstractFactory
{
    //Abstract Factory
    public abstract class AutoSocorroAbstractFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
