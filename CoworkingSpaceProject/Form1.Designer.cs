namespace CoworkingSpaceProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_Reservas = new System.Windows.Forms.Button();
            this.bt_Salas = new System.Windows.Forms.Button();
            this.bt_Equipamentos = new System.Windows.Forms.Button();
            this.bt_PopulaBanco = new System.Windows.Forms.Button();
            this.bt_TiposSala = new System.Windows.Forms.Button();
            this.bt_Clientes = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBox_Equipamentos = new System.Windows.Forms.TextBox();
            this.txtBox_TiposSala = new System.Windows.Forms.TextBox();
            this.txtBox_Salas = new System.Windows.Forms.TextBox();
            this.txtBox_Clientes = new System.Windows.Forms.TextBox();
            this.txtBox_Reservas = new System.Windows.Forms.TextBox();
            this.txtBox_ComandosSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ReservasSalaDataHora = new System.Windows.Forms.Button();
            this.bt_SalasLivresDataHora = new System.Windows.Forms.Button();
            this.bt_SalasComEquipamento = new System.Windows.Forms.Button();
            this.bt_clientesNaSalaEm = new System.Windows.Forms.Button();
            this.bt_ReservasCliente = new System.Windows.Forms.Button();
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Reservas
            // 
            this.bt_Reservas.Location = new System.Drawing.Point(189, 185);
            this.bt_Reservas.Name = "bt_Reservas";
            this.bt_Reservas.Size = new System.Drawing.Size(130, 23);
            this.bt_Reservas.TabIndex = 0;
            this.bt_Reservas.Text = "Reservas";
            this.bt_Reservas.UseVisualStyleBackColor = true;
            this.bt_Reservas.Click += new System.EventHandler(this.bt_reservas_Click);
            // 
            // bt_Salas
            // 
            this.bt_Salas.Location = new System.Drawing.Point(366, 11);
            this.bt_Salas.Name = "bt_Salas";
            this.bt_Salas.Size = new System.Drawing.Size(130, 23);
            this.bt_Salas.TabIndex = 1;
            this.bt_Salas.Text = "Salas";
            this.bt_Salas.UseVisualStyleBackColor = true;
            this.bt_Salas.Click += new System.EventHandler(this.bt_Salas_Click);
            // 
            // bt_Equipamentos
            // 
            this.bt_Equipamentos.Location = new System.Drawing.Point(12, 11);
            this.bt_Equipamentos.Name = "bt_Equipamentos";
            this.bt_Equipamentos.Size = new System.Drawing.Size(130, 23);
            this.bt_Equipamentos.TabIndex = 3;
            this.bt_Equipamentos.Text = "Equipamentos";
            this.bt_Equipamentos.UseVisualStyleBackColor = true;
            this.bt_Equipamentos.Click += new System.EventHandler(this.bt_Equipamentos_Click);
            // 
            // bt_PopulaBanco
            // 
            this.bt_PopulaBanco.Location = new System.Drawing.Point(422, 329);
            this.bt_PopulaBanco.Name = "bt_PopulaBanco";
            this.bt_PopulaBanco.Size = new System.Drawing.Size(115, 23);
            this.bt_PopulaBanco.TabIndex = 13;
            this.bt_PopulaBanco.Text = "Popula banco";
            this.bt_PopulaBanco.UseVisualStyleBackColor = true;
            this.bt_PopulaBanco.Click += new System.EventHandler(this.bt_PopulaBanco_Click);
            // 
            // bt_TiposSala
            // 
            this.bt_TiposSala.Location = new System.Drawing.Point(189, 11);
            this.bt_TiposSala.Name = "bt_TiposSala";
            this.bt_TiposSala.Size = new System.Drawing.Size(130, 23);
            this.bt_TiposSala.TabIndex = 15;
            this.bt_TiposSala.Text = "Tipos de sala";
            this.bt_TiposSala.UseVisualStyleBackColor = true;
            this.bt_TiposSala.Click += new System.EventHandler(this.bt_TiposSala_Click);
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.Location = new System.Drawing.Point(12, 185);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(130, 23);
            this.bt_Clientes.TabIndex = 16;
            this.bt_Clientes.Text = "Clientes";
            this.bt_Clientes.UseVisualStyleBackColor = true;
            this.bt_Clientes.Click += new System.EventHandler(this.bt_Clientes_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBox_Equipamentos
            // 
            this.txtBox_Equipamentos.Enabled = false;
            this.txtBox_Equipamentos.Location = new System.Drawing.Point(12, 40);
            this.txtBox_Equipamentos.Multiline = true;
            this.txtBox_Equipamentos.Name = "txtBox_Equipamentos";
            this.txtBox_Equipamentos.Size = new System.Drawing.Size(171, 139);
            this.txtBox_Equipamentos.TabIndex = 20;
            // 
            // txtBox_TiposSala
            // 
            this.txtBox_TiposSala.Enabled = false;
            this.txtBox_TiposSala.Location = new System.Drawing.Point(189, 40);
            this.txtBox_TiposSala.Multiline = true;
            this.txtBox_TiposSala.Name = "txtBox_TiposSala";
            this.txtBox_TiposSala.Size = new System.Drawing.Size(171, 139);
            this.txtBox_TiposSala.TabIndex = 21;
            // 
            // txtBox_Salas
            // 
            this.txtBox_Salas.Enabled = false;
            this.txtBox_Salas.Location = new System.Drawing.Point(366, 40);
            this.txtBox_Salas.Multiline = true;
            this.txtBox_Salas.Name = "txtBox_Salas";
            this.txtBox_Salas.Size = new System.Drawing.Size(171, 139);
            this.txtBox_Salas.TabIndex = 22;
            // 
            // txtBox_Clientes
            // 
            this.txtBox_Clientes.Enabled = false;
            this.txtBox_Clientes.Location = new System.Drawing.Point(12, 213);
            this.txtBox_Clientes.Multiline = true;
            this.txtBox_Clientes.Name = "txtBox_Clientes";
            this.txtBox_Clientes.Size = new System.Drawing.Size(171, 139);
            this.txtBox_Clientes.TabIndex = 23;
            // 
            // txtBox_Reservas
            // 
            this.txtBox_Reservas.Enabled = false;
            this.txtBox_Reservas.Location = new System.Drawing.Point(189, 213);
            this.txtBox_Reservas.Multiline = true;
            this.txtBox_Reservas.Name = "txtBox_Reservas";
            this.txtBox_Reservas.Size = new System.Drawing.Size(227, 139);
            this.txtBox_Reservas.TabIndex = 24;
            // 
            // txtBox_ComandosSQL
            // 
            this.txtBox_ComandosSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_ComandosSQL.Location = new System.Drawing.Point(543, 40);
            this.txtBox_ComandosSQL.Multiline = true;
            this.txtBox_ComandosSQL.Name = "txtBox_ComandosSQL";
            this.txtBox_ComandosSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_ComandosSQL.Size = new System.Drawing.Size(436, 510);
            this.txtBox_ComandosSQL.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Comandos SQL executados:";
            // 
            // bt_ReservasSalaDataHora
            // 
            this.bt_ReservasSalaDataHora.Location = new System.Drawing.Point(12, 358);
            this.bt_ReservasSalaDataHora.Name = "bt_ReservasSalaDataHora";
            this.bt_ReservasSalaDataHora.Size = new System.Drawing.Size(267, 23);
            this.bt_ReservasSalaDataHora.TabIndex = 27;
            this.bt_ReservasSalaDataHora.Text = "Reservas da sala 1 no dia 01/01/2017, as 20:00";
            this.bt_ReservasSalaDataHora.UseVisualStyleBackColor = true;
            this.bt_ReservasSalaDataHora.Click += new System.EventHandler(this.bt_ReservasSalaDataHora_Click);
            // 
            // bt_SalasLivresDataHora
            // 
            this.bt_SalasLivresDataHora.Location = new System.Drawing.Point(12, 387);
            this.bt_SalasLivresDataHora.Name = "bt_SalasLivresDataHora";
            this.bt_SalasLivresDataHora.Size = new System.Drawing.Size(267, 23);
            this.bt_SalasLivresDataHora.TabIndex = 28;
            this.bt_SalasLivresDataHora.Text = "Salas livres no dia 01/01/2017, as 20:00";
            this.bt_SalasLivresDataHora.UseVisualStyleBackColor = true;
            this.bt_SalasLivresDataHora.Click += new System.EventHandler(this.bt_SalasLivresDataHora_Click);
            // 
            // bt_SalasComEquipamento
            // 
            this.bt_SalasComEquipamento.Location = new System.Drawing.Point(12, 416);
            this.bt_SalasComEquipamento.Name = "bt_SalasComEquipamento";
            this.bt_SalasComEquipamento.Size = new System.Drawing.Size(267, 23);
            this.bt_SalasComEquipamento.TabIndex = 29;
            this.bt_SalasComEquipamento.Text = "Salas com equipamento Notebook";
            this.bt_SalasComEquipamento.UseVisualStyleBackColor = true;
            this.bt_SalasComEquipamento.Click += new System.EventHandler(this.bt_SalasComEquipamento_Click);
            // 
            // bt_clientesNaSalaEm
            // 
            this.bt_clientesNaSalaEm.Location = new System.Drawing.Point(12, 445);
            this.bt_clientesNaSalaEm.Name = "bt_clientesNaSalaEm";
            this.bt_clientesNaSalaEm.Size = new System.Drawing.Size(267, 23);
            this.bt_clientesNaSalaEm.TabIndex = 30;
            this.bt_clientesNaSalaEm.Text = "Clientes na sala 1 no dia 01/01/2016, as 17:00";
            this.bt_clientesNaSalaEm.UseVisualStyleBackColor = true;
            this.bt_clientesNaSalaEm.Click += new System.EventHandler(this.bt_clientesNaSalaEm_Click);
            // 
            // bt_ReservasCliente
            // 
            this.bt_ReservasCliente.Location = new System.Drawing.Point(12, 474);
            this.bt_ReservasCliente.Name = "bt_ReservasCliente";
            this.bt_ReservasCliente.Size = new System.Drawing.Size(267, 23);
            this.bt_ReservasCliente.TabIndex = 31;
            this.bt_ReservasCliente.Text = "Reservas do cliente 3";
            this.bt_ReservasCliente.UseVisualStyleBackColor = true;
            this.bt_ReservasCliente.Click += new System.EventHandler(this.bt_ReservasCliente_Click);
            // 
            // bt_ReservasNaoPagasAgrupClientesOrdemValorDesc
            // 
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.Location = new System.Drawing.Point(12, 503);
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.Name = "bt_ReservasNaoPagasAgrupClientesOrdemValorDesc";
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.Size = new System.Drawing.Size(362, 23);
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.TabIndex = 32;
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.Text = "Reservas não pagas agrupadas por cliente e ordenadas por valor desc";
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.UseVisualStyleBackColor = true;
            this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc.Click += new System.EventHandler(this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 562);
            this.Controls.Add(this.bt_ReservasNaoPagasAgrupClientesOrdemValorDesc);
            this.Controls.Add(this.bt_ReservasCliente);
            this.Controls.Add(this.bt_clientesNaSalaEm);
            this.Controls.Add(this.bt_SalasComEquipamento);
            this.Controls.Add(this.bt_SalasLivresDataHora);
            this.Controls.Add(this.bt_ReservasSalaDataHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_ComandosSQL);
            this.Controls.Add(this.txtBox_Reservas);
            this.Controls.Add(this.txtBox_Clientes);
            this.Controls.Add(this.txtBox_Salas);
            this.Controls.Add(this.txtBox_TiposSala);
            this.Controls.Add(this.txtBox_Equipamentos);
            this.Controls.Add(this.bt_Clientes);
            this.Controls.Add(this.bt_TiposSala);
            this.Controls.Add(this.bt_PopulaBanco);
            this.Controls.Add(this.bt_Equipamentos);
            this.Controls.Add(this.bt_Salas);
            this.Controls.Add(this.bt_Reservas);
            this.Name = "Form1";
            this.Text = "Coworking Space";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Reservas;
        private System.Windows.Forms.Button bt_Salas;
        private System.Windows.Forms.Button bt_Equipamentos;
        private System.Windows.Forms.Button bt_PopulaBanco;
        private System.Windows.Forms.Button bt_TiposSala;
        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBox_Equipamentos;
        private System.Windows.Forms.TextBox txtBox_TiposSala;
        private System.Windows.Forms.TextBox txtBox_Salas;
        private System.Windows.Forms.TextBox txtBox_Clientes;
        private System.Windows.Forms.TextBox txtBox_Reservas;
        private System.Windows.Forms.TextBox txtBox_ComandosSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ReservasSalaDataHora;
        private System.Windows.Forms.Button bt_SalasLivresDataHora;
        private System.Windows.Forms.Button bt_SalasComEquipamento;
        private System.Windows.Forms.Button bt_clientesNaSalaEm;
        private System.Windows.Forms.Button bt_ReservasCliente;
        private System.Windows.Forms.Button bt_ReservasNaoPagasAgrupClientesOrdemValorDesc;
    }
}

