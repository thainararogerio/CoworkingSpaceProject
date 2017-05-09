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
    class SalaDAO
    {
        public static string NOME_TABELA = "sala";
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

            cmd.Parameters.Add(DBUtils.criaParametro<int>(sala.CD_SALA, novaSala.cd_sala, SqlDbType.Int));
            cmd.Parameters.Add(DBUtils.criaParametro<int>(tp_sala.CD_TP_SALA, novaSala.tp_sala.cd_tp_sala, SqlDbType.Int));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(sala.NM_SALA, novaSala.nm_sala, SqlDbType.VarChar));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(sala.OBSERVACAO, novaSala.observacao, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            AcessoBanco.comandosSqlExecutados += DBUtils.MontaComandoSql(cmd) + "\r\n";

            Debug.Write("Linhas afetadas: " + rowCount);
        }

        internal static List<sala> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            List<sala> salas = new List<sala>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        sala sala = new sala();

                        sala.cd_sala = DBUtils.buscaValor<int>(sala.CD_SALA, reader);
                        sala.nm_sala = DBUtils.buscaValor<string>(sala.NM_SALA, reader);
                        sala.observacao = DBUtils.buscaValor<string>(sala.OBSERVACAO, reader);
                        sala.tp_sala = new tp_sala() { cd_tp_sala = DBUtils.buscaValor<int>(tp_sala.CD_TP_SALA, reader) };

                        salas.Add(sala);
                    }
                }
            }

            return salas;
        }
    }
}
