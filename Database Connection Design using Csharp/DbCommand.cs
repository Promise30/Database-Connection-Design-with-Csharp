using System;

namespace Database_Connection_Design_using_Csharp
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (String.IsNullOrEmpty(instruction))
                throw new ArgumentNullException(nameof(instruction), "You must provide an instruction to be executed");
            _dbConnection = dbConnection;
            _instruction = instruction;
        }
        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running the instruction: '{0}'", _instruction);
            _dbConnection.CloseConnection();

        }
    }
}