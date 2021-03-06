﻿using CoworkingSpaceProject.Model;
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

            cmd.Parameters.Add(DBUtils.criaParametro<int>(cliente.CD_CLIENTE, novoCliente.cd_cliente, SqlDbType.Int));

            if (novoCliente.responsavel != null)
            {
                cmd.Parameters.Add(DBUtils.criaParametro<int>("cd_responsavel", novoCliente.responsavel.cd_cliente, SqlDbType.Int));
            }

            cmd.Parameters.Add(DBUtils.criaParametro<int>(localidade.NR_LOCALIDADE, novoCliente.localidade != null ? novoCliente.localidade.nr_localidade : 0, SqlDbType.Int));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.NM_CLIENTE, novoCliente.nm_cliente, SqlDbType.VarChar));

            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.DS_LOGRADOURO, novoCliente.ds_logradouro, SqlDbType.VarChar));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.DS_COMPLEMENTO, novoCliente.ds_complemento, SqlDbType.VarChar));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.DS_BAIRRO, novoCliente.ds_bairro, SqlDbType.VarChar));

            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.NR_TELEFONE_RES, novoCliente.nr_telefone_res, SqlDbType.VarChar));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.NR_TELEFONE_COM, novoCliente.nr_telefone_com, SqlDbType.VarChar));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.NR_TELEFONE_CEL, novoCliente.nr_telefone_cel, SqlDbType.VarChar));

            cmd.Parameters.Add(DBUtils.criaParametro<string>(cliente.DS_EMAIL, novoCliente.ds_email, SqlDbType.VarChar));

            int rowCount = cmd.ExecuteNonQuery();
            AcessoBanco.comandosSqlExecutados += DBUtils.MontaComandoSql(cmd) + "\r\n";

            Debug.Write("Linhas afetadas: " + rowCount);
        }

        internal static List<cliente> Busca(SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            return Le(conexaoSql, sql);
        }

        internal static List<cliente> BuscaClienteSalaDataHora(int sala, DateTime dataHora, SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            sql += " where cd_cliente in ";
            sql += " (select cd_cliente from reserva where '";
            sql += dataHora.ToString("yyyy-MM-ddTHH:mm:ss") + "' between reserva.dt_entrada and reserva.dt_saida ";
            sql += " and reserva.cd_sala = " + sala + ")";

            return Le(conexaoSql, sql);
        }

        private static List<cliente> Le(SqlConnection conexaoSql, string sql)
        {
            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            AcessoBanco.comandosSqlExecutados += sql + "\r\n";

            List<cliente> clientes = new List<cliente>();
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente cliente = new cliente();

                        cliente.cd_cliente = DBUtils.buscaValor<int>(cliente.CD_CLIENTE, reader);
                        cliente.localidade = new localidade() { nr_localidade = DBUtils.buscaValor<int>(localidade.NR_LOCALIDADE, reader) };
                        cliente.responsavel = new cliente() { cd_cliente = DBUtils.buscaValor<int>("cd_responsavel", reader) };
                        cliente.nm_cliente = DBUtils.buscaValor<string>(cliente.NM_CLIENTE, reader);

                        cliente.ds_logradouro = DBUtils.buscaValor<string>(cliente.DS_LOGRADOURO, reader);
                        cliente.ds_complemento = DBUtils.buscaValor<string>(cliente.DS_COMPLEMENTO, reader);
                        cliente.ds_bairro = DBUtils.buscaValor<string>(cliente.DS_BAIRRO, reader);

                        cliente.nr_telefone_res = DBUtils.buscaValor<string>(cliente.NR_TELEFONE_RES, reader);
                        cliente.nr_telefone_com = DBUtils.buscaValor<string>(cliente.NR_TELEFONE_COM, reader);
                        cliente.nr_telefone_cel = DBUtils.buscaValor<string>(cliente.NR_TELEFONE_CEL, reader);

                        cliente.ds_email = DBUtils.buscaValor<string>(cliente.DS_EMAIL, reader);

                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }

        internal static List<cliente> Busca(localidade localidade, SqlConnection conexaoSql)
        {
            string sql = "SELECT * FROM " + NOME_TABELA;
            sql += " where cliente.nr_localidade = ";
            sql += " (select nr_localidade from localidade ";
            sql += " where nm_localidade = '" + localidade.nm_localidade + "') ";

            return Le(conexaoSql, sql);
        }
    }
}
