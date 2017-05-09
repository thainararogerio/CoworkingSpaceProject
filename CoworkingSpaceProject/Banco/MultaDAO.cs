using CoworkingSpaceProject.Model;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace CoworkingSpaceProject.Banco
{
    class MultaDAO
    {
        public static void Add(multa novaMulta, SqlConnection conexaoSql)
        {
            string sql = "INSERT INTO multa (cd_multa, cd_reserva, vl_multa, dt_pagto) "
                 + " values (@" + multa.CD_MULTA+ ", @" + multa.CD_RESERVA+ ", @" + multa.VL_MULTA + ", @" + multa.DT_PAGTO + ") ";

            SqlCommand cmd = conexaoSql.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add(DBUtils.criaParametro<int>(multa.CD_MULTA, novaMulta.cd_multa, SqlDbType.Int));
            cmd.Parameters.Add(DBUtils.criaParametro<int>(multa.CD_RESERVA, novaMulta.cd_reserva, SqlDbType.Int));
            cmd.Parameters.Add(DBUtils.criaParametro<float>(multa.VL_MULTA, novaMulta.vl_multa, SqlDbType.Float));
            cmd.Parameters.Add(DBUtils.criaParametro<string>(multa.DT_PAGTO, novaMulta.dt_pagto.ToString("yyyy-MM-ddTHH:mm:ss"), SqlDbType.DateTime));

            int rowCount = cmd.ExecuteNonQuery();
            AcessoBanco.comandosSqlExecutados += DBUtils.MontaComandoSql(cmd) + "\r\n";

            Debug.Write("Linhas afetadas: " + rowCount);
        }
    }
}