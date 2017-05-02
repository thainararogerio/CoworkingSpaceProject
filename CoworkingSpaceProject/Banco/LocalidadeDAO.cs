using CoworkingSpaceProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Banco
{
    class LocalidadeDAO
    {
        public static void Add(localidade novaLocalidade, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO localidade (" + localidade.NR_LOCALIDADE + ", " + localidade.NM_LOCALIDADE + ", " + localidade.SG_UF + ") "
                 + " values (@" + localidade.NR_LOCALIDADE + ", @" + localidade.NM_LOCALIDADE + ", @" + localidade.SG_UF + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(localidade.NR_LOCALIDADE, novaLocalidade.nr_localidade, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(localidade.NM_LOCALIDADE, novaLocalidade.nm_localidade, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(localidade.SG_UF, novaLocalidade.sg_uf, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
