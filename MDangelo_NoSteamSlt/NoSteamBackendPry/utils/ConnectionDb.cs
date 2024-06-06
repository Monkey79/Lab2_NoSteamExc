using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSteamBackendPry.utils
{
    internal class ConnectionDb
    {
        public const string UTN_CONN_STRING = @"Data Source=NBCORAR835;Database=EJERCICIOS_UTN;Trusted_Connection=True;";

        private string connQuery;
        private SqlCommand sqlCmd;
        private SqlConnection sqlConn;

        internal ConnectionDb(string connQuery) { 
            this.connQuery = connQuery;
            this.sqlCmd = new SqlCommand();
            this.sqlConn = new SqlConnection(connQuery);

            this.sqlCmd.Connection = this.sqlConn;
            this.sqlCmd.CommandType = System.Data.CommandType.Text;
        }

        internal SqlConnection SqlConn { get => sqlConn;}
        internal string ConnQuery { get => connQuery;}
        internal SqlCommand SqlCmd { get => sqlCmd; }
    }
}
