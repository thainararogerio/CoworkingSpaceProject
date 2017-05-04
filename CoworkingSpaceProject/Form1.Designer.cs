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
            this.bt_TiposEquipamento = new System.Windows.Forms.Button();
            this.bt_TiposSala = new System.Windows.Forms.Button();
            this.bt_Clientes = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBox_TiposEquipamentos = new System.Windows.Forms.TextBox();
            this.txtBox_Equipamentos = new System.Windows.Forms.TextBox();
            this.txtBox_TiposSala = new System.Windows.Forms.TextBox();
            this.txtBox_Salas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Reservas
            // 
            this.bt_Reservas.Location = new System.Drawing.Point(458, 305);
            this.bt_Reservas.Name = "bt_Reservas";
            this.bt_Reservas.Size = new System.Drawing.Size(130, 23);
            this.bt_Reservas.TabIndex = 0;
            this.bt_Reservas.Text = "Reservas";
            this.bt_Reservas.UseVisualStyleBackColor = true;
            this.bt_Reservas.Click += new System.EventHandler(this.bt_reservas_Click);
            // 
            // bt_Salas
            // 
            this.bt_Salas.Location = new System.Drawing.Point(552, 12);
            this.bt_Salas.Name = "bt_Salas";
            this.bt_Salas.Size = new System.Drawing.Size(130, 23);
            this.bt_Salas.TabIndex = 1;
            this.bt_Salas.Text = "Salas";
            this.bt_Salas.UseVisualStyleBackColor = true;
            this.bt_Salas.Click += new System.EventHandler(this.bt_Salas_Click);
            // 
            // bt_Equipamentos
            // 
            this.bt_Equipamentos.Location = new System.Drawing.Point(198, 12);
            this.bt_Equipamentos.Name = "bt_Equipamentos";
            this.bt_Equipamentos.Size = new System.Drawing.Size(130, 23);
            this.bt_Equipamentos.TabIndex = 3;
            this.bt_Equipamentos.Text = "Equipamentos";
            this.bt_Equipamentos.UseVisualStyleBackColor = true;
            this.bt_Equipamentos.Click += new System.EventHandler(this.bt_Equipamentos_Click);
            // 
            // bt_PopulaBanco
            // 
            this.bt_PopulaBanco.Location = new System.Drawing.Point(458, 346);
            this.bt_PopulaBanco.Name = "bt_PopulaBanco";
            this.bt_PopulaBanco.Size = new System.Drawing.Size(115, 23);
            this.bt_PopulaBanco.TabIndex = 13;
            this.bt_PopulaBanco.Text = "Popula banco";
            this.bt_PopulaBanco.UseVisualStyleBackColor = true;
            this.bt_PopulaBanco.Click += new System.EventHandler(this.bt_PopulaBanco_Click);
            // 
            // bt_TiposEquipamento
            // 
            this.bt_TiposEquipamento.Location = new System.Drawing.Point(21, 12);
            this.bt_TiposEquipamento.Name = "bt_TiposEquipamento";
            this.bt_TiposEquipamento.Size = new System.Drawing.Size(130, 23);
            this.bt_TiposEquipamento.TabIndex = 14;
            this.bt_TiposEquipamento.Text = "Tipos de equipamento";
            this.bt_TiposEquipamento.UseVisualStyleBackColor = true;
            this.bt_TiposEquipamento.Click += new System.EventHandler(this.bt_TiposEquipamento_Click);
            // 
            // bt_TiposSala
            // 
            this.bt_TiposSala.Location = new System.Drawing.Point(375, 12);
            this.bt_TiposSala.Name = "bt_TiposSala";
            this.bt_TiposSala.Size = new System.Drawing.Size(130, 23);
            this.bt_TiposSala.TabIndex = 15;
            this.bt_TiposSala.Text = "Tipos de sala";
            this.bt_TiposSala.UseVisualStyleBackColor = true;
            this.bt_TiposSala.Click += new System.EventHandler(this.bt_TiposSala_Click);
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.Location = new System.Drawing.Point(458, 276);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(130, 23);
            this.bt_Clientes.TabIndex = 16;
            this.bt_Clientes.Text = "Clientes";
            this.bt_Clientes.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBox_TiposEquipamentos
            // 
            this.txtBox_TiposEquipamentos.Location = new System.Drawing.Point(21, 41);
            this.txtBox_TiposEquipamentos.Multiline = true;
            this.txtBox_TiposEquipamentos.Name = "txtBox_TiposEquipamentos";
            this.txtBox_TiposEquipamentos.Size = new System.Drawing.Size(171, 139);
            this.txtBox_TiposEquipamentos.TabIndex = 19;
            // 
            // txtBox_Equipamentos
            // 
            this.txtBox_Equipamentos.Location = new System.Drawing.Point(198, 41);
            this.txtBox_Equipamentos.Multiline = true;
            this.txtBox_Equipamentos.Name = "txtBox_Equipamentos";
            this.txtBox_Equipamentos.Size = new System.Drawing.Size(171, 139);
            this.txtBox_Equipamentos.TabIndex = 20;
            // 
            // txtBox_TiposSala
            // 
            this.txtBox_TiposSala.Location = new System.Drawing.Point(375, 41);
            this.txtBox_TiposSala.Multiline = true;
            this.txtBox_TiposSala.Name = "txtBox_TiposSala";
            this.txtBox_TiposSala.Size = new System.Drawing.Size(171, 139);
            this.txtBox_TiposSala.TabIndex = 21;
            // 
            // txtBox_Salas
            // 
            this.txtBox_Salas.Location = new System.Drawing.Point(552, 41);
            this.txtBox_Salas.Multiline = true;
            this.txtBox_Salas.Name = "txtBox_Salas";
            this.txtBox_Salas.Size = new System.Drawing.Size(171, 139);
            this.txtBox_Salas.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 442);
            this.Controls.Add(this.txtBox_Salas);
            this.Controls.Add(this.txtBox_TiposSala);
            this.Controls.Add(this.txtBox_Equipamentos);
            this.Controls.Add(this.txtBox_TiposEquipamentos);
            this.Controls.Add(this.bt_Clientes);
            this.Controls.Add(this.bt_TiposSala);
            this.Controls.Add(this.bt_TiposEquipamento);
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
        private System.Windows.Forms.Button bt_TiposEquipamento;
        private System.Windows.Forms.Button bt_TiposSala;
        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBox_TiposEquipamentos;
        private System.Windows.Forms.TextBox txtBox_Equipamentos;
        private System.Windows.Forms.TextBox txtBox_TiposSala;
        private System.Windows.Forms.TextBox txtBox_Salas;
    }
}

