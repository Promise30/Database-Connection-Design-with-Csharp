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
            SqlConnection sqlite = new SqlConnection("SqliteConnectionString");
            sqlite.OpenConnection();
            sqlite.CloseConnection();

            OracleConnection oracleDb = new OracleConnection("OracelDbConnectionString");
            oracleDb.OpenConnection();
            oracleDb.CloseConnection();


            
            Console.ReadKey();
        }
    }
}
