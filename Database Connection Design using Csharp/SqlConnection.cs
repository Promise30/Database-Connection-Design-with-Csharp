using System;

namespace Database_Connection_Design_using_Csharp
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string _ConnectionString) : base(_ConnectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection to the SqlDatabase is now closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Connection to the SqlDatabase is now open...");
        }

    }
}
