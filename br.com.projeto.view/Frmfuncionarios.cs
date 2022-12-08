using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Implementando dao.CadastrarFuncionario();

                Funcionario obj = new Funcionario();

                //Pegando dados de todos os campos;

                obj._nome = txtNome.Text;
                obj._rg = txtRg.Text;
                obj._cpf = txtCpf.Text;
                obj._email = txtEmail.Text;
                obj.Senha = txtSenha.Text;
                obj.Cargo = txtCargo.Text;
                obj.Nivel_Acesso = txtNivel.Text;
                obj._telefone = txtTelefone.Text;
                obj._celular = txtCelular.Text;
                obj._cep = txtCep.Text;
                obj._endereco = txtEndereco.Text;
                obj._numero = int.Parse(txtNumero.Text);
                obj._complemento = txtComplemento.Text;
                obj._bairro = txtBairro.Text;
                obj._cidade = txtCidade.Text;
                obj._estado = txtEstado.Text;

                //Criar obj FuncionarioDAO;

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.CadastrarFuncionario(obj);

                new Helpers().LimparTela(this);

                //Recarregando a dgv;

                dgvFuncionario.DataSource = dao.ListarFuncionario();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Cadastrar Cliente, verifique todos os Campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvFuncionario);

            FuncionarioDAO dao = new FuncionarioDAO();
            dgvFuncionario.DataSource = dao.ListarFuncionario();

            lblCodigo.Enabled = false;
            txtCodigo.Enabled = false;

            if (tcCadastroFunc.SelectedTab == tpCadastroFunc)
            {
                lblTituloCadFunc.Text = "Cadastro de Funcionário";
            }
            else if (tcCadastroFunc.SelectedTab == tpConsultaFunc)
            {
                lblTituloCadFunc.Text = "Consulta de Funcionários";

                btnAlterar.Visible = false;
                btnNovo.Visible = false;
                btnSalvar.Visible = false;
            }
        }

        //Seleciona Click de usuário na tabela para levar a tela de Cadastro:
        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFuncionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvFuncionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvFuncionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvFuncionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dgvFuncionario.CurrentRow.Cells[5].Value.ToString();
            txtCargo.Text = dgvFuncionario.CurrentRow.Cells[6].Value.ToString();
            txtNivel.Text = dgvFuncionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = dgvFuncionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = dgvFuncionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = dgvFuncionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = dgvFuncionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = dgvFuncionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = dgvFuncionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = dgvFuncionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = dgvFuncionario.CurrentRow.Cells[15].Value.ToString();
            txtEstado.Text = dgvFuncionario.CurrentRow.Cells[16].Value.ToString();

            tcCadastroFunc.SelectedTab = tpCadastroFunc;

            lblCodigo.Enabled = true;
            txtCodigo.Enabled = true;

            lblTituloCadFunc.Text = "Dados do Funcionário";
            btnSalvar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj._codigo = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(obj);

            //Recarregando a tabela dgvFuncionario:

            dgvFuncionario.DataSource = dao.ListarFuncionario();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível Alterar Funcionário", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Funcionario obj = new Funcionario();
                    obj._nome = txtNome.Text;
                    obj._rg = txtRg.Text;
                    obj._cpf = txtCpf.Text;
                    obj._email = txtEmail.Text;
                    obj.Senha = txtSenha.Text;
                    obj.Cargo = txtCargo.Text;
                    obj.Nivel_Acesso = txtNivel.Text;
                    obj._telefone = txtTelefone.Text;
                    obj._celular = txtCelular.Text;
                    obj._cep = txtCep.Text;
                    obj._endereco = txtEndereco.Text;
                    obj._numero = int.Parse(txtNumero.Text);
                    obj._complemento = txtComplemento.Text;
                    obj._bairro = txtBairro.Text;
                    obj._cidade = txtCidade.Text;
                    obj._estado = txtEstado.Text;

                    obj._codigo = int.Parse(txtCodigo.Text);

                    FuncionarioDAO dao = new FuncionarioDAO();
                    dao.AlterarFuncionario(obj);

                    new Helpers().LimparTela(this);

                    dgvFuncionario.DataSource = dao.ListarFuncionario();

                    btnSalvar.Enabled = true;

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;

                    lblTituloCadFunc.Text = "Cadastro de Funcionário";
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                new Helpers().LimparTela(this);

                btnSalvar.Enabled = true;

                lblCodigo.Enabled = false;
                txtCodigo.Enabled = false;

                lblTituloCadFunc.Text = "Cadastro de Funcionário";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Limpar Formulário", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dgvFuncionario.DataSource = dao.BuscarPorNome(nome);

            if (dgvFuncionario.Rows.Count == 0 || txtNomeConsulta.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não encontrado");
                dgvFuncionario.DataSource = dao.ListarFuncionario();
            }
        }   

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;

                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");
            }
        }

        private void tcCadastroFunc_Selected(object sender, TabControlEventArgs e)
        {
            var layouts = new Layout();
            var dao = new FuncionarioDAO();

            if (tcCadastroFunc.SelectedIndex == 0)
            {
                lblTituloCadFunc.Text = "Cadastro de Funcionário";

                btnAlterar.Visible = true;
                btnNovo.Visible = true;
                btnSalvar.Visible = true;

                if (btnSalvar.Enabled == false)
                {
                    lblTituloCadFunc.Text = "Dados do Funcionário";
                }
                else if (btnSalvar.Enabled == true)
                {
                    dgvFuncionario.DataSource = dao.ListarFuncionario();

                    lblTituloCadFunc.Text = "Cadastro de Funcionário";

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;
                }
            }
            else if (tcCadastroFunc.SelectedIndex == 1)
            {
                layouts.LayoutDataGridView(dgvFuncionario);

                lblTituloCadFunc.Text = "Consulta de Funcionários";

                btnAlterar.Visible = false;
                btnNovo.Visible = false;
                btnSalvar.Visible = false;
            }
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();
            dgvFuncionario.DataSource = dao.ListarPorNome(nome);
        }
    }
}
