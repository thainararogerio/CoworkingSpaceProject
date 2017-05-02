using CoworkingSpaceProject.Banco;
using CoworkingSpaceProject.Model;
using System;
using System.Data.SqlClient;

namespace CoworkingSpaceProject
{
    internal class PreencheBancoUtils
    {
        internal void AddTiposEquipamentos(SqlConnection conexaoSql)
        {
            tp_equipamento tpEquipamento1 = new tp_equipamento() { cd_tp_equipamento = 1, nm_tp_equipamento = "Projetor" };
            tp_equipamento tpEquipamento2 = new tp_equipamento() { cd_tp_equipamento = 2, nm_tp_equipamento = "Notebook" };
            tp_equipamento tpEquipamento3 = new tp_equipamento() { cd_tp_equipamento = 3, nm_tp_equipamento = "Computador" };
            tp_equipamento tpEquipamento4 = new tp_equipamento() { cd_tp_equipamento = 4, nm_tp_equipamento = "Caixas de som" };
            TipoEquipamentoDAO.Add(tpEquipamento1, conexaoSql);
            TipoEquipamentoDAO.Add(tpEquipamento2, conexaoSql);
            TipoEquipamentoDAO.Add(tpEquipamento3, conexaoSql);
            TipoEquipamentoDAO.Add(tpEquipamento4, conexaoSql);
        }

        internal void AddEquipamentos(SqlConnection conexaoSql)
        {
            equipamento equipamento1 = new equipamento() { cd_equipamento = 1, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 1 }, serie = "PJ1234567" };
            equipamento equipamento2 = new equipamento() { cd_equipamento = 2, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 2 }, serie = "NB1234567" };
            equipamento equipamento3 = new equipamento() { cd_equipamento = 3, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 3 }, serie = "PC1234567" };
            equipamento equipamento4 = new equipamento() { cd_equipamento = 4, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 4 }, serie = "CS1234567" };
            equipamento equipamento5 = new equipamento() { cd_equipamento = 5, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 1 }, serie = "PJ1234568" };
            equipamento equipamento6 = new equipamento() { cd_equipamento = 6, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 2 }, serie = "NB1234568" };
            equipamento equipamento7 = new equipamento() { cd_equipamento = 7, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 3 }, serie = "PC1234568" };
            equipamento equipamento8 = new equipamento() { cd_equipamento = 8, tp_equipamento = new tp_equipamento() { cd_tp_equipamento = 4 }, serie = "CS1234568" };
            EquipamentoDAO.Add(equipamento1, conexaoSql);
            EquipamentoDAO.Add(equipamento2, conexaoSql);
            EquipamentoDAO.Add(equipamento3, conexaoSql);
            EquipamentoDAO.Add(equipamento4, conexaoSql);
            EquipamentoDAO.Add(equipamento5, conexaoSql);
            EquipamentoDAO.Add(equipamento6, conexaoSql);
            EquipamentoDAO.Add(equipamento7, conexaoSql);
            EquipamentoDAO.Add(equipamento8, conexaoSql);
        }

        internal void AddReservas(SqlConnection _conexaoSql)
        {
            reserva 
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
            sala_equipamento salaEquip1 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 1 }, sala = new sala() { cd_sala = 1 } };//projetor
            sala_equipamento salaEquip2 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 2 }, sala = new sala() { cd_sala = 1 } };//notebook
            sala_equipamento salaEquip3 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 6 }, sala = new sala() { cd_sala = 1 } };//notebook
            sala_equipamento salaEquip4 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 3 }, sala = new sala() { cd_sala = 1 } };//pc
            sala_equipamento salaEquip5 = new sala_equipamento() { equipamento = new equipamento() { cd_equipamento = 4 }, sala = new sala() { cd_sala = 1 } };//caixa som
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

        
    }
}