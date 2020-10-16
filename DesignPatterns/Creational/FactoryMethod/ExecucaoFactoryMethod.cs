using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sql = DbFactory.Database(DataBase.SQLServer)
                .CreateConnector("conn string")
                .Connect();

            sql.ExecuteCommand("select * from table");
            sql.Dispose();

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            var oracle = DbFactory.Database(DataBase.Oracle)
                .CreateConnector("conn string")
                .Connect();

            oracle.ExecuteCommand("delete from table");
            oracle.Dispose();
        }
    }
}
