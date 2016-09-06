using System;
using System.Data.OleDb;  
using DbConsoleService; 

namespace OleDbConsoleProvider
{
    public class Provider : DbConsoleService.IDbConsoleProvider 
    {
        #region IDbConsoleProvider Members

        public System.Data.IDbCommand CreateCommand(System.Data.IDbConnection _Connection, System.Data.IDbTransaction _Transaction, string _SQL)
        {
            return new OleDbCommand(_SQL, (OleDbConnection)_Connection, (OleDbTransaction)_Transaction);   
        }

        public System.Data.IDbCommand CreateCommand(System.Data.IDbConnection _Connection, string _SQL)
        {
            return new OleDbCommand(_SQL, (OleDbConnection)_Connection);
        }

        public System.Data.IDbConnection OpenConnection(string _ConnectionString)
        {
            if (System.IO.File.Exists(_ConnectionString))
                return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _ConnectionString);
            else
                return new OleDbConnection(_ConnectionString);
        }

        #endregion
    }
}
