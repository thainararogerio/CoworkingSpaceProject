﻿using CoworkingSpaceProject.Banco;
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
        public static string comandosSqlExecutados;

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

        internal List<reserva> BuscaReservas()
        {
            return ReservaDAO.Busca(_conexaoSql);
        }

        internal void AddMulta(multa novaMulta = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddMulta(_conexaoSql);
            }
            else
            {
                MultaDAO.Add(novaMulta, _conexaoSql);
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

        
        internal List<equipamento> BuscaEquipamentos()
        {
            return EquipamentoDAO.Busca(_conexaoSql);
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

        internal List<tp_sala> BuscaTiposSala()
        {
            return TipoSalaDAO.Busca(_conexaoSql);
        }

        internal void AddReserva(reserva novaReserva = null)
        {
            if (_debug)
            {
                _preencheBancoUtils.AddReservas(_conexaoSql);
            }
            else
            {
                ReservaDAO.Add(novaReserva, _conexaoSql);
            }
        }

        internal List<sala> BuscaSalas()
        {
            return SalaDAO.Busca(_conexaoSql);
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

        public List<cliente> BuscaClientes()
        {
            return ClienteDAO.Busca(_conexaoSql);
        }
    }
}
