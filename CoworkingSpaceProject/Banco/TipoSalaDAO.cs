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
    class TipoSalaDAO
    {
        public static void Add(tp_sala novoTpSala, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO tp_sala (cd_tp_sala, nm_tp_sala, tamanho) "
                 + " values (@" + tp_sala.CD_TP_SALA + ", @" + tp_sala.NM_TP_SALA + ", @" + tp_sala.TAMANHO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_sala.CD_TP_SALA, novoTpSala.cd_tp_sala, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(tp_sala.NM_TP_SALA, novoTpSala.nm_tp_sala, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_sala.TAMANHO, novoTpSala.tamanho, SqlDbType.Int));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
