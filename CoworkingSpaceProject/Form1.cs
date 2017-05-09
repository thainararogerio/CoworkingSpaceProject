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
        private static string SEPARADOR_REGISTROS = ";";

        private readonly AcessoBanco _acessoBanco = new AcessoBanco(true);

        public Form1()
        {
            _acessoBanco.IniciaBanco();
            InitializeComponent();
        }

        private void atualizaTextoComandosSQLExecutados()
        {
            txtBox_ComandosSQL.Clear();
            txtBox_ComandosSQL.Text = AcessoBanco.comandosSqlExecutados;
        }

        private void bt_PopulaBanco_Click(object sender, EventArgs e)
        {
            if (_acessoBanco.BuscaEquipamentos().Count > 0)
            {
                MessageBox.Show("Banco já foi populado.");
                return;
            }

            _acessoBanco.AddEquipamento();
            _acessoBanco.AddTipoSala();
            _acessoBanco.AddSala();
            _acessoBanco.AddSalaEquipamento();
            _acessoBanco.AddLocalidade();
            _acessoBanco.AddCliente();
            _acessoBanco.AddReserva();
            _acessoBanco.AddMulta();

            MessageBox.Show("Banco populado com sucesso.");
            atualizaTextoComandosSQLExecutados();
        }

        private void bt_reservas_Click(object sender, EventArgs e)
        {
            List<reserva> reservas = _acessoBanco.BuscaReservas();

            string txt = "";
            foreach (reserva obj in reservas)
            {
                txt += obj.cd_reserva;
                txt += SEPARADOR_REGISTROS;
                txt += obj.cd_sala;
                txt += SEPARADOR_REGISTROS;
                txt += obj.dt_entrada.ToString("dd-MM-yyyy HH:mm:ss");
                txt += "\r\n";
            }

            txtBox_Reservas.Clear();
            txtBox_Reservas.Text = txt;
            atualizaTextoComandosSQLExecutados();
        }

        private void bt_Equipamentos_Click(object sender, EventArgs e)
        {
            List<equipamento> equipamentos = _acessoBanco.BuscaEquipamentos();

            string txt = "";
            foreach (equipamento eq in equipamentos)
            {
                txt += eq.cd_equipamento;
                txt += SEPARADOR_REGISTROS;
                txt += eq.nm_equipamento;
                txt += "\r\n";
            }

            txtBox_Equipamentos.Clear();
            txtBox_Equipamentos.Text = txt;
            atualizaTextoComandosSQLExecutados();
        }

        private void bt_TiposSala_Click(object sender, EventArgs e)
        {
            List<tp_sala> tiposSala = _acessoBanco.BuscaTiposSala();

            string txt = "";
            foreach (tp_sala obj in tiposSala)
            {
                txt += obj.cd_tp_sala;
                txt += SEPARADOR_REGISTROS;
                txt += obj.nm_tp_sala;
                txt += SEPARADOR_REGISTROS;
                txt += obj.tamanho;
                txt += "\r\n";
            }

            txtBox_TiposSala.Clear();
            txtBox_TiposSala.Text = txt;
            atualizaTextoComandosSQLExecutados();
        }

        private void bt_Salas_Click(object sender, EventArgs e)
        {
            List<sala> salas = _acessoBanco.BuscaSalas();

            string txt = "";
            foreach (sala obj in salas)
            {
                txt += obj.cd_sala;
                txt += SEPARADOR_REGISTROS;
                txt += obj.tp_sala.cd_tp_sala;
                txt += SEPARADOR_REGISTROS;
                txt += obj.nm_sala;
                txt += "\r\n";
            }

            txtBox_Salas.Clear();
            txtBox_Salas.Text = txt;
            atualizaTextoComandosSQLExecutados();
        }

        private void bt_Clientes_Click_1(object sender, EventArgs e)
        {
            List<cliente> clientes = _acessoBanco.BuscaClientes();

            string txt = "";
            foreach (cliente obj in clientes)
            {
                txt += obj.cd_cliente;
                txt += SEPARADOR_REGISTROS;
                txt += obj.nm_cliente;
                txt += SEPARADOR_REGISTROS;
                txt += obj.responsavel.cd_cliente;
                txt += "\r\n";
            }

            txtBox_Clientes.Clear();
            txtBox_Clientes.Text = txt;
            atualizaTextoComandosSQLExecutados();
        }
    }
}
