using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using Projeto_Controle_Vendas.br.com.projeto.view;
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
    public class FuncionarioDAO
    {
        private SqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarFuncionario
        public void CadastrarFuncionario(Funcionario obj)
        {
            try                 //1° passo Definir o comando sql - Insert into
            {
                string sql = @"insert into tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                                values (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone ,@celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2° passo Organizar os comando sql, adicionar;

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj._nome);
                executacmd.Parameters.AddWithValue("@rg", obj._rg);
                executacmd.Parameters.AddWithValue("@cpf", obj._cpf);
                executacmd.Parameters.AddWithValue("@email", obj._email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_Acesso);
                executacmd.Parameters.AddWithValue("@telefone", obj._telefone);
                executacmd.Parameters.AddWithValue("@celular", obj._celular);
                executacmd.Parameters.AddWithValue("@cep", obj._cep);
                executacmd.Parameters.AddWithValue("@endereco", obj._endereco);
                executacmd.Parameters.AddWithValue("@numero", obj._numero);
                executacmd.Parameters.AddWithValue("@complemento", obj._complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj._bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj._cidade);
                executacmd.Parameters.AddWithValue("@estado", obj._estado);

                //3° Finalizando conexão

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso !");

                //4°Fechando conexão
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro " + ex);
            }
        }

        #endregion

        #region AlterarFuncionario
        public void AlterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"update tb_funcionarios set nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, cargo=@cargo, nivel_acesso=@nivel_acesso,
                                telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro,
                                  cidade=@cidade, estado=@estado where id=@id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj._nome);
                executacmd.Parameters.AddWithValue("@rg", obj._rg);
                executacmd.Parameters.AddWithValue("@cpf", obj._cpf);
                executacmd.Parameters.AddWithValue("@email", obj._email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel_Acesso);
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

                MessageBox.Show("Funcionário alterado com Sucesso !");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Funcionário " + ex);
            }
        }

        #endregion

        #region ExcluirFuncionario
        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "delete from tb_funcionarios where id= @id";

                SqlCommand executacmd = new SqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj._codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário excluído com Sucesso !");

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exclusão Falha: " + ex);
            }
        }

        #endregion

        #region ListarFuncionario
        public DataTable ListarFuncionario()
        {
            try
            {
                DataTable tabelaFuncionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                SqlCommand executacmd = new SqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(executacmd);
                sqlDataAdapter.Fill(tabelaFuncionario);

                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar Funcionários " + ex);
                return null;
            }
        }

        #endregion

        #region BuscarFuncPorNome
        public DataTable BuscarPorNome(string nome)
        {
            try
            {
                DataTable dataTable = new DataTable();

                string sql = "select * from tb_funcionarios where nome = @nome";

                SqlCommand executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();

                executaCmd.ExecuteNonQuery();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(executaCmd);
                dataAdapter.Fill(dataTable);

                conexao.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro : {ex}");
                return null;
            }
        }

        #endregion

        #region ListarPorNome
        public DataTable ListarPorNome(string nome)
        {
            try
            {
                DataTable tabelaFunc = new DataTable();

                string sql = "select * from tb_funcionarios where nome like @nome";

                SqlCommand executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(executaCmd);
                adapter.Fill(tabelaFunc);

                conexao.Close();

                return tabelaFunc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return null;
            }
        }

        #endregion

        #region EfetuaLogin

        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios 
                               where email = @email and senha = @senha";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@email", email);
                executaCmd.Parameters.AddWithValue("@senha", senha);

                conexao.Open();

                //Leitor de dados SqlDataReader:
                SqlDataReader dr = executaCmd.ExecuteReader();

                if (dr.Read())
                {
                    string nivelAcesso = (string)dr["nivel_acesso"];
                    string nome = (string)dr["nome"];

                    MessageBox.Show("Acesso efetuado, " + nivelAcesso, "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var menu = new Frmmenu(nome, nivelAcesso);                    

                    if (nivelAcesso.Equals("Administrador"))
                    {
                        menu.Show();
                    }
                    else if (nivelAcesso.Equals("Vendedor"))
                    {
                        menu.Show();
                    }

                    conexao.Close();
                    return true;
                }
                else if (email == string.Empty && senha == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos para ter acesso ao sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    conexao.Close();
                    return false;
                }
                else
                {
                    MessageBox.Show("Email ou Senha incorretos", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexao.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}");
                return false;
            }
        }

        #endregion
    }
}
