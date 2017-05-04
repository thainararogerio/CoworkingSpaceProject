using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Banco
{
    class BancoUtils
    {
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
    }
}
