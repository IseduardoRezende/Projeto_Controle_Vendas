namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmenu));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConsultaFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHistoricoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConf = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMenu = new System.Windows.Forms.StatusStrip();
            this.lblTituloData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTituloHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHoraAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbApresentacao = new System.Windows.Forms.GroupBox();
            this.lblNomeApresentacao = new System.Windows.Forms.Label();
            this.lblTituloApresentacao = new System.Windows.Forms.Label();
            this.tHoraAtual = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.ssMenu.SuspendLayout();
            this.gbApresentacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.White;
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientes,
            this.mnuFuncionarios,
            this.mnuFornecedores,
            this.mnuProdutos,
            this.mnuVendas,
            this.mnuConf});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.msMenu.Size = new System.Drawing.Size(1115, 37);
            this.msMenu.TabIndex = 0;
            // 
            // mnuClientes
            // 
            this.mnuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroClientes,
            this.toolStripSeparator1,
            this.mnuConsultaClientes});
            this.mnuClientes.ForeColor = System.Drawing.Color.Purple;
            this.mnuClientes.Image = global::Projeto_Controle_Vendas.Properties.Resources._6973362_phone_user_communication_contact_icon;
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(107, 29);
            this.mnuClientes.Text = "Clientes";
            // 
            // mnuCadastroClientes
            // 
            this.mnuCadastroClientes.Name = "mnuCadastroClientes";
            this.mnuCadastroClientes.Size = new System.Drawing.Size(257, 30);
            this.mnuCadastroClientes.Text = "Cadastro de Clientes";
            this.mnuCadastroClientes.Click += new System.EventHandler(this.mnuCadastroClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // mnuConsultaClientes
            // 
            this.mnuConsultaClientes.Name = "mnuConsultaClientes";
            this.mnuConsultaClientes.Size = new System.Drawing.Size(257, 30);
            this.mnuConsultaClientes.Text = "Consulta de Clientes";
            this.mnuConsultaClientes.Click += new System.EventHandler(this.mnuConsultaClientes_Click);
            // 
            // mnuFuncionarios
            // 
            this.mnuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroFuncionarios,
            this.toolStripSeparator2,
            this.mnuConsultaFuncionarios});
            this.mnuFuncionarios.ForeColor = System.Drawing.Color.Purple;
            this.mnuFuncionarios.Image = global::Projeto_Controle_Vendas.Properties.Resources._6973348_contacts_person_communication_phone_icon;
            this.mnuFuncionarios.Name = "mnuFuncionarios";
            this.mnuFuncionarios.Size = new System.Drawing.Size(148, 29);
            this.mnuFuncionarios.Text = "Funcionários";
            // 
            // mnuCadastroFuncionarios
            // 
            this.mnuCadastroFuncionarios.Name = "mnuCadastroFuncionarios";
            this.mnuCadastroFuncionarios.Size = new System.Drawing.Size(298, 30);
            this.mnuCadastroFuncionarios.Text = "Cadastro de Funcionários";
            this.mnuCadastroFuncionarios.Click += new System.EventHandler(this.mnuCadastroFuncionarios_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(295, 6);
            // 
            // mnuConsultaFuncionarios
            // 
            this.mnuConsultaFuncionarios.Name = "mnuConsultaFuncionarios";
            this.mnuConsultaFuncionarios.Size = new System.Drawing.Size(298, 30);
            this.mnuConsultaFuncionarios.Text = "Consulta de Funcionários";
            this.mnuConsultaFuncionarios.Click += new System.EventHandler(this.mnuConsultaFuncionarios_Click);
            // 
            // mnuFornecedores
            // 
            this.mnuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroFornecedores,
            this.toolStripSeparator3,
            this.mnuConsultaFornecedores});
            this.mnuFornecedores.ForeColor = System.Drawing.Color.Purple;
            this.mnuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources._6973347_phone_grub_communication_forum_icon;
            this.mnuFornecedores.Name = "mnuFornecedores";
            this.mnuFornecedores.Size = new System.Drawing.Size(154, 29);
            this.mnuFornecedores.Text = "Fornecedores";
            // 
            // mnuCadastroFornecedores
            // 
            this.mnuCadastroFornecedores.Name = "mnuCadastroFornecedores";
            this.mnuCadastroFornecedores.Size = new System.Drawing.Size(304, 30);
            this.mnuCadastroFornecedores.Text = "Cadastro de Fornecedores";
            this.mnuCadastroFornecedores.Click += new System.EventHandler(this.mnuCadastroFornecedores_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(301, 6);
            // 
            // mnuConsultaFornecedores
            // 
            this.mnuConsultaFornecedores.Name = "mnuConsultaFornecedores";
            this.mnuConsultaFornecedores.Size = new System.Drawing.Size(304, 30);
            this.mnuConsultaFornecedores.Text = "Consulta de Fornecedores";
            this.mnuConsultaFornecedores.Click += new System.EventHandler(this.mnuConsultaFornecedores_Click);
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroProdutos,
            this.toolStripSeparator4,
            this.mnuConsultaProdutos});
            this.mnuProdutos.ForeColor = System.Drawing.Color.Purple;
            this.mnuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources._6973340_live_phone_communication_play_icon;
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.Size = new System.Drawing.Size(116, 29);
            this.mnuProdutos.Text = "Produtos";
            // 
            // mnuCadastroProdutos
            // 
            this.mnuCadastroProdutos.Name = "mnuCadastroProdutos";
            this.mnuCadastroProdutos.Size = new System.Drawing.Size(266, 30);
            this.mnuCadastroProdutos.Text = "Cadastro de Produtos";
            this.mnuCadastroProdutos.Click += new System.EventHandler(this.mnuCadastroProdutos_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(263, 6);
            // 
            // mnuConsultaProdutos
            // 
            this.mnuConsultaProdutos.Name = "mnuConsultaProdutos";
            this.mnuConsultaProdutos.Size = new System.Drawing.Size(266, 30);
            this.mnuConsultaProdutos.Text = "Consulta de Produtos";
            this.mnuConsultaProdutos.Click += new System.EventHandler(this.mnuConsultaProdutos_Click);
            // 
            // mnuVendas
            // 
            this.mnuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovaVenda,
            this.toolStripSeparator5,
            this.mnuHistoricoVendas});
            this.mnuVendas.ForeColor = System.Drawing.Color.Purple;
            this.mnuVendas.Image = global::Projeto_Controle_Vendas.Properties.Resources._6973346_inport_phone_export_communication_icon;
            this.mnuVendas.Name = "mnuVendas";
            this.mnuVendas.Size = new System.Drawing.Size(101, 29);
            this.mnuVendas.Text = "Vendas";
            // 
            // mnuNovaVenda
            // 
            this.mnuNovaVenda.Name = "mnuNovaVenda";
            this.mnuNovaVenda.Size = new System.Drawing.Size(251, 30);
            this.mnuNovaVenda.Text = "Nova Venda";
            this.mnuNovaVenda.Click += new System.EventHandler(this.mnuNovaVenda_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(248, 6);
            // 
            // mnuHistoricoVendas
            // 
            this.mnuHistoricoVendas.Name = "mnuHistoricoVendas";
            this.mnuHistoricoVendas.Size = new System.Drawing.Size(251, 30);
            this.mnuHistoricoVendas.Text = "Histórico de Vendas";
            this.mnuHistoricoVendas.Click += new System.EventHandler(this.mnuHistoricoVendas_Click);
            // 
            // mnuConf
            // 
            this.mnuConf.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrocarUsuario,
            this.sairToolStripMenuItem});
            this.mnuConf.ForeColor = System.Drawing.Color.Purple;
            this.mnuConf.Image = global::Projeto_Controle_Vendas.Properties.Resources._6971745_ui_bassic_device_sun_brightness_icon;
            this.mnuConf.Name = "mnuConf";
            this.mnuConf.Size = new System.Drawing.Size(162, 29);
            this.mnuConf.Text = "Configurações";
            // 
            // mnuTrocarUsuario
            // 
            this.mnuTrocarUsuario.Name = "mnuTrocarUsuario";
            this.mnuTrocarUsuario.Size = new System.Drawing.Size(232, 30);
            this.mnuTrocarUsuario.Text = "Trocar de Usuário";
            this.mnuTrocarUsuario.Click += new System.EventHandler(this.mnuTrocarUsuario_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::Projeto_Controle_Vendas.Properties.Resources._6971736_ui_bassic_device_plane_airplane_icon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ssMenu
            // 
            this.ssMenu.BackColor = System.Drawing.Color.Purple;
            this.ssMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTituloData,
            this.lblDataAtual,
            this.lblTituloHora,
            this.lblHoraAtual,
            this.lblStatus,
            this.lblNomeUsuario});
            this.ssMenu.Location = new System.Drawing.Point(0, 403);
            this.ssMenu.Name = "ssMenu";
            this.ssMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMenu.Size = new System.Drawing.Size(1115, 26);
            this.ssMenu.TabIndex = 1;
            // 
            // lblTituloData
            // 
            this.lblTituloData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloData.Name = "lblTituloData";
            this.lblTituloData.Size = new System.Drawing.Size(85, 21);
            this.lblTituloData.Text = "Data Atual:";
            // 
            // lblDataAtual
            // 
            this.lblDataAtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtual.Name = "lblDataAtual";
            this.lblDataAtual.Size = new System.Drawing.Size(0, 21);
            // 
            // lblTituloHora
            // 
            this.lblTituloHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHora.Name = "lblTituloHora";
            this.lblTituloHora.Size = new System.Drawing.Size(87, 21);
            this.lblTituloHora.Text = "Hora Atual:";
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(0, 21);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 21);
            this.lblStatus.Text = "Status: Logado";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(0, 21);
            // 
            // gbApresentacao
            // 
            this.gbApresentacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbApresentacao.Controls.Add(this.lblNomeApresentacao);
            this.gbApresentacao.Controls.Add(this.lblTituloApresentacao);
            this.gbApresentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbApresentacao.ForeColor = System.Drawing.Color.White;
            this.gbApresentacao.Location = new System.Drawing.Point(788, 103);
            this.gbApresentacao.Name = "gbApresentacao";
            this.gbApresentacao.Size = new System.Drawing.Size(327, 268);
            this.gbApresentacao.TabIndex = 2;
            this.gbApresentacao.TabStop = false;
            this.gbApresentacao.Text = "Bem Vindo ao Arphia ☽";
            // 
            // lblNomeApresentacao
            // 
            this.lblNomeApresentacao.AutoSize = true;
            this.lblNomeApresentacao.Location = new System.Drawing.Point(26, 98);
            this.lblNomeApresentacao.Name = "lblNomeApresentacao";
            this.lblNomeApresentacao.Size = new System.Drawing.Size(0, 28);
            this.lblNomeApresentacao.TabIndex = 1;
            // 
            // lblTituloApresentacao
            // 
            this.lblTituloApresentacao.AutoSize = true;
            this.lblTituloApresentacao.Location = new System.Drawing.Point(26, 51);
            this.lblTituloApresentacao.Name = "lblTituloApresentacao";
            this.lblTituloApresentacao.Size = new System.Drawing.Size(300, 28);
            this.lblTituloApresentacao.TabIndex = 0;
            this.lblTituloApresentacao.Text = "Nosso Gestor de Estoque.";
            // 
            // tHoraAtual
            // 
            this.tHoraAtual.Enabled = true;
            this.tHoraAtual.Interval = 1000;
            this.tHoraAtual.Tick += new System.EventHandler(this.tHoraAtual_Tick);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::Projeto_Controle_Vendas.Properties.Resources._6071806_businessman_office_work_working_work_alone_icon__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1115, 429);
            this.Controls.Add(this.gbApresentacao);
            this.Controls.Add(this.ssMenu);
            this.Controls.Add(this.msMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "Frmmenu";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssMenu.ResumeLayout(false);
            this.ssMenu.PerformLayout();
            this.gbApresentacao.ResumeLayout(false);
            this.gbApresentacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuVendas;
        private System.Windows.Forms.ToolStripMenuItem mnuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem mnuHistoricoVendas;
        private System.Windows.Forms.ToolStripMenuItem mnuConf;
        private System.Windows.Forms.ToolStripMenuItem mnuTrocarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.StatusStrip ssMenu;
        private System.Windows.Forms.ToolStripStatusLabel lblTituloData;
        private System.Windows.Forms.ToolStripStatusLabel lblDataAtual;
        private System.Windows.Forms.ToolStripStatusLabel lblTituloHora;
        private System.Windows.Forms.ToolStripStatusLabel lblHoraAtual;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblNomeUsuario;
        private System.Windows.Forms.GroupBox gbApresentacao;
        private System.Windows.Forms.Label lblNomeApresentacao;
        private System.Windows.Forms.Label lblTituloApresentacao;
        private System.Windows.Forms.Timer tHoraAtual;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}