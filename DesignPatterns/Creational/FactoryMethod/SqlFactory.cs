namespace DesignPatterns.Creational.FactoryMethod
{
    //Concrete Factory
    internal class SqlFactory : DbFactory
    {
        //Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}