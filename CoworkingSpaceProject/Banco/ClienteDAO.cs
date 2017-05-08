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
    class ClienteDAO
    {
        public static string NOME_TABELA = "cliente";
        public static void Add(cliente novoCliente, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO cliente (" +
                cliente.CD_CLIENTE + ", " +
                "cd_responsavel" + ", " +
                localidade.NR_LOCALIDADE + ", " +
                cliente.NM_CLIENTE + ", " +
                cliente.DS_LOGRADOURO + ", " +
                cliente.DS_COMPLEMENTO + ", " +
                cliente.DS_BAIRRO + ", " +
                cliente.NR_TELEFONE_RES + ", " +
                cliente.NR_TELEFONE_COM + ", " +
                cliente.NR_TELEFONE_CEL + ", " +
                cliente.DS_EMAIL + ") "

                 + " values (@" +
                 cliente.CD_CLIENTE + ", @" +
                "cd_responsavel" + ", @" +
                localidade.NR_LOCALIDADE + ", @" +
                cliente.NM_CLIENTE + ", @" +
                cliente.DS_LOGRADOURO + ", @" +
                cliente.DS_COMPLEMENTO + ", @" +
                cliente.DS_BAIRRO + ", @" +
                cliente.NR_TELEFONE_RES + ", @" +
                cliente.NR_TELEFONE_COM + ", @" +
                cliente.NR_TELEFONE_CEL + ", @" +
                cliente.DS_EMAIL + ") ";

            if (novoCliente.responsavel == null)
            {
                sql = "INSERT INTO cliente (" +
                cliente.CD_CLIENTE + ", " +
                localidade.NR_LOCALIDADE + ", " +
                cliente.NM_CLIENTE + ", " +
                cliente.DS_LOGRADOURO + ", " +
                cliente.DS_COMPLEMENTO + ", " +
                cliente.DS_BAIRRO + ", " +
                cliente.NR_TELEFONE_RES + ", " +
                cliente.NR_TELEFONE_COM + ", " +
                cliente.NR_TELEFONE_CEL + ", " +
                cliente.DS_EMAIL + ") "

                 + " values (@" +
                 cliente.CD_CLIENTE + ", @" +
                localidade.NR_LOCALIDADE + ", @" +
                cliente.NM_CLIENTE + ", @" +
                cliente.DS_LOGRADOURO + ", @" +
                cliente.DS_COMPLEMENTO + ", @" +
                cliente.DS_BAIRRO + ", @" +
                cliente.NR_TELEFONE_RES + ", @" +
                cliente.NR_TELEFONE_COM + ", @" +
                cliente.NR_TELEFONE_CEL + ", @" +
                cliente.DS_EMAIL + ") ";
            }

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(cliente.CD_CLIENTE, novoCliente.cd_cliente, SqlDbType.Int));

            if (novoCliente.responsavel != null)
            {
                cmd.Parameters.Add(BancoUtils.criaParametro<int>("cd_responsavel", novoCliente.responsavel.cd_cliente, SqlDbType.Int));
            }

            cmd.Parameters.Add(BancoUtils.criaParametro<int>(localidade.NR_LOCALIDADE, novoCliente.localidade != null ? novoCliente.localidade.nr_localidade : 0, SqlDbType.Int));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.NM_CLIENTE, novoCliente.nm_cliente, SqlDbType.VarChar));

            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.DS_LOGRADOURO, novoCliente.ds_logradouro, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.DS_COMPLEMENTO, novoCliente.ds_complemento, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.DS_BAIRRO, novoCliente.ds_bairro, SqlDbType.VarChar));

            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.NR_TELEFONE_RES, novoCliente.nr_telefone_res, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.NR_TELEFONE_COM, novoCliente.nr_telefone_com, SqlDbType.VarChar));
            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.NR_TELEFONE_CEL, novoCliente.nr_telefone_cel, SqlDbType.VarChar));

            cmd.Parameters.Add(BancoUtils.criaParametro<string>(cliente.DS_EMAIL, novoCliente.ds_email, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            Debug.Write("Linhas afetadas: " + rowCount);
        }

        internal static List<cliente> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            List<cliente> clientes = new List<cliente>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente cliente = new cliente();

                        cliente.cd_cliente = BancoUtils.buscaValor<int>(cliente.CD_CLIENTE, reader);
                        cliente.localidade = new localidade() { nr_localidade = BancoUtils.buscaValor<int>(localidade.NR_LOCALIDADE, reader) };
                        cliente.responsavel = new cliente() { cd_cliente = BancoUtils.buscaValor<int>("cd_responsavel", reader) };
                        cliente.nm_cliente = BancoUtils.buscaValor<string>(cliente.NM_CLIENTE, reader);

                        cliente.ds_logradouro = BancoUtils.buscaValor<string>(cliente.DS_LOGRADOURO, reader);
                        cliente.ds_complemento = BancoUtils.buscaValor<string>(cliente.DS_COMPLEMENTO, reader);
                        cliente.ds_bairro = BancoUtils.buscaValor<string>(cliente.DS_BAIRRO, reader);
                        
                        cliente.nr_telefone_res = BancoUtils.buscaValor<string>(cliente.NR_TELEFONE_RES, reader);
                        cliente.nr_telefone_com = BancoUtils.buscaValor<string>(cliente.NR_TELEFONE_COM, reader);
                        cliente.nr_telefone_cel = BancoUtils.buscaValor<string>(cliente.NR_TELEFONE_CEL, reader);

                        cliente.ds_email = BancoUtils.buscaValor<string>(cliente.DS_EMAIL, reader);

                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
    }
}
