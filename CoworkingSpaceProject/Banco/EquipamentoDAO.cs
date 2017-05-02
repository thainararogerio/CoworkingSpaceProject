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
    class EquipamentoDAO
    {
        public static void Add(equipamento novoEquip, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO equipamento (" + equipamento.CD_EQUIPAMENTO + ", " + tp_equipamento.CD_TP_EQUIPAMENTO + ", " + equipamento.SERIE + ") "
                 + " values (@" + equipamento.CD_EQUIPAMENTO + ", @" + tp_equipamento.CD_TP_EQUIPAMENTO + ", @" + equipamento.SERIE + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(equipamento.CD_EQUIPAMENTO, novoEquip.cd_equipamento, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_equipamento.CD_TP_EQUIPAMENTO, novoEquip.tp_equipamento.cd_tp_equipamento, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(equipamento.SERIE, novoEquip.serie, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
