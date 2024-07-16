using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroDeClienntesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuVendas_Click(object sender, EventArgs e)
        {

        }

        private void MenuCliente_Click(object sender, EventArgs e)
        {

        }

        private void históricoDeVenndasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frmhistorico frmhistorico = new Frmhistorico();
            frmhistorico.ShowDialog();
        }

        private void MenuProdutos_Click(object sender, EventArgs e)
        {

        }

        private void MenuCadastrarCliente_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.ShowDialog();
        }

        private void MenuConsultarCliente_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.tabClientes.SelectedTab = tela.tabClientes.TabPages["tabConsultaCliente"];
           tela.ShowDialog();
        }

        private void MenuCadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.ShowDialog();

        }

        private void MenuConsultarFuncionarios_Click(object sender, EventArgs e)
        {
          Frmfuncionarios tela = new Frmfuncionarios();
            tela.tabFuncionario.SelectedTab = tela.tabFuncionario.TabPages["tabConsultaFuncionarios"];
            tela.ShowDialog();
        }

        private void cadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.ShowDialog();
        }

        private void consultaDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmprodutos tela = new Frmprodutos();
            tela.tabProdutos.SelectedTab = tela.tabProdutos.TabPages["TabConsultaProduto"];
            tela.ShowDialog();
        }

        private void consultaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.tabFornecedor.SelectedTab = tela.tabFornecedor.TabPages["tabPage2"];
            tela.ShowDialog();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
