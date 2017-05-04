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
    class TipoEquipamentoDAO
    {
        public static string NOME_TABELA = "tp_equipamento";
        public static void Add(tp_equipamento novoTpEquip, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO " + NOME_TABELA + " (" + tp_equipamento.CD_TP_EQUIPAMENTO + ", " + tp_equipamento.NM_TP_EQUIPAMENTO + ") "
                 + " values (@" + tp_equipamento.CD_TP_EQUIPAMENTO + ", @" + tp_equipamento.NM_TP_EQUIPAMENTO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_equipamento.CD_TP_EQUIPAMENTO, novoTpEquip.cd_tp_equipamento, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(tp_equipamento.NM_TP_EQUIPAMENTO, novoTpEquip.nm_tp_equipamento, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }

        internal static List<tp_equipamento> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            List<tp_equipamento> tiposEquipamento = new List<tp_equipamento>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        tp_equipamento tipoEquip = new tp_equipamento();

                        tipoEquip.cd_tp_equipamento = BancoUtils.buscaValor<int>(tp_equipamento.CD_TP_EQUIPAMENTO, reader);
                        tipoEquip.nm_tp_equipamento = BancoUtils.buscaValor<string>(tp_equipamento.NM_TP_EQUIPAMENTO, reader);

                        tiposEquipamento.Add(tipoEquip);
                    }
                }
            }

            return tiposEquipamento;
        }

        internal static tp_equipamento Busca(int cd_tp_eq, SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA + " WHERE " + tp_equipamento.CD_TP_EQUIPAMENTO + " = @" + tp_equipamento.CD_TP_EQUIPAMENTO;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(tp_equipamento.CD_TP_EQUIPAMENTO, cd_tp_eq, SqlDbType.Int));

            tp_equipamento tipoEquip = new tp_equipamento();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    if (reader.Read())
                    {
                        tipoEquip.cd_tp_equipamento = BancoUtils.buscaValor<int>(tp_equipamento.CD_TP_EQUIPAMENTO, reader);
                        tipoEquip.nm_tp_equipamento = BancoUtils.buscaValor<string>(tp_equipamento.NM_TP_EQUIPAMENTO, reader);
                    }
                }
            }

            return tipoEquip;
        }
    }
}
