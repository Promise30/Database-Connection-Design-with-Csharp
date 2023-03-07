using System;

namespace Database_Connection_Design_using_Csharp
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string _ConnectionString)
        {

            if (string.IsNullOrEmpty(_ConnectionString))
                throw new ArgumentNullException(nameof(_ConnectionString), "Connection String must be provided");
            this.ConnectionString = _ConnectionString;

        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();


    }
}