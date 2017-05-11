using CoworkingSpaceProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject.Banco
{
    class DAOGenerico
    {
        internal class cliente_reserva
        {
            public string nm_cliente { get; set; }
            public float vl_reserva { get; set; }
        }

        internal static List<cliente_reserva> LeClienteReserva(string sql, SqlConnection conexaoSql)
        {
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            AcessoBanco.comandosSqlExecutados += sql + "\r\n";

            List<cliente_reserva> lista = new List<cliente_reserva>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cliente_reserva cr = new cliente_reserva();

                        cr.nm_cliente = DBUtils.buscaValor<string>(cliente.NM_CLIENTE, reader);
                        int idx = reader.GetOrdinal(reserva.VL_RESERVA);
                        var vl_reserva = reader.GetDecimal(idx);
                        cr.vl_reserva = float.Parse(vl_reserva.ToString());

                        lista.Add(cr);
                    }
                }
            }

            return lista;
        }

        internal static List<cliente_reserva> BuscaReservasAgrupCliente(reserva reserva, SortOrder order, SqlConnection conexaoSql)
        {
            string sql = " select cliente.nm_cliente, reserva.vl_reserva ";
            sql += " from cliente, reserva ";
            sql += " group by cliente.nm_cliente, reserva.cd_cliente, cliente.cd_cliente, reserva.vl_reserva, reserva.fl_pago ";
            sql += " having cliente.cd_cliente = reserva.cd_cliente ";
            sql += " and reserva.fl_pago = " + (reserva.fl_pago ? "1" : "0");
            sql += " order by reserva.vl_reserva " + (order == SortOrder.Ascending ? "asc" : "desc");

            return LeClienteReserva(sql, conexaoSql);
        }

        internal static List<reserva_multa> BuscaReservasMultaNaoPaga(SqlConnection conexaoSql)
        {
            string sql = "select reserva.cd_cliente, reserva.cd_sala, reserva.dt_entrada, reserva.vl_reserva, multa.vl_multa ";
            sql += " from reserva, multa ";
            sql += " where reserva.cd_reserva  in ";
            sql += " (select cd_reserva from multa ";
            sql +=  " where dt_pagto is null) ";

            return LeReservaMulta(sql, conexaoSql);
        }

        private static List<reserva_multa> LeReservaMulta(string sql, SqlConnection conexaoSql)
        {
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            AcessoBanco.comandosSqlExecutados += sql + "\r\n";

            List<reserva_multa> lista = new List<reserva_multa>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        reserva_multa cr = new reserva_multa();

                        cr.cd_cliente = DBUtils.buscaValor<int>(cliente.CD_CLIENTE, reader);
                        cr.cd_sala = DBUtils.buscaValor<int>(sala.CD_SALA, reader);
                        cr.dt_entrada = DBUtils.buscaValor<DateTime>(reserva.DT_ENTRADA, reader);

                        int idx = reader.GetOrdinal(multa.VL_MULTA);
                        var vl = reader.GetDecimal(idx);
                        cr.vl_multa = float.Parse(vl.ToString());

                        idx = reader.GetOrdinal(reserva.VL_RESERVA);
                        vl = reader.GetDecimal(idx);
                        cr.vl_reserva = float.Parse(vl.ToString());
                        
                        lista.Add(cr);
                    }
                }
            }

            return lista;
        }

        internal class reserva_multa
        {
            public int cd_cliente { get; set; }
            public int cd_sala { get; set; }
            public DateTime dt_entrada { get; set; }
            public float vl_reserva { get; set; }
            public float vl_multa { get; set; }
        }

        internal static List<cliente_multa> BuscaClienteMultaTotalPagar(SqlConnection conexaoSql)
        {
            string sql = "select cd_cliente, reserva.cd_reserva, SUM(vl_multa) as Total ";
            sql += " from reserva, multa ";
            sql += " group by cd_cliente, reserva.cd_reserva, multa.cd_reserva, dt_pagto ";
            sql += " having dt_pagto is null ";
            sql += " and reserva.cd_reserva = multa.cd_reserva ";

            return LeClienteMulta(sql, conexaoSql);
        }

        private static List<cliente_multa> LeClienteMulta(string sql, SqlConnection conexaoSql)
        {
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            AcessoBanco.comandosSqlExecutados += sql + "\r\n";

            List<cliente_multa> lista = new List<cliente_multa>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        cliente_multa cm = new cliente_multa();

                        cm.cd_cliente = DBUtils.buscaValor<int>(cliente.CD_CLIENTE, reader);
                        cm.cd_reserva = DBUtils.buscaValor<int>(reserva.CD_RESERVA, reader);

                        int idx = reader.GetOrdinal("Total");
                        var vl = reader.GetDecimal(idx);
                        cm.vl_total = float.Parse(vl.ToString());

                        lista.Add(cm);
                    }
                }
            }

            return lista;

        }

        internal class cliente_multa
        {
            public int cd_cliente { get; set; }
            public int cd_reserva { get; set; }
            public float vl_total { get; set; }
        }
    }
}
