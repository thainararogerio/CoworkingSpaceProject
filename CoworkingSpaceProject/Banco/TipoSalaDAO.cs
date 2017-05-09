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
    class TipoSalaDAO
    {
        public static string NOME_TABELA = "tp_sala";

        public static void Add(tp_sala novoTpSala, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO tp_sala (cd_tp_sala, nm_tp_sala, tamanho) "
                 + " values (@" + tp_sala.CD_TP_SALA + ", @" + tp_sala.NM_TP_SALA + ", @" + tp_sala.TAMANHO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(DBUtils.criaParametro<int>(tp_sala.CD_TP_SALA, novoTpSala.cd_tp_sala, SqlDbType.Int));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(tp_sala.NM_TP_SALA, novoTpSala.nm_tp_sala, SqlDbType.VarChar));
            cmd.Parameters.Add(DBUtils.criaParametro<int>(tp_sala.TAMANHO, novoTpSala.tamanho, SqlDbType.Int));

            int rowCount = cmd.ExecuteNonQuery();
            AcessoBanco.comandosSqlExecutados += DBUtils.MontaComandoSql(cmd) + "\r\n";

            Debug.Write("Linhas afetadas: " + rowCount);
        }

        internal static List<tp_sala> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            List<tp_sala> tiposSala = new List<tp_sala>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        tp_sala tpSala = new tp_sala();

                        tpSala.cd_tp_sala = DBUtils.buscaValor<int>(tp_sala.CD_TP_SALA, reader);
                        tpSala.nm_tp_sala = DBUtils.buscaValor<string>(tp_sala.NM_TP_SALA, reader);
                        tpSala.tamanho = DBUtils.buscaValor<int>(tp_sala.TAMANHO, reader);

                        tiposSala.Add(tpSala);
                    }
                }
            }

            return tiposSala;
        }
    }
}
