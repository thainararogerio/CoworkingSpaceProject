using CoworkingSpaceProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingSpaceProject
{
    public partial class Form1 : Form
    {
        private readonly AcessoBanco _acessoBanco = new AcessoBanco(true);

        public Form1()
        {
            _acessoBanco.IniciaBanco();
            InitializeComponent();
        }

        private void bt_PopulaBanco_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddTipoEquipamento();
            _acessoBanco.AddEquipamento();
            _acessoBanco.AddTipoSala();
            _acessoBanco.AddSala();
            _acessoBanco.AddSalaEquipamento();
            _acessoBanco.AddLocalidade();
            _acessoBanco.AddCliente();
            _acessoBanco.AddReserva();
            _acessoBanco.AddMulta();
        }

        private void bt_reservas_Click(object sender, EventArgs e)
        {

        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_TiposEquipamento_Click(object sender, EventArgs e)
        {
            List<tp_equipamento> tiposEquipamento = _acessoBanco.BuscaTiposEquipamento();

            string txt = "";
            foreach (tp_equipamento tipo in tiposEquipamento)
            {
                txt += tipo.cd_tp_equipamento;
                txt += " - ";
                txt += tipo.nm_tp_equipamento;
                txt += "\r\n";
            }

            txtBox_TiposEquipamentos.Clear();
            txtBox_TiposEquipamentos.Text = txt;
        }

        private void bt_Equipamentos_Click(object sender, EventArgs e)
        {
            List<equipamento> equipamentos = _acessoBanco.BuscaEquipamentos();

            string txt = "";
            foreach (equipamento eq in equipamentos)
            {
                txt += eq.cd_equipamento;
                txt += " - ";
                //txt += eq.tp_equipamento.nm_tp_equipamento;
                txt += eq.tp_equipamento.cd_tp_equipamento;
                txt += " - ";
                txt += eq.serie;
                txt += "\r\n";
            }

            txtBox_Equipamentos.Clear();
            txtBox_Equipamentos.Text = txt;
        }

        private void bt_TiposSala_Click(object sender, EventArgs e)
        {
            List<tp_sala> tiposSala = _acessoBanco.BuscaTiposSala();

            string txt = "";
            foreach (tp_sala obj in tiposSala)
            {
                txt += obj.cd_tp_sala;
                txt += " - ";
                txt += obj.nm_tp_sala;
                txt += " - ";
                txt += obj.tamanho;
                txt += "\r\n";
            }

            txtBox_TiposSala.Clear();
            txtBox_TiposSala.Text = txt;
        }

        private void bt_Salas_Click(object sender, EventArgs e)
        {

        }
    }
}
