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

        internal static List<cliente_reserva> Le(string sql, SqlConnection conexaoSql)
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

            return Le(sql, conexaoSql);
        }
    }
}
