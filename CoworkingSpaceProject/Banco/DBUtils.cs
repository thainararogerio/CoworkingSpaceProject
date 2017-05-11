using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CoworkingSpaceProject
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection(string nomeBanco)
        {
            string datasource = @"PCBNU002135\SQLEXPRESS";

            string database = nomeBanco;
            string username = "sa";
            string password = "12345675";

            return GetDBConnection(datasource, database, username, password);
        }

        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

        public static SqlParameter criaParametro<T>(string nome, T valor, SqlDbType tipo)
        {
            SqlParameter param = new SqlParameter("@" + nome, tipo);
            param.Value = valor;
            return param;
        }

        public static T buscaValor<T>(string nomeColuna, DbDataReader reader)
        {
            int idx = reader.GetOrdinal(nomeColuna);
            T valor = !reader.IsDBNull(idx) ? (T)reader.GetValue(idx) : default(T);
            return valor;
        }

        internal static object MontaComandoSql(SqlCommand cmd)
        {
            string query = cmd.CommandText;

            foreach (SqlParameter p in cmd.Parameters)
            {
                query = query.Replace(p.ParameterName, p.Value.ToString());
            }

            return query;
        }
    }

}