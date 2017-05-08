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
            string sql = "INSERT INTO equipamento (" + equipamento.CD_EQUIPAMENTO + ", " + equipamento.NM_EQUIPAMENTO + ") "
                 + " values (@" + equipamento.CD_EQUIPAMENTO + ", @" + equipamento.NM_EQUIPAMENTO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(equipamento.CD_EQUIPAMENTO, novoEquip.cd_equipamento, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(equipamento.NM_EQUIPAMENTO, novoEquip.nm_equipamento, SqlDbType.VarChar));

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
                        equip.nm_equipamento = BancoUtils.buscaValor<string>(equipamento.NM_EQUIPAMENTO, reader);

                        equipamentos.Add(equip);
                    }
                }
            }

            return equipamentos;
        }
    }
}
