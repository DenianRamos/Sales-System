namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHistoricoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeÚsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuClientes,
            this.MenuFuncionarios,
            this.MenuFornecedores,
            this.MenuProdutos,
            this.MenuVendas,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 29);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuClientes
            // 
            this.MenuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrarCliente,
            this.MenuConsultarCliente});
            this.MenuClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuClientes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuClientes.Image = global::Projeto_Controle_Vendas.Properties.Resources._686348;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(100, 25);
            this.MenuClientes.Text = "Clientes";
            // 
            // MenuCadastrarCliente
            // 
            this.MenuCadastrarCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuCadastrarCliente.Name = "MenuCadastrarCliente";
            this.MenuCadastrarCliente.Size = new System.Drawing.Size(226, 26);
            this.MenuCadastrarCliente.Text = "Cadastrar Clientes";
            this.MenuCadastrarCliente.Click += new System.EventHandler(this.MenuCadastrarCliente_Click);
            // 
            // MenuConsultarCliente
            // 
            this.MenuConsultarCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuConsultarCliente.Name = "MenuConsultarCliente";
            this.MenuConsultarCliente.Size = new System.Drawing.Size(226, 26);
            this.MenuConsultarCliente.Text = "Consulta Clientes";
            this.MenuConsultarCliente.Click += new System.EventHandler(this.MenuConsultarCliente_Click);
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrarFuncionarios,
            this.MenuConsultarFuncionarios});
            this.MenuFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFuncionarios.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuFuncionarios.Image = global::Projeto_Controle_Vendas.Properties.Resources.png_transparent_computer_icons_vendor_others_text_logo_typeface;
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(134, 25);
            this.MenuFuncionarios.Text = "Funcionários";
            // 
            // MenuCadastrarFuncionarios
            // 
            this.MenuCadastrarFuncionarios.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuCadastrarFuncionarios.Name = "MenuCadastrarFuncionarios";
            this.MenuCadastrarFuncionarios.Size = new System.Drawing.Size(260, 26);
            this.MenuCadastrarFuncionarios.Text = "Cadastrar Funcionários";
            this.MenuCadastrarFuncionarios.Click += new System.EventHandler(this.MenuCadastrarFuncionarios_Click);
            // 
            // MenuConsultarFuncionarios
            // 
            this.MenuConsultarFuncionarios.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuConsultarFuncionarios.Name = "MenuConsultarFuncionarios";
            this.MenuConsultarFuncionarios.Size = new System.Drawing.Size(260, 26);
            this.MenuConsultarFuncionarios.Text = "Consultar Funcionários";
            this.MenuConsultarFuncionarios.Click += new System.EventHandler(this.MenuConsultarFuncionarios_Click);
            // 
            // MenuFornecedores
            // 
            this.MenuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFornecedoresToolStripMenuItem,
            this.consultaDeFornecedoresToolStripMenuItem});
            this.MenuFornecedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFornecedores.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuFornecedores.Image = global::Projeto_Controle_Vendas.Properties.Resources.funn;
            this.MenuFornecedores.Name = "MenuFornecedores";
            this.MenuFornecedores.Size = new System.Drawing.Size(143, 25);
            this.MenuFornecedores.Text = "Fornecedores";
            // 
            // cadastroDeFornecedoresToolStripMenuItem
            // 
            this.cadastroDeFornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cadastroDeFornecedoresToolStripMenuItem.Name = "cadastroDeFornecedoresToolStripMenuItem";
            this.cadastroDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.cadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro De Fornecedores";
            this.cadastroDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedoresToolStripMenuItem_Click);
            // 
            // consultaDeFornecedoresToolStripMenuItem
            // 
            this.consultaDeFornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.consultaDeFornecedoresToolStripMenuItem.Name = "consultaDeFornecedoresToolStripMenuItem";
            this.consultaDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.consultaDeFornecedoresToolStripMenuItem.Text = "Consulta de Fornecedores";
            this.consultaDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.consultaDeFornecedoresToolStripMenuItem_Click);
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeProdutosToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem});
            this.MenuProdutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProdutos.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuProdutos.Image = global::Projeto_Controle_Vendas.Properties.Resources.produtos;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(106, 25);
            this.MenuProdutos.Text = "Produtos";
            this.MenuProdutos.Click += new System.EventHandler(this.MenuProdutos_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // consultaDeProdutosToolStripMenuItem
            // 
            this.consultaDeProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.consultaDeProdutosToolStripMenuItem.Name = "consultaDeProdutosToolStripMenuItem";
            this.consultaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.consultaDeProdutosToolStripMenuItem.Text = "Consulta de Produtos";
            this.consultaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProdutosToolStripMenuItem_Click);
            // 
            // MenuVendas
            // 
            this.MenuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHistoricoVendas,
            this.novaVendaToolStripMenuItem});
            this.MenuVendas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVendas.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuVendas.Image = global::Projeto_Controle_Vendas.Properties.Resources.vendas;
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(97, 25);
            this.MenuVendas.Text = "Vendas";
            // 
            // MenuHistoricoVendas
            // 
            this.MenuHistoricoVendas.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuHistoricoVendas.Name = "MenuHistoricoVendas";
            this.MenuHistoricoVendas.Size = new System.Drawing.Size(233, 26);
            this.MenuHistoricoVendas.Text = "Histórico de Vendas";
            this.MenuHistoricoVendas.Click += new System.EventHandler(this.históricoDeVenndasToolStripMenuItem_Click);
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            this.novaVendaToolStripMenuItem.Click += new System.EventHandler(this.novaVendaToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeÚsuarioToolStripMenuItem,
            this.sairDoSistemaToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçõesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.configuraçõesToolStripMenuItem.Image = global::Projeto_Controle_Vendas.Properties.Resources.config;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(152, 25);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // trocarDeÚsuarioToolStripMenuItem
            // 
            this.trocarDeÚsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.trocarDeÚsuarioToolStripMenuItem.Name = "trocarDeÚsuarioToolStripMenuItem";
            this.trocarDeÚsuarioToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.trocarDeÚsuarioToolStripMenuItem.Text = "Trocar de Úsuario";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            this.sairDoSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            this.sairDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            this.sairDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.sairDoSistemaToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Princípal ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultarCliente;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarDeÚsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultarFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        public System.Windows.Forms.ToolStripMenuItem MenuClientes;
        public System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem MenuVendas;
        public System.Windows.Forms.ToolStripMenuItem MenuFornecedores;
        public System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuHistoricoVendas;
    }
}