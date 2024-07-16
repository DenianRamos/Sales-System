﻿using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método Cadastrar Produto
        public void cadastraProduto(Produto obj)
        {
            try
            {
                
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id) 
                               values (@descricao, @preco, @qtd, @for_id)";

                
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

               
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Alterar Produto
        public void alterarProduto(Produto obj)
        {
            try
            {
               
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque= @qtd, for_id = @for_id where id = @id";

              
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Excluir Produto

        public void excluirProduto(Produto obj)
        {
            try
            {
             
                string sql = @"delete from tb_produtos where id = @id";

               
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);                 

                executacmd.Parameters.AddWithValue("@id", obj.id);

                
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método ListarProdutos
        public DataTable listarProdutos()
        {
            try
            {
                
                DataTable tabelaProduto = new DataTable();
                string sql = @"select p.id as 'Código', 
                                      p.descricao as 'Descrição',  
                                      p.preco as 'Preço', 
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id);";

               
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

               
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

              
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }


        #endregion


        #region Método ListarProdutosPorNome
        public DataTable listarProdutosPorNome(string nome)
        {
            try
            {
                
                DataTable tabelaProduto = new DataTable();
                string sql = @"select p.id as 'Código', 
                                      p.descricao as 'Descrição',  
                                      p.preco as 'Preço', 
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id) where p.descricao like @nome;";

               
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

             
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }


        #endregion


        #region Método BuscaProdutoPorNome
        public DataTable BuscarProdutosPorNome(string nome)
        {
            try
            {
               
                DataTable tabelaProduto = new DataTable();
                string sql = @"select p.id as 'Código', 
                                      p.descricao as 'Descrição',  
                                      p.preco as 'Preço', 
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id) where p.descricao = @nome;";

                
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

               
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

               
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }

        }


        #endregion


        #region Método que retorna um produto por codigo
        public Produto retornaProdutoPorCodigo(Int64 id)
        {
            try
            {
                
                string sql = @"select * from tb_produtos where id = @id";

                
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);
                conexao.Open();

                
                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    Produto p = new Produto();

                    p.id = rs.GetInt32("id");
                    p.descricao = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");

                    conexao.Close();

                    return p;
                  

                }
               

                else
                {
                    MessageBox.Show("Nenhum produto encontrando com esse código!");

                    conexao.Close();
                    return null;
                    
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
                
            }
        }


        #endregion

        #region Método que baixa o estoque
        public void baixaEstoque(int idproduto, int qtdestoque)
        {
            try
            {
                
                string sql = @"update tb_produtos set qtd_estoque=@qtd where id = @id";
              
                
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@qtd", qtdestoque);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                
                conexao.Open();
                executacmd.ExecuteNonQuery();
                
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                conexao.Close();
            }

        }

        #endregion

        #region Método que retorna o estoque atual de um produto
        public int retornaEstoqueAtual(int idproduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where id = @id";
                int qtd_estoque = 0;

                
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();

                MySqlDataReader rs = executacmd.ExecuteReader();

                if (rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conexao.Close();

                }

                return qtd_estoque;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconceteu o erro: " + erro);
                return 0;
            }
        }
        #endregion

    }
}
