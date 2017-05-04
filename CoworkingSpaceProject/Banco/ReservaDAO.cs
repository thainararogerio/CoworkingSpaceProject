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
    class ReservaDAO
    {
        public static string NOME_TABELA = "reserva";

        public static void Add(reserva novaReserva, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO " + NOME_TABELA + " (cd_reserva, cd_cliente, cd_sala, dt_entrada, dt_saida, vl_reserva, fl_pago) "
                 + " values (@" + reserva.CD_RESERVA + ", @" + reserva.CD_CLIENTE + ", @" + reserva.CD_SALA + ", @" + reserva.DT_ENTRADA + ", @" + 
                 reserva.DT_SAIDA + ", @" + reserva.VL_RESERVA + ", @" + reserva.FL_PAGO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(reserva.CD_RESERVA, novaReserva.cd_reserva, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<int>(reserva.CD_CLIENTE, novaReserva.cd_cliente, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<int>(reserva.CD_SALA, novaReserva.cd_sala, SqlDbType.Int));

            cmd.Parameters.Add(BancoUtils.criaParametro<string>(reserva.DT_ENTRADA, novaReserva.dt_entrada.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(reserva.DT_SAIDA, novaReserva.dt_saida.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime));

            cmd.Parameters.Add(BancoUtils.criaParametro<float>(reserva.VL_RESERVA, novaReserva.vl_reserva, SqlDbType.Float));
            cmd.Parameters.Add(BancoUtils.criaParametro<char>(reserva.FL_PAGO, novaReserva.fl_pago ? '1' : '0', SqlDbType.Char));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}
