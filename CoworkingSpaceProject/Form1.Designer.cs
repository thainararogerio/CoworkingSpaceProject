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
            this.bt_reservas = new System.Windows.Forms.Button();
            this.bt_salas = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.bt_equipamentos = new System.Windows.Forms.Button();
            this.bt_inicia = new System.Windows.Forms.Button();
            this.bt_addReserva = new System.Windows.Forms.Button();
            this.bt_addTipoSala = new System.Windows.Forms.Button();
            this.bt_addTipoEquipamento = new System.Windows.Forms.Button();
            this.bt_addEquipamento = new System.Windows.Forms.Button();
            this.bt_addSala = new System.Windows.Forms.Button();
            this.bt_addSalaEquipamento = new System.Windows.Forms.Button();
            this.bt_addLocalidade = new System.Windows.Forms.Button();
            this.bt_addCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_reservas
            // 
            this.bt_reservas.Location = new System.Drawing.Point(78, 12);
            this.bt_reservas.Name = "bt_reservas";
            this.bt_reservas.Size = new System.Drawing.Size(109, 23);
            this.bt_reservas.TabIndex = 0;
            this.bt_reservas.Text = "Busca reservas";
            this.bt_reservas.UseVisualStyleBackColor = true;
            this.bt_reservas.Click += new System.EventHandler(this.bt_reservas_Click);
            // 
            // bt_salas
            // 
            this.bt_salas.Location = new System.Drawing.Point(78, 50);
            this.bt_salas.Name = "bt_salas";
            this.bt_salas.Size = new System.Drawing.Size(109, 23);
            this.bt_salas.TabIndex = 1;
            this.bt_salas.Text = "Busca salas";
            this.bt_salas.UseVisualStyleBackColor = true;
            // 
            // bt_clientes
            // 
            this.bt_clientes.Location = new System.Drawing.Point(78, 88);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(109, 23);
            this.bt_clientes.TabIndex = 2;
            this.bt_clientes.Text = "Busca clientes";
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // bt_equipamentos
            // 
            this.bt_equipamentos.Location = new System.Drawing.Point(66, 126);
            this.bt_equipamentos.Name = "bt_equipamentos";
            this.bt_equipamentos.Size = new System.Drawing.Size(130, 23);
            this.bt_equipamentos.TabIndex = 3;
            this.bt_equipamentos.Text = "Busca equipamentos";
            this.bt_equipamentos.UseVisualStyleBackColor = true;
            // 
            // bt_inicia
            // 
            this.bt_inicia.Location = new System.Drawing.Point(95, 190);
            this.bt_inicia.Name = "bt_inicia";
            this.bt_inicia.Size = new System.Drawing.Size(75, 23);
            this.bt_inicia.TabIndex = 4;
            this.bt_inicia.Text = "Inicia";
            this.bt_inicia.UseVisualStyleBackColor = true;
            this.bt_inicia.Click += new System.EventHandler(this.bt_inicia_Click);
            // 
            // bt_addReserva
            // 
            this.bt_addReserva.Location = new System.Drawing.Point(298, 12);
            this.bt_addReserva.Name = "bt_addReserva";
            this.bt_addReserva.Size = new System.Drawing.Size(165, 23);
            this.bt_addReserva.TabIndex = 5;
            this.bt_addReserva.Text = "Add Reserva";
            this.bt_addReserva.UseVisualStyleBackColor = true;
            this.bt_addReserva.Click += new System.EventHandler(this.bt_addReserva_Click);
            // 
            // bt_addTipoSala
            // 
            this.bt_addTipoSala.Location = new System.Drawing.Point(298, 50);
            this.bt_addTipoSala.Name = "bt_addTipoSala";
            this.bt_addTipoSala.Size = new System.Drawing.Size(165, 23);
            this.bt_addTipoSala.TabIndex = 6;
            this.bt_addTipoSala.Text = "Add Tipo de Sala";
            this.bt_addTipoSala.UseVisualStyleBackColor = true;
            this.bt_addTipoSala.Click += new System.EventHandler(this.bt_addTipoSala_Click);
            // 
            // bt_addTipoEquipamento
            // 
            this.bt_addTipoEquipamento.Location = new System.Drawing.Point(298, 88);
            this.bt_addTipoEquipamento.Name = "bt_addTipoEquipamento";
            this.bt_addTipoEquipamento.Size = new System.Drawing.Size(165, 23);
            this.bt_addTipoEquipamento.TabIndex = 7;
            this.bt_addTipoEquipamento.Text = "Add Tipo de Equipamento";
            this.bt_addTipoEquipamento.UseVisualStyleBackColor = true;
            this.bt_addTipoEquipamento.Click += new System.EventHandler(this.bt_addTipoEquipamento_Click);
            // 
            // bt_addEquipamento
            // 
            this.bt_addEquipamento.Location = new System.Drawing.Point(298, 126);
            this.bt_addEquipamento.Name = "bt_addEquipamento";
            this.bt_addEquipamento.Size = new System.Drawing.Size(139, 23);
            this.bt_addEquipamento.TabIndex = 8;
            this.bt_addEquipamento.Text = "Add Equipamento";
            this.bt_addEquipamento.UseVisualStyleBackColor = true;
            this.bt_addEquipamento.Click += new System.EventHandler(this.bt_addEquipamento_Click);
            // 
            // bt_addSala
            // 
            this.bt_addSala.Location = new System.Drawing.Point(298, 168);
            this.bt_addSala.Name = "bt_addSala";
            this.bt_addSala.Size = new System.Drawing.Size(139, 23);
            this.bt_addSala.TabIndex = 9;
            this.bt_addSala.Text = "Add Sala";
            this.bt_addSala.UseVisualStyleBackColor = true;
            this.bt_addSala.Click += new System.EventHandler(this.bt_addSala_Click);
            // 
            // bt_addSalaEquipamento
            // 
            this.bt_addSalaEquipamento.Location = new System.Drawing.Point(298, 206);
            this.bt_addSalaEquipamento.Name = "bt_addSalaEquipamento";
            this.bt_addSalaEquipamento.Size = new System.Drawing.Size(139, 23);
            this.bt_addSalaEquipamento.TabIndex = 10;
            this.bt_addSalaEquipamento.Text = "Add Sala Equipamento";
            this.bt_addSalaEquipamento.UseVisualStyleBackColor = true;
            this.bt_addSalaEquipamento.Click += new System.EventHandler(this.bt_addSalaEquipamento_Click);
            // 
            // bt_addLocalidade
            // 
            this.bt_addLocalidade.Location = new System.Drawing.Point(298, 246);
            this.bt_addLocalidade.Name = "bt_addLocalidade";
            this.bt_addLocalidade.Size = new System.Drawing.Size(139, 23);
            this.bt_addLocalidade.TabIndex = 11;
            this.bt_addLocalidade.Text = "Add Localidade";
            this.bt_addLocalidade.UseVisualStyleBackColor = true;
            this.bt_addLocalidade.Click += new System.EventHandler(this.bt_addLocalidade_Click);
            // 
            // bt_addCliente
            // 
            this.bt_addCliente.Location = new System.Drawing.Point(298, 275);
            this.bt_addCliente.Name = "bt_addCliente";
            this.bt_addCliente.Size = new System.Drawing.Size(139, 23);
            this.bt_addCliente.TabIndex = 12;
            this.bt_addCliente.Text = "Add Cliente";
            this.bt_addCliente.UseVisualStyleBackColor = true;
            this.bt_addCliente.Click += new System.EventHandler(this.bt_addCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 350);
            this.Controls.Add(this.bt_addCliente);
            this.Controls.Add(this.bt_addLocalidade);
            this.Controls.Add(this.bt_addSalaEquipamento);
            this.Controls.Add(this.bt_addSala);
            this.Controls.Add(this.bt_addEquipamento);
            this.Controls.Add(this.bt_addTipoEquipamento);
            this.Controls.Add(this.bt_addTipoSala);
            this.Controls.Add(this.bt_addReserva);
            this.Controls.Add(this.bt_inicia);
            this.Controls.Add(this.bt_equipamentos);
            this.Controls.Add(this.bt_clientes);
            this.Controls.Add(this.bt_salas);
            this.Controls.Add(this.bt_reservas);
            this.Name = "Form1";
            this.Text = "Coworking Space";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_reservas;
        private System.Windows.Forms.Button bt_salas;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.Button bt_equipamentos;
        private System.Windows.Forms.Button bt_inicia;
        private System.Windows.Forms.Button bt_addReserva;
        private System.Windows.Forms.Button bt_addTipoSala;
        private System.Windows.Forms.Button bt_addTipoEquipamento;
        private System.Windows.Forms.Button bt_addEquipamento;
        private System.Windows.Forms.Button bt_addSala;
        private System.Windows.Forms.Button bt_addSalaEquipamento;
        private System.Windows.Forms.Button bt_addLocalidade;
        private System.Windows.Forms.Button bt_addCliente;
    }
}

