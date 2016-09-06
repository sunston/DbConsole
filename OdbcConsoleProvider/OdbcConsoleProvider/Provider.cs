using System;
using System.Data.Odbc;
using DbConsoleService; 

namespace OdbcConsoleProvider
{
    public class Provider : DbConsoleService.IDbConsoleProvider
    {
        #region IDbConsoleProvider Members

        public System.Data.IDbCommand CreateCommand(System.Data.IDbConnection _Connection, System.Data.IDbTransaction _Transaction, string _SQL)
        {
            return new OdbcCommand(_SQL, (OdbcConnection)_Connection, (OdbcTransaction)_Transaction);
        }

        public System.Data.IDbCommand CreateCommand(System.Data.IDbConnection _Connection, string _SQL)
        {
            return new OdbcCommand(_SQL, (OdbcConnection)_Connection);
        }

        public System.Data.IDbConnection OpenConnection(string _ConnectionString)
        {
            if (System.IO.File.Exists(_ConnectionString))
                return new OdbcConnection("Driver={Microsoft Access Driver (*.mdb)};DBQ=" + _ConnectionString + ";UID=;PWD=;");
            else
                return new OdbcConnection(_ConnectionString);
        }

        #endregion
    }
}
