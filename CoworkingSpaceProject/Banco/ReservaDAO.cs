using CoworkingSpaceProject.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

        internal static List<reserva> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            List<reserva> reservas = new List<reserva>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        reserva reserva = new reserva();

                        reserva.cd_reserva = BancoUtils.buscaValor<int>(reserva.CD_RESERVA, reader);
                        reserva.cd_cliente = BancoUtils.buscaValor<int>(reserva.CD_CLIENTE, reader);
                        reserva.cd_sala = BancoUtils.buscaValor<int>(reserva.CD_SALA, reader);
                        reserva.dt_entrada = BancoUtils.buscaValor<DateTime>(reserva.DT_ENTRADA, reader);
                        reserva.dt_saida = BancoUtils.buscaValor<DateTime>(reserva.DT_SAIDA, reader);

                        int idx = reader.GetOrdinal(reserva.VL_RESERVA);
                        var vl_reserva = reader.GetDecimal(idx);
                        reserva.vl_reserva = float.Parse(vl_reserva.ToString());

                        idx = reader.GetOrdinal(reserva.FL_PAGO);
                        var flpago = reader.GetValue(idx);
                        reserva.fl_pago = (string)flpago == "1";

                        reservas.Add(reserva);
                    }
                }
            }

            return reservas;
        }
    }
}
