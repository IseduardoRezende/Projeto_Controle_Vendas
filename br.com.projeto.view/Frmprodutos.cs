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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();            
        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvProduto);

            FornecedorDAO f_dao = new FornecedorDAO();
            cbFornecedor.DataSource = f_dao.ListarFornecedor();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            dgvProduto.DataSource = dao.ListarProduto();

            lblCodigo.Enabled = false;
            txtCodigo.Enabled = false;

            if (tcCadastroProduto.SelectedTab == tpCadastroProduto)
            {
                lblTituloCadProd.Text = "Cadastro de Produto";
            }
            else if (tcCadastroProduto.SelectedTab == tpConsultaProduto)
            {
                lblTituloCadProd.Text = "Consulta de Produtos";

                btnAlterar.Visible = false;
                btnNovo.Visible = false;
                btnSalvar.Visible = false;
            }
        }     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto obj = new Produto();
                obj.Descricao = txtDescricao.Text;
                obj.Preco = decimal.Parse(txtPreco.Text);
                obj.QtdEstoque = int.Parse(txtQtdEstoque.Text);
                obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());

                ProdutoDAO dao = new ProdutoDAO();
                dao.CadastrarProduto(obj);

                new Helpers().LimparTela(this);

                dgvProduto.DataSource = dao.ListarProduto();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Cadastrar Produto, verifique todos os Campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                lblTituloCadProd.Text = "Cadastro de Produto";
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Limpar Formulário", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
            txtQtdEstoque.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = dgvProduto.CurrentRow.Cells[4].Value.ToString();

            tcCadastroProduto.SelectedTab = tpCadastroProduto;

            lblCodigo.Enabled = true;
            txtCodigo.Enabled = true;

            lblTituloCadProd.Text = "Dados do Produto";
            btnSalvar.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtQtdEstoque.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível Alterar Produto", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    var obj = new Produto();
                    obj.Descricao = txtDescricao.Text;
                    obj.Preco = decimal.Parse(txtPreco.Text);
                    obj.QtdEstoque = int.Parse(txtQtdEstoque.Text);
                    obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());
                    obj.id = int.Parse(txtCodigo.Text);

                    var dao = new ProdutoDAO();
                    dao.AlterarProdutos(obj);

                    new Helpers().LimparTela(this);

                    dgvProduto.DataSource = dao.ListarProduto();

                    btnSalvar.Enabled = true;

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;

                    lblTituloCadProd.Text = "Cadastro de Produto";
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro");
                }
            }            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var obj = new Produto();
            obj.id = int.Parse(txtCodigo.Text);

            var dao = new ProdutoDAO();

            dao.ExcluirProdutos(obj);
           
            new Helpers().LimparTela(this);

            dgvProduto.DataSource = dao.ListarProduto();
        }

        private void txtNomeConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtNomeConsulta.Text + "%";

            var dao = new ProdutoDAO();

            dgvProduto.DataSource = dao.BuscarPorNome(nome);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeConsulta.Text;

            var dao = new ProdutoDAO();

            dgvProduto.DataSource = dao.PesquisarProduto(nome);
            if (dgvProduto.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto encontrado");
                dgvProduto.DataSource = dao.ListarProduto();
            }
        }

        private void tcCadastroProduto_Selected(object sender, TabControlEventArgs e)
        {
            var layouts = new Layout();
            var dao = new ProdutoDAO();

            if (tcCadastroProduto.SelectedIndex == 0)
            {
                lblTituloCadProd.Text = "Cadastro de Produto";

                btnAlterar.Visible = true;
                btnNovo.Visible = true;
                btnSalvar.Visible = true;

                if (btnSalvar.Enabled == false)
                {
                    lblTituloCadProd.Text = "Dados do Produto";
                }
                else if (btnSalvar.Enabled == true)
                {
                    dgvProduto.DataSource = dao.ListarProduto();

                    lblTituloCadProd.Text = "Cadastro de Produto";

                    lblCodigo.Enabled = false;
                    txtCodigo.Enabled = false;
                }
            }
            else if (tcCadastroProduto.SelectedIndex == 1)
            {
                layouts.LayoutDataGridView(dgvProduto);

                lblTituloCadProd.Text = "Consulta de Produtos";

                btnAlterar.Visible = false;
                btnNovo.Visible = false;
                btnSalvar.Visible = false;
            }
        }
    }
}