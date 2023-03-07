using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection_Design_using_Csharp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            DbCommand dbCommand = new DbCommand(new SqlConnection("SqliteConnectionString"), "Run the Sql query now using Sql Database");
            dbCommand.Execute();

            Console.WriteLine("");

            DbCommand Command = new DbCommand(new OracleConnection("OracleConnectionString"), "Run the Oracle query now using Oracle Database");
            Command.Execute();



            Console.ReadKey();
        }
    }
}
