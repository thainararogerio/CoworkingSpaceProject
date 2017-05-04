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
    class EquipamentoDAO
    {
        public static string NOME_TABELA = "equipamento";

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

        internal static List<equipamento> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            List<equipamento> equipamentos = new List<equipamento>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        equipamento equip = new equipamento();

                        equip.cd_equipamento = BancoUtils.buscaValor<int>(equipamento.CD_EQUIPAMENTO, reader);
                        equip.serie = BancoUtils.buscaValor<string>(equipamento.SERIE, reader);

                        int cd_tp_eq = BancoUtils.buscaValor<int>(tp_equipamento.CD_TP_EQUIPAMENTO, reader);
                        //equip.tp_equipamento = TipoEquipamentoDAO.Busca(cd_tp_eq, conexaoSql);
                        equip.tp_equipamento = new tp_equipamento() { cd_tp_equipamento = cd_tp_eq };

                        equipamentos.Add(equip);
                    }
                }
            }

            return equipamentos;
        }
    }
}
