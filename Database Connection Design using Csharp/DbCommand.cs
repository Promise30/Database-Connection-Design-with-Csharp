using System;

namespace Database_Connection_Design_using_Csharp
{
    public class DbCommand   
    {
        
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (_dbConnection == null)
                throw new ArgumentNullException(nameof(_dbConnection), "Connection to the provided to the database");

            else if (string.IsNullOrEmpty(instruction))
                throw new ArgumentNullException(nameof(_instruction), "An instruction needs to be provided");
            else
                _dbConnection = dbConnection;
                _instruction= instruction;
        }
        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running the instruction...");
            _dbConnection.CloseConnection();

        }
    }
}