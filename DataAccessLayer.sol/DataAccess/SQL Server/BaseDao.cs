using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQL_Server
{
    public abstract class BaseDao
    {

        #region Properties
        public string ConnectionString { get; private set; }
        #endregion

        protected BaseDao(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            //Microsoft.Data.SqlClient
            return new SqlConnection(ConnectionString);
        }
    }
}
