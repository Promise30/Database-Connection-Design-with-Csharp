using System;

namespace Database_Connection_Design_using_Csharp
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string _ConnectionString) : base(_ConnectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to the OracleDatabase is now closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection to the OracleDatabase is now open...");
        }

    }
}
