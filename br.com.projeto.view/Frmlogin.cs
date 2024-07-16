using Projeto_Controle_Vendas.br.com.projeto.dao;
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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Btnentrar_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string senha = txtsenha.Text;
            FuncionarioDAO dao = new FuncionarioDAO();

            if(dao.efetuaLogin(email, senha) == true)
            {

                this.Hide();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }


           



        }
    }
}
