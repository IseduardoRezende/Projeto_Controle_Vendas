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

namespace Projeto_Controle_Vendas
{
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                new Helpers().LimparTela(this);

                btnSalvar.Enabled = true;

                lblCodigo.Enabled = false;
                txtCodigo.Enabled = false;

                lblTituloCadForn.Text = "Cadastro de Fornecedor";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Limpar Formulário", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor obj = new Fornecedor();
                obj._nome = txtNome.Text;
                obj.CNPJ = txtCNPJ.Text;
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

                FornecedorDAO dao = new FornecedorDAO();
                dao.CadastrarFornecedor(obj);

                new Helpers().LimparTela(this);

                dgvFornecedor.DataSource = dao.ListarFornecedor();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Cadastrar Fornecedor, verifique todos os Campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvFornecedor);

            FornecedorDAO dao = new FornecedorDAO();
            dgvFornecedor.DataSource = dao.ListarFornecedor();

            lblCodigo.Enabled = false;
            txtCodigo.Enabled = false;

            if (tcCadastroFornecedor.SelectedTab == tpCadastroFornecedor)
            {
                lblTituloCadForn.Text = "Cadastro de Fornecedor";
            }
            else if (tcCadastroFornecedor.SelectedTab == tpConsultaFornecedor)
            {
                lblTituloCadForn.Text = "Consulta de Fornecedores";

                btnAlterar.Visible = false;
                btnNovo.Visible = false;
                btnSalvar.Visible = false;
            }
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;

                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet data = new DataSet();
                data.ReadXml(xml);

                txtEndereco.Text = data.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = data.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = data.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = data.Tables[0].Rows[0]["complemento"].ToString();
                txtEstado.Text = data.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao encontrar CEP digitado, escreva manualmente");
            }
        }       

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível Alterar Fornecedor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Fornecedor obj = new Fornecedor();
                    obj._nome = txtNome.Text;
                    obj.CNPJ = txtCNPJ.Text;
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

                    FornecedorDAO dao = new FornecedorDAO();
                    dao.AlterarFornecedor(obj);

                    new Helpers().LimparTela(this);

                    dgvFornecedor.DataSource = dao.ListarFornecedor();
                    
                    btnSalvar.Enabled = true;

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;

                    lblTituloCadForn.Text = "Cadastro de Fornecedor";
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj._codigo = int.Parse(txtCodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.ExcluirFornecedor(obj);

            dgvFornecedor.DataSource = dao.ListarFornecedor();

            new Helpers().LimparTela(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dgvFornecedor.DataSource = dao.PesquisarFornecedor(nome);

            if (dgvFornecedor.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado com este nome");
                dgvFornecedor.DataSource = dao.ListarFornecedor();
            }
        }
        
        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();
            dgvFornecedor.DataSource = dao.BuscarPorNome(nome);
        }

        private void tcCadastroFornecedor_Selected(object sender, TabControlEventArgs e)
        {
            var layouts = new Layout();
            var dao = new FornecedorDAO();

            if (tcCadastroFornecedor.SelectedIndex == 0)
            {
                lblTituloCadForn.Text = "Cadastro de Fornecedor";

                btnAlterar.Visible = true;
                btnNovo.Visible = true;
                btnSalvar.Visible = true;

                if (btnSalvar.Enabled == false)
                {
                    lblTituloCadForn.Text = "Dados do Fornecedor";
                }
                else if (btnSalvar.Enabled == true)
                {
                    dgvFornecedor.DataSource = dao.ListarFornecedor();

                    lblTituloCadForn.Text = "Cadastro de Fornecedor";

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;
                }
            }
            else if (tcCadastroFornecedor.SelectedIndex == 1)
            {
                layouts.LayoutDataGridView(dgvFornecedor);

                lblTituloCadForn.Text = "Consulta de Fornecedores";

                btnAlterar.Visible = false;
                btnNovo.Visible = false;
                btnSalvar.Visible = false;
            }
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = dgvFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = dgvFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = dgvFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = dgvFornecedor.CurrentRow.Cells[11].Value.ToString();
            txtEstado.Text = dgvFornecedor.CurrentRow.Cells[12].Value.ToString();

            tcCadastroFornecedor.SelectedTab = tpCadastroFornecedor;

            lblCodigo.Enabled = true;
            txtCodigo.Enabled = true;

            lblTituloCadForn.Text = "Dados do Fornecedor";
            btnSalvar.Enabled = false;
        }
    }
}
