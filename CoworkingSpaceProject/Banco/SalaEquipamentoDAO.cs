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
    class SalaEquipamentoDAO
    {
        public static void Add(sala_equipamento novoSalaEquipamento, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO sala_equipamento (" + sala.CD_SALA + ", " + equipamento.CD_EQUIPAMENTO + ", " + sala_equipamento.DT_RECEBIDO + ") "
                 + " values (@" + sala.CD_SALA + ", @" + equipamento.CD_EQUIPAMENTO + ", @" + sala_equipamento.DT_RECEBIDO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(sala.CD_SALA, novoSalaEquipamento.sala.cd_sala, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<int>(equipamento.CD_EQUIPAMENTO, novoSalaEquipamento.equipamento.cd_equipamento, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(sala_equipamento.DT_RECEBIDO, novoSalaEquipamento.dt_recebido.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
