using System;
using System.Data.SqlClient;
using DbConsoleService; 

namespace SqlConsoleProvider
{
    public class Provider : DbConsoleService.IDbConsoleProvider
    {
        #region IDbConsoleProvider Members

        public System.Data.IDbCommand CreateCommand(System.Data.IDbConnection _Connection, System.Data.IDbTransaction _Transaction, string _SQL)
        {
            return new SqlCommand(_SQL, (SqlConnection)_Connection, (SqlTransaction)_Transaction);
        }

        public System.Data.IDbCommand CreateCommand(System.Data.IDbConnection _Connection, string _SQL)
        {
            return new SqlCommand(_SQL, (SqlConnection)_Connection);
        }

        public System.Data.IDbConnection OpenConnection(string _ConnectionString)
        {
            return new SqlConnection(_ConnectionString);
        }

        #endregion
    }
}
