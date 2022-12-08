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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //1°passo = Get Dados(obj Cliente)
                Cliente obj = new Cliente();
                obj._nome = txtNome.Text;
                obj._rg = txtRg.Text;
                obj._cpf = txtCpf.Text;
                obj._email = txtEmail.Text;
                obj._telefone = txtTelefone.Text;
                obj._celular = txtCelular.Text;
                obj._cep = txtCep.Text;
                obj._endereco = txtEndereco.Text;
                obj._numero = int.Parse(txtNumero.Text);
                obj._complemento = txtComplemento.Text;
                obj._bairro = txtBairro.Text;
                obj._cidade = txtCidade.Text;
                obj._estado = txtEstado.Text;

                //2°passo = criar obj clientedao e chamar método cadastrarCliente;
                ClienteDAO dao = new ClienteDAO();
                dao.cadastrarCliente(obj);

                new Helpers().LimparTela(this);

                dgvCliente.DataSource = dao.ListarCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Cadastrar Cliente, verifique todos os Campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvCliente);

            ClienteDAO dao = new ClienteDAO();
            dgvCliente.DataSource = dao.ListarCliente();

            lblCodigo.Enabled = false;
            txtCodigo.Enabled = false;

            if (tcCadastroCliente.SelectedTab == tpCadastroCliente)
            {
                lblTituloCadClie.Text = "Cadastro de Cliente";
            }
            else if (tcCadastroCliente.SelectedTab == tpConsultaCliente)
            {
                lblTituloCadClie.Text = "Consulta de Clientes";

                btnSalvar.Visible = false;
                btnNovo.Visible = false;
                btnAlterar.Visible = false;
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar dados da linha selecionada;
            txtCodigo.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dgvCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dgvCliente.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dgvCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dgvCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = dgvCliente.CurrentRow.Cells[12].Value.ToString();
            txtEstado.Text = dgvCliente.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia Dados Pessoais;
            tcCadastroCliente.SelectedTab = tpCadastroCliente;

            lblCodigo.Enabled = true;
            txtCodigo.Enabled = true;

            lblTituloCadClie.Text = "Dados do Cliente";
            btnSalvar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão excluir;
                Cliente obj = new Cliente();

                //get codigo;
                obj._codigo = int.Parse(txtCodigo.Text);

                ClienteDAO dao = new ClienteDAO();

                dao.ExcluirCliente(obj);

                //Atualizar DataGridView;

                dgvCliente.DataSource = dao.ListarCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Excluir Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível Alterar Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //1°passo = Get Dados(obj Cliente)
                    Cliente obj = new Cliente();
                    obj._nome = txtNome.Text;
                    obj._rg = txtRg.Text;
                    obj._cpf = txtCpf.Text;
                    obj._email = txtEmail.Text;
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

                    //2°passo = criar obj clientedao e chamar método alterarCliente;                                      
                    ClienteDAO dao = new ClienteDAO();
                    dao.AlterarCliente(obj);
                    
                    new Helpers().LimparTela(this);
                    
                    //Recarregando dgv:
                    dgvCliente.DataSource = dao.ListarCliente();

                    btnSalvar.Enabled = true;

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;

                    lblTituloCadClie.Text = "Cadastro de Cliente";
                }
                catch (Exception)
                {
                    MessageBox.Show($"Não foi possível Alterar");
                }
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Botão pesquisar;
            string nome = txtNomeConsulta.Text;

            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.BuscarCliente(nome);

            if (dgvCliente.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado com este nome");
                dgvCliente.DataSource = dao.ListarCliente();
            }
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            dgvCliente.DataSource = dao.ListarClientePorNome(nome);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Botão consultar CEP;

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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                new Helpers().LimparTela(this);

                btnSalvar.Enabled = true;

                lblCodigo.Enabled = false;
                txtCodigo.Enabled = false;

                lblTituloCadClie.Text = "Cadastro de Cliente";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Limpar Formulário", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tcCadastroCliente_Selected(object sender, TabControlEventArgs e)
        {
            var layouts = new Layout();
            var dao = new ClienteDAO(); 

            if (tcCadastroCliente.SelectedIndex == 0)
            {
                lblTituloCadClie.Text = "Cadastro de Cliente";

                btnSalvar.Visible = true;
                btnNovo.Visible = true;
                btnAlterar.Visible = true;

                if (btnSalvar.Enabled == false)
                {
                    lblTituloCadClie.Text = "Dados do Cliente";
                }
                else if (btnSalvar.Enabled == true)
                {
                    dgvCliente.DataSource = dao.ListarCliente();

                    lblTituloCadClie.Text = "Cadastro de Cliente";

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;                    
                }
            }
            else if (tcCadastroCliente.SelectedIndex == 1)
            {              
                layouts.LayoutDataGridView(dgvCliente);

                lblTituloCadClie.Text = "Consulta de Clientes";

                btnSalvar.Visible = false;
                btnNovo.Visible = false;
                btnAlterar.Visible = false;                
            }
        }
    }
}