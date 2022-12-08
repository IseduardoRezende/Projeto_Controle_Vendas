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
    public class ClienteDAO //Todos métodos relacionados ao SQL:
    {
        private SqlConnection _conexao;

        public ClienteDAO()
        {
            this._conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarCliente
        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                //1° - Definir comando sql - insert into && values;
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade, estado)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep ,@endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2° - Organizar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, _conexao);
                executacmd.Parameters.AddWithValue("@nome", obj._nome);
                executacmd.Parameters.AddWithValue("@rg", obj._rg);
                executacmd.Parameters.AddWithValue("@cpf", obj._cpf);
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

                //3° - Abrir a conexão e executar o cmd sql
                _conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso ! ");

                _conexao.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Aconteceu um erro, verifique: " + error);                
            }
        }
        #endregion

        #region AlterarCliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                //1° - Definir comando sql - insert into && values;
                string sql = @"update tb_clientes set nome=@nome,rg=@rg,cpf=@cpf,email=@email,telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,
                                bairro=@bairro,cidade=@cidade, estado=@estado
                                    where id=@id";

                //2° - Organizar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, _conexao);
                executacmd.Parameters.AddWithValue("@nome", obj._nome);
                executacmd.Parameters.AddWithValue("@rg", obj._rg);
                executacmd.Parameters.AddWithValue("@cpf", obj._cpf);
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

                //3° - Abrir a conexão e executar o cmd sql
                _conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com sucesso ! ");

                _conexao.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Aconteceu um erro, verifique: " + error);
            }
        }

        #endregion

        #region ExcluirCliente
        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                //1° - Definir comando sql - insert into && values;
                string sql = @"delete from tb_clientes where id = @id";

                //2° - Organizar o comando sql
                SqlCommand executacmd = new SqlCommand(sql, _conexao);

                executacmd.Parameters.AddWithValue("@id", obj._codigo);               

                //3° - Abrir a conexão e executar o cmd sql
                _conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluído com sucesso ! ");

                //Fechar Conexão;
                _conexao.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("Aconteceu um erro, verifique: " + error);
            }
        }

        #endregion

        #region ListarClientes
        public DataTable ListarCliente()
        {
            try
            {
                //1°passo - Criar datatable e cmd sql
                DataTable tabelaCliente = new DataTable();

                string sql = "select * from tb_clientes";

                //2°passo - Organizar cmd sql e exe
                SqlCommand executacmd = new SqlCommand(sql, _conexao);

                _conexao.Open();
                executacmd.ExecuteNonQuery();

                //3°passo - Criar o SQLDataAdapter para preencher dados do datatable 
                SqlDataAdapter sqlData = new SqlDataAdapter(executacmd);
                sqlData.Fill(tabelaCliente);

                _conexao.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando sql " + ex);                
                return null;
            }
        }

        #endregion

        #region BuscarCliente
        public DataTable BuscarCliente(string nome)
        {
            try
            {
                //1°passo - Criar datatable e cmd sql
                DataTable tabelaCliente = new DataTable();

                string sql = "select * from tb_clientes where nome = @nome";

                //2°passo - Organizar cmd sql e exe
                SqlCommand executacmd = new SqlCommand(sql, _conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                _conexao.Open();
                executacmd.ExecuteNonQuery();

                //3°passo - Criar o SQLDataAdapter para preencher dados do datatable 
                SqlDataAdapter sqlData = new SqlDataAdapter(executacmd);
                sqlData.Fill(tabelaCliente);

                _conexao.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando sql " + ex);
                return null;
            }
        }
        #endregion

        #region PesquisarCliente
        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                //1°passo - Criar datatable e cmd sql
                DataTable tabelaCliente = new DataTable();

                string sql = "select * from tb_clientes where nome like @nome";

                //2°passo - Organizar cmd sql e exe
                SqlCommand executacmd = new SqlCommand(sql, _conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                _conexao.Open();
                executacmd.ExecuteNonQuery();

                //3°passo - Criar o SQLDataAdapter para preencher dados do datatable 
                SqlDataAdapter sqlData = new SqlDataAdapter(executacmd);
                sqlData.Fill(tabelaCliente);

                _conexao.Close();
                return tabelaCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando sql " + ex);
                return null;
            }
        }
        #endregion

        #region RetornaIdClientePorCpf
        public Cliente RetornaClientePorCpf(string cpf)
        {
            try
            {
                var obj = new Cliente();

                string sql = "select * from tb_clientes where cpf = @cpf";
                                                                
                var executaCmd = new SqlCommand(sql, _conexao);
                executaCmd.Parameters.AddWithValue("@cpf", cpf);

                _conexao.Open();

                //Retornando apenas um valor e não vários: 

                SqlDataReader dr = executaCmd.ExecuteReader();

                if (dr.Read())
                {
                    obj._codigo = int.Parse(dr.GetInt32(0).ToString());
                    obj._nome = dr.GetString(1);                                                                

                    _conexao.Close();
                    return obj;
                }                                                   
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                    _conexao.Close();
                    return null;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);                
                return null;
            }
        }

        #endregion
    }
}
