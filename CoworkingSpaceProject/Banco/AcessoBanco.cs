using CoworkingSpaceProject.Banco;
using CoworkingSpaceProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoworkingSpaceProject
{
    class AcessoBanco
    {
        private readonly SqlConnection _conexaoSql = DBUtils.GetDBConnection();
        private bool _debug;
        private PreencheBancoUtils _preencheBancoUtils = new PreencheBancoUtils();

        public AcessoBanco(bool debug)
        {
            _debug = debug;
        }

        public void IniciaBanco()
        {
            try
            {
                _conexaoSql.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: " + ex.Message);
            }
        }

        public void AddTipoSala(tp_sala novoTpSala = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddTiposSalas(_conexaoSql);
            }
            else
            {
                TipoSalaDAO.Add(novoTpSala, _conexaoSql);
            }
        }

        internal void AddTipoEquipamento(tp_equipamento novoTpEquip = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddTiposEquipamentos(_conexaoSql);
            }
            else
            {
                TipoEquipamentoDAO.Add(novoTpEquip, _conexaoSql);
            }
        }

        internal void AddSalaEquipamento(sala_equipamento novaSalaEquip = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddSalaEquipamentos(_conexaoSql);
            }
            else
            {
                SalaEquipamentoDAO.Add(novaSalaEquip, _conexaoSql);
            }
        }

        internal void AddCliente(cliente novoCliente = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddClientes(_conexaoSql);
            }
            else
            {
                ClienteDAO.Add(novoCliente, _conexaoSql);
            }
        }

        internal void AddReserva()
        {
            if (_debug)
            {
                _preencheBancoUtils.AddReservas(_conexaoSql);
            }
            else
            {
                LocalidadeDAO.Add(novaLoc, _conexaoSql);
            }
        }

        internal void AddLocalidade(localidade novaLoc = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddLocalidades(_conexaoSql);
            }
            else
            {
                LocalidadeDAO.Add(novaLoc, _conexaoSql);
            }
        }

        internal void AddSala(sala novaSala = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddSalas(_conexaoSql);
            }
            else
            {
                SalaDAO.Add(novaSala, _conexaoSql);
            }
        }

        internal void AddEquipamento(equipamento novoEquip = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddEquipamentos(_conexaoSql);
            }
            else
            {
                EquipamentoDAO.Add(novoEquip, _conexaoSql);
            }
        }

        public void BuscaClientes()
        {
            string sql = "SELECT * FROM cliente";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexaoSql;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        int cd_clienteIndex = reader.GetOrdinal("cd_cliente"); // 0
                        long cd_cliente = Convert.ToInt64(reader.GetValue(cd_clienteIndex));

                        int nm_clienteIndex = reader.GetOrdinal("nm_cliente");// 2
                        string nm_cliente = reader.GetString(nm_clienteIndex);

                        int nr_telefoneIndex = reader.GetOrdinal("nr_telefone");
                        string nr_telefone = reader.GetString(nr_telefoneIndex);

                        int enderecoIndex = reader.GetOrdinal("endereco");
                        string endereco = reader.GetString(enderecoIndex);

                        Debug.WriteLine("--------------------");
                        Debug.WriteLine("cd_clienteIndex:" + cd_clienteIndex);
                        Debug.WriteLine("cd_cliente:" + cd_cliente);
                        Debug.WriteLine("nm_cliente:" + nm_cliente);
                        Debug.WriteLine("nr_telefone:" + nr_telefone);
                        Debug.WriteLine("endereco:" + endereco);
                    }
                }
            }
        }
    }
}
