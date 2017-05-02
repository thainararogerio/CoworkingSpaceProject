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
            InitializeComponent();
        }

        private void bt_reservas_Click(object sender, EventArgs e)
        {

        }

        private void bt_inicia_Click(object sender, EventArgs e)
        {
            _acessoBanco.IniciaBanco();
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            _acessoBanco.BuscaClientes();
        }

        private void bt_addTipoSala_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddTipoSala();
        }

        private void bt_addTipoEquipamento_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddTipoEquipamento();
        }

        private void bt_addEquipamento_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddEquipamento();
        }

        private void bt_addSala_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddSala();
        }

        private void bt_addSalaEquipamento_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddSalaEquipamento();
        }

        private void bt_addLocalidade_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddLocalidade();
        }

        private void bt_addCliente_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddCliente();
        }

        private void bt_addReserva_Click(object sender, EventArgs e)
        {
            _acessoBanco.AddReserva();
        }
    }
}
