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
    class SalaDAO
    {
        public static void Add(sala novaSala, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO sala (" +
                sala.CD_SALA + ", " +
                tp_sala.CD_TP_SALA + ", " +
                sala.NM_SALA + ", " +
                sala.OBSERVACAO + ") "

                 + " values (@" +
                 sala.CD_SALA + ", @" +
                tp_sala.CD_TP_SALA + ", @" +
                sala.NM_SALA + ", @" +
                sala.OBSERVACAO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(sala.CD_SALA, novaSala.cd_sala, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_sala.CD_TP_SALA, novaSala.tp_sala.cd_tp_sala, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(sala.NM_SALA, novaSala.nm_sala, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(sala.OBSERVACAO, novaSala.observacao, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
