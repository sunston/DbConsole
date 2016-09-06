using System;
using System.Data; 

namespace DbConsoleService
{
    public interface IDbConsoleProvider
    {
        IDbConnection OpenConnection(string _ConnectionString);
        IDbCommand CreateCommand(IDbConnection _Connection, string _SQL);
        IDbCommand CreateCommand(IDbConnection _Connection, IDbTransaction _Transaction, string _SQL);
    }

    public class DbConsoleManager
    {
        IDbConnection m_Connection;
        IDbTransaction m_Transaction;
        IDbConsoleProvider m_Provider;

        public DbConsoleManager(IDbConsoleProvider _Provider) { m_Provider = _Provider; }

        public void Open(string _ConnectionString)
        {
            m_Connection = m_Provider.OpenConnection(_ConnectionString);   
            m_Connection.Open();
        }

        public void Close()
        {
            m_Connection.Close();
        }

        public void BeginTransaction()
        {
            m_Transaction = m_Connection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            m_Transaction.Commit();
            m_Transaction = null;
        }

        public void RollbackTransaction()
        {
            m_Transaction.Rollback();
            m_Transaction = null;
        }

        public IDataReader Select(string SQL)
        {
            return this.CreateCommand(SQL).ExecuteReader();
        }

        public int Execute(string SQL)
        {
            return this.CreateCommand(SQL).ExecuteNonQuery();
        }

        private IDbCommand CreateCommand(string _SQL)
        {
            if (m_Transaction == null)
                return m_Provider.CreateCommand(m_Connection, _SQL);

            return m_Provider.CreateCommand(m_Connection, m_Transaction, _SQL);
        }
    }
}
