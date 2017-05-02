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
    class TipoEquipamentoDAO
    {
        public static void Add(tp_equipamento novoTpEquip, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO tp_equipamento (" + tp_equipamento.CD_TP_EQUIPAMENTO + ", " + tp_equipamento.NM_TP_EQUIPAMENTO + ") "
                 + " values (@" + tp_equipamento.CD_TP_EQUIPAMENTO + ", @" + tp_equipamento.NM_TP_EQUIPAMENTO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_equipamento.CD_TP_EQUIPAMENTO, novoTpEquip.cd_tp_equipamento, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(tp_equipamento.NM_TP_EQUIPAMENTO, novoTpEquip.nm_tp_equipamento, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
