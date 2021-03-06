﻿using CoworkingSpaceProject.Banco;
using CoworkingSpaceProject.Model;
using System;
using System.Data.SqlClient;

namespace CoworkingSpaceProject
{
    internal class PreencheBancoUtils
    {
        internal void AddEquipamentos(SqlConnection conexaoSql)
        {
            equipamento equipamento1 = new equipamento() { cd_equipamento = 1, nm_equipamento = "Projetor" };
            equipamento equipamento2 = new equipamento() { cd_equipamento = 2, nm_equipamento = "Notebook" };
            equipamento equipamento3 = new equipamento() { cd_equipamento = 3, nm_equipamento = "Caixa de Som" };
            equipamento equipamento4 = new equipamento() { cd_equipamento = 4, nm_equipamento = "Computador" };
            EquipamentoDAO.Add(equipamento1, conexaoSql);
            EquipamentoDAO.Add(equipamento2, conexaoSql);
            EquipamentoDAO.Add(equipamento3, conexaoSql);
            EquipamentoDAO.Add(equipamento4, conexaoSql);
        }

        
        internal void AddTiposSalas(SqlConnection conexaoSql)
        {
            tp_sala tpSala1 = new tp_sala() { cd_tp_sala = 1, nm_tp_sala = "Sala 1", tamanho = 1 };
            tp_sala tpSala2 = new tp_sala() { cd_tp_sala = 2, nm_tp_sala = "Sala 2", tamanho = 2 };
            tp_sala tpSala3 = new tp_sala() { cd_tp_sala = 3, nm_tp_sala = "Sala 3", tamanho = 3 };
            tp_sala tpSala4 = new tp_sala() { cd_tp_sala = 4, nm_tp_sala = "Sala 4", tamanho = 4 };
            TipoSalaDAO.Add(tpSala1, conexaoSql);
            TipoSalaDAO.Add(tpSala2, conexaoSql);
            TipoSalaDAO.Add(tpSala3, conexaoSql);
            TipoSalaDAO.Add(tpSala4, conexaoSql);
        }

        internal void AddSalas(SqlConnection conexaoSql)
        {
            sala sala1 = new sala() { cd_sala = 1, nm_sala = "Sala 1", tp_sala = new tp_sala() { cd_tp_sala = 1 }, observacao = "tem vista para rua" };
            sala sala2 = new sala() { cd_sala = 2, nm_sala = "Sala 2", tp_sala = new tp_sala() { cd_tp_sala = 2 }, observacao = "possui lixeira" };
            sala sala3 = new sala() { cd_sala = 3, nm_sala = "Sala 3", tp_sala = new tp_sala() { cd_tp_sala = 3 }, observacao = "voltada para lateral do espaço" };
            sala sala4 = new sala() { cd_sala = 4, nm_sala = "Sala 4", tp_sala = new tp_sala() { cd_tp_sala = 4 }, observacao = "nos fundos" };
            SalaDAO.Add(sala1, conexaoSql);
            SalaDAO.Add(sala2, conexaoSql);
            SalaDAO.Add(sala3, conexaoSql);
            SalaDAO.Add(sala4, conexaoSql);
        }

        internal void AddSalaEquipamentos(SqlConnection conexaoSql)
        {
            //sala 1 - 1 projetor, 2 notebooks, 1 pc e 1 conjunto de caixas de som.
            sala_equipamento salaEquip1 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 1 }, sala = new sala() { cd_sala = 1 }, dt_recebido = new DateTime(2017, 01, 03, 01, 00, 00) };//projetor
            sala_equipamento salaEquip2 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 2 }, sala = new sala() { cd_sala = 1 }, dt_recebido = new DateTime(2017, 02, 03, 02, 00, 00) };//notebook
            sala_equipamento salaEquip3 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 3 }, sala = new sala() { cd_sala = 1 }, dt_recebido = new DateTime(2017, 03, 03, 03, 00, 00) };//notebook
            sala_equipamento salaEquip4 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 4 }, sala = new sala() { cd_sala = 1 }, dt_recebido = new DateTime(2017, 04, 03, 04, 00, 00) };//pc
            sala_equipamento salaEquip5 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 1 }, sala = new sala() { cd_sala = 2 }, dt_recebido = new DateTime(2017, 05, 03, 05, 00, 00) };//caixa som
            SalaEquipamentoDAO.Add(salaEquip1, conexaoSql);
            SalaEquipamentoDAO.Add(salaEquip2, conexaoSql);
            SalaEquipamentoDAO.Add(salaEquip3, conexaoSql);
            SalaEquipamentoDAO.Add(salaEquip4, conexaoSql);
            SalaEquipamentoDAO.Add(salaEquip5, conexaoSql);
        }

        internal void AddLocalidades(SqlConnection conexaoSql)
        {
            localidade local1 = new localidade() { nr_localidade = 1, nm_localidade = "Localidade 1", sg_uf = "SC" };
            localidade local2 = new localidade() { nr_localidade = 2, nm_localidade = "Localidade 2", sg_uf = "PR" };
            localidade local3 = new localidade() { nr_localidade = 3, nm_localidade = "Localidade 3", sg_uf = "PN" };
            localidade local4 = new localidade() { nr_localidade = 4, nm_localidade = "Localidade 4", sg_uf = "DF" };
            LocalidadeDAO.Add(local1, conexaoSql);
            LocalidadeDAO.Add(local2, conexaoSql);
            LocalidadeDAO.Add(local3, conexaoSql);
            LocalidadeDAO.Add(local4, conexaoSql);
        }

        internal void AddClientes(SqlConnection conexaoSql)
        {
            localidade local1 = new localidade() { nr_localidade = 1 };
            localidade local2 = new localidade() { nr_localidade = 2 };
            localidade local3 = new localidade() { nr_localidade = 3 };
            localidade local4 = new localidade() { nr_localidade = 4 };

            cliente chefe1 = new cliente { cd_cliente = 1, localidade = local1, nm_cliente = "Chefe 1", ds_logradouro = "Log. Chefe 1", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente empregado1 = new cliente { cd_cliente = 2, responsavel = chefe1, localidade = local2, nm_cliente = "Empregado 1.1", ds_logradouro = "Log. Emp. 1.1", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };

            cliente autonomo1 = new cliente { cd_cliente = 3, localidade = local3, nm_cliente = "Autonomo 1", ds_logradouro = "Log. Auton. 1", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente autonomo2 = new cliente { cd_cliente = 4, localidade = local4, nm_cliente = "Autonomo 2", ds_logradouro = "Log. Auton. 2", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente autonomo3 = new cliente { cd_cliente = 5, localidade = local1, nm_cliente = "Autonomo 3", ds_logradouro = "Log. Auton. 3", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente autonomo4 = new cliente { cd_cliente = 6, localidade = local2, nm_cliente = "Autonomo 4", ds_logradouro = "Log. Auton. 4", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente autonomo5 = new cliente { cd_cliente = 7, localidade = local3, nm_cliente = "Autonomo 5", ds_logradouro = "Log. Auton. 5", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };

            cliente chefe2 = new cliente { cd_cliente = 8, localidade = local4, nm_cliente = "Chefe 2", ds_logradouro = "Log. Chefe 2", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente empregado1do2 = new cliente { cd_cliente = 9, responsavel = chefe2, localidade = local3, nm_cliente = "Empregado 2.1", ds_logradouro = "Log. Emp. 2.1", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };
            cliente empregado2do2 = new cliente { cd_cliente = 10, responsavel = chefe2, localidade = local4, nm_cliente = "Empregado 2.2", ds_logradouro = "Log. Emp. 2.2", ds_bairro = "", ds_complemento = "", ds_email = "", nr_telefone_cel = "", nr_telefone_com = "", nr_telefone_res = "" };

            ClienteDAO.Add(chefe1, conexaoSql);
            ClienteDAO.Add(empregado1, conexaoSql);
            ClienteDAO.Add(autonomo1, conexaoSql);
            ClienteDAO.Add(autonomo2, conexaoSql);
            ClienteDAO.Add(autonomo3, conexaoSql);
            ClienteDAO.Add(autonomo4, conexaoSql);
            ClienteDAO.Add(autonomo5, conexaoSql);
            ClienteDAO.Add(chefe2, conexaoSql);
            ClienteDAO.Add(empregado1do2, conexaoSql);
            ClienteDAO.Add(empregado2do2, conexaoSql);
        }                  

        internal void AddReservas(SqlConnection conexaoSql)
        {
            reserva reserva1 = new reserva() { cd_cliente = 1, cd_reserva = 1, cd_sala = 1, dt_entrada = 
                new DateTime(2017, 01, 01, 01, 00, 00), dt_saida = new DateTime(2017, 01, 01, 23, 00, 00), fl_pago = true, vl_reserva = 10.0F };
            reserva reserva2 = new reserva() { cd_cliente = 2, cd_reserva = 2, cd_sala = 2, dt_entrada = 
                new DateTime(2017, 01, 02, 01, 00, 00), dt_saida = new DateTime(2017, 01, 02, 23, 00, 00), fl_pago = true, vl_reserva = 10.0F };
            reserva reserva3 = new reserva() { cd_cliente = 3, cd_reserva = 3, cd_sala = 3, dt_entrada = 
                new DateTime(2017, 01, 03, 01, 00, 00), dt_saida = new DateTime(2017, 01, 03, 23, 00, 00), fl_pago = false, vl_reserva = 10.0F };
            reserva reserva4 = new reserva() { cd_cliente = 1, cd_reserva = 4, cd_sala = 1, dt_entrada = 
                new DateTime(2016, 01, 01, 13, 00, 00), dt_saida = new DateTime(2016, 01, 01, 17, 00, 00), fl_pago = false, vl_reserva = 6.0F };
            reserva reserva5 = new reserva() { cd_cliente = 2, cd_reserva = 5, cd_sala = 2, dt_entrada = 
                new DateTime(2016, 01, 02, 14, 00, 00), dt_saida = new DateTime(2016, 01, 02, 20, 00, 00), fl_pago = false, vl_reserva = 7.0F };
            reserva reserva6 = new reserva() { cd_cliente = 3, cd_reserva = 6, cd_sala = 3, dt_entrada = 
                new DateTime(2016, 01, 03, 15, 00, 00), dt_saida = new DateTime(2016, 01, 03, 18, 00, 00), fl_pago = false, vl_reserva = 8.0F };

            ReservaDAO.Add(reserva1, conexaoSql);
            ReservaDAO.Add(reserva2, conexaoSql);
            ReservaDAO.Add(reserva3, conexaoSql);
            ReservaDAO.Add(reserva4, conexaoSql);
            ReservaDAO.Add(reserva5, conexaoSql);
            ReservaDAO.Add(reserva6, conexaoSql);
        }

        internal void AddMulta(SqlConnection conexaoSql)
        {
            multa multa1 = new multa() { cd_multa = 1, cd_reserva = 1, dt_pagto = new DateTime(2017, 02, 01, 12, 00, 00), vl_multa = 5.0F };
            multa multa2 = new multa() { cd_multa = 2, cd_reserva = 2, dt_pagto = new DateTime(2017, 03, 01, 13, 00, 00), vl_multa = 15.0F };
            multa multa3 = new multa() { cd_multa = 3, cd_reserva = 3, dt_pagto = DateTime.MaxValue, vl_multa = 20.0F };
            multa multa4 = new multa() { cd_multa = 4, cd_reserva = 4, dt_pagto = DateTime.MaxValue, vl_multa = 10.0F };

            MultaDAO.Add(multa1, conexaoSql);
            MultaDAO.Add(multa2, conexaoSql);
            MultaDAO.Add(multa3, conexaoSql);
            MultaDAO.Add(multa4, conexaoSql);
        }
    }
}