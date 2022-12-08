using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class FornecedorDAO
    {
        private SqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFornecedor
       public void CadastrarFornecedor(Fornecedor obj)
       {
            try
            {
                string sql = @"insert into tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                                values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj._nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                executacmd.Parameters.AddWithValue("@email", obj._email);
                executacmd.Parameters.AddWithValue("@telefone", obj._telefone);
                executacmd.Parameters.AddWithValue("@celular", obj._celular);
                executacmd.Parameters.AddWithValue("@cep", obj._cep);
                executacmd.Parameters.AddWithValue("@endereco", obj._endereco);
                executacmd.Parameters.AddWithValue("@numero", obj._numero);
                executacmd.Parameters.AddWithValue("@complemento", obj._complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj._bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj._cidade);
                executacmd.Parameters.AddWithValue("@estado", obj._estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso !");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
       }

        #endregion

        #region ListarFornecedor
        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores";

                SqlCommand executacmd = new SqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }            
        }

        #endregion
        
        #region AlterarFornecedor
        public void AlterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update tb_fornecedores set nome=@nome, cnpj=@cnpj, email=@email, telefone=@telefone, celular=@celular,
                                cep=@cep, endereco=@endereco, @numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, 
                                estado=@estado where id=@id";                           

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj._nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                executacmd.Parameters.AddWithValue("@email", obj._email);
                executacmd.Parameters.AddWithValue("@telefone", obj._telefone);
                executacmd.Parameters.AddWithValue("@celular", obj._celular);
                executacmd.Parameters.AddWithValue("@cep", obj._cep);
                executacmd.Parameters.AddWithValue("@endereco", obj._endereco);
                executacmd.Parameters.AddWithValue("@numero", obj._numero);
                executacmd.Parameters.AddWithValue("@complemento", obj._complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj._bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj._cidade);
                executacmd.Parameters.AddWithValue("@estado", obj._estado);
                executacmd.Parameters.AddWithValue("@id", obj._codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com sucesso !");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
            }
        }


        #endregion

        #region ExcluirFornecedor
        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from tb_fornecedores where id=@id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj._codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluído com sucesso !");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }                          
        }

        #endregion

        #region BuscarPorNome
        public DataTable BuscarPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores where nome like @nome";

                SqlCommand executaxmd = new SqlCommand(sql, conexao);
                executaxmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaxmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executaxmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();

                return tabelaFornecedor;            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        #endregion

        #region PesquisarFornecedor
        public DataTable PesquisarFornecedor(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();

                string sql = "select * from tb_fornecedores where nome=@nome";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return null;                        
            }
        }
        
        #endregion
    }
}