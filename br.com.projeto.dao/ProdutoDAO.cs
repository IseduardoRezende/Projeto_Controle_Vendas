using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ProdutoDAO
    {
        private SqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarProduto
        public void CadastrarProduto(Produto obj)
        {
            try
            {
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id)
                                values (@descricao, @preco, @qtd_estoque, @for_id)";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso !");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }

        #endregion

        #region ListarProduto
        public DataTable ListarProduto()
        {
            try
            {
                DataTable tabelaProduto = new DataTable();

                string sql = @"select p.id as 'Codigo',
	                                  p.descricao as 'Descrição',
	                                  p.preco as 'Preço',
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id);";

                SqlCommand executacmd = new SqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                
                return tabelaProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region AlterarProdutos
        public void AlterarProdutos(Produto obj)
        {
            try
            {
                string sql = @"update tb_produtos set descricao=@descricao, preco=@preco, qtd_estoque=@qtd_estoque,
                                     for_id=@for_id where id = @id";


                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.QtdEstoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso !");

                conexao.Close();            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region ExcluirProdutos
        public void ExcluirProdutos(Produto obj)
        {
            try
            {
                string sql = "delete from tb_produtos where id=@id";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                MessageBox.Show("Produto deletado com sucesso");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        #endregion

        #region BuscarPorNome
        public DataTable BuscarPorNome(string nome)
        {
            try
            {
                var tabelaProduto = new DataTable();

                string sql = @"select p.id as 'Codigo',
	                                  p.descricao as 'Descrição',
	                                  p.preco as 'Preço',
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id) 
                                      where p.descricao like @nome";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                var da = new SqlDataAdapter(executaCmd);
                da.Fill(tabelaProduto);

                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region PesquisarProduto
        public DataTable PesquisarProduto(string nome)
        {
            try
            {
                var tabelaProduto = new DataTable();

                string sql = @"select p.id as 'Codigo',
	                                  p.descricao as 'Descrição',
	                                  p.preco as 'Preço',
                                      p.qtd_estoque as 'Qtd Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id) 
                                      where p.descricao = @nome";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                var da = new SqlDataAdapter(executaCmd);
                da.Fill(tabelaProduto);

                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region RetornaProdutoPorId
        public Produto RetornaProdutoPorId(int id)
        {
            try
            {
                string sql = @"select * from tb_produtos where Id = @Id";

                //Organizar e executar comando sql e a conexão;

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                //DataReader para executar retorno de um valor específico;

                SqlDataReader dr = executaCmd.ExecuteReader();

                if (dr.Read())
                {
                    var produto = new Produto();

                    produto.id = dr.GetInt32(0);
                    produto.Descricao = dr.GetString(1);
                    produto.Preco = dr.GetDecimal(2);

                    conexao.Close();
                    return produto;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado com o código digitado!");
                    conexao.Close();                        
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na execução " + ex);
                return null;
            }
        }

        #endregion

        #region BaixaNoEstoqueDeProdutos
        
        public void BaixaNoEstoqueDeProdutos(int id, int qtd_Estoque)
        {
            try
            {
                string sql = "update tb_produtos set qtd_estoque = @qtd_estoque where Id = @Id";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@qtd_estoque", qtd_Estoque);
                executaCmd.Parameters.AddWithValue("@Id", id);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                conexao.Close();            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                conexao.Close();
            }
        }

        #endregion

        #region RetornaEstoqueAtualDoProduto
        
        public int RetornaEstoqueAtualDoProduto(int id)
        {
            try
            {
                int qtdEstoque = 0;

                string sql = "select qtd_estoque from tb_produtos where Id = @Id";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@Id", id);

                conexao.Open();

                SqlDataReader dr = executaCmd.ExecuteReader();               
                
                if (dr.Read())
                {
                    qtdEstoque = (int) dr["qtd_estoque"];   
                    conexao.Close();                 
                }

                return qtdEstoque;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                conexao.Close();
                return 0;
            }
        }

        #endregion
    }
}