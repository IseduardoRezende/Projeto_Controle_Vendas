using Google.Protobuf.WellKnownTypes;
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
    public partial class Frmvendas : Form
    {
        Cliente cliente = new Cliente();

        ClienteDAO daoCli = new ClienteDAO();

        Produto produto = new Produto();

        ProdutoDAO daoProd = new ProdutoDAO();

        //Variáveis para guardar dados para enviar ao dgv:

        int qtd;
        decimal preco;
        decimal subtotal, total;

        //DataTable leva dados até o dgv: no caso é o carrinho;

        //DataTable salva os dados na memória e o dgv mostra todos estes dados;

        DataTable carrinho = new DataTable();


        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            dgvVendas.DataSource = carrinho;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //13 == representação da tecla enter

            try
            {
                if (e.KeyChar == 13)
                {
                    cliente = daoCli.RetornaClientePorCpf(txtCpf.Text);

                    if (cliente != null)
                    {
                        txtNome.Text = cliente._nome;
                    }
                    else
                    {
                        txtNome.Text = string.Empty;
                        txtCpf.Clear();
                        txtCpf.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CPF do Cliente está errado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    produto = daoProd.RetornaProdutoPorId(int.Parse(txtCodigo.Text));

                    if (produto != null)
                    {
                        txtDescricao.Text = produto.Descricao;
                        txtPreco.Text = produto.Preco.ToString();
                    }
                    else
                    {
                        txtCodigo.Clear();
                        txtCodigo.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Código do produto está errado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvVendas);

            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Removendo Item:

                decimal subproduto = decimal.Parse(dgvVendas.CurrentRow.Cells[4].Value.ToString());

                //2º recebendo o índice da linha do dgv que irei remover atráves de uma variável:            

                int indice = dgvVendas.CurrentRow.Index;

                //Atribuindo a linha que será removida ao meu DataTable passando o índice;

                DataRow linha = carrinho.Rows[indice];

                //Removendo linha do meu DataTable:

                carrinho.Rows.Remove(linha);

                //Aceitando Muidanças no dt:

                carrinho.AcceptChanges();

                MessageBox.Show("Item removido do carrinho com sucesso !");

                if (dgvVendas.Rows.Count == 0)
                {
                    txtPrecoTotal.Text = string.Empty;
                    return;
                }
                else
                {
                    total -= subproduto;

                    txtPrecoTotal.Text = total.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao remover produto do carrinho");
            }
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            if (dgvVendas.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum produto adicionado ao carrinho de compras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if (txtCpf.Text == string.Empty && txtNome.Text == string.Empty || cliente == null || cliente._codigo == 0)
            {
                MessageBox.Show("Nenhum Cliente inserido para compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                var frm = new Frmpagamentos(cliente, carrinho, decimal.Parse(txtPrecoTotal.Text.ToString()), DateTime.Parse(txtData.Text.ToString()));
                frm.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cancelar compra ?", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void Frmvendas_Activated(object sender, EventArgs e)
        {
            if (dgvVendas.Rows.Count >= 1)
            {
                foreach (DataRow linhas in carrinho.Rows)
                {
                    if (int.Parse(linhas[2].ToString()) > daoProd.RetornaEstoqueAtualDoProduto(int.Parse(linhas[0].ToString())))
                    {
                        this.Close();
                    }
                    else if (int.Parse(linhas[2].ToString()) <= daoProd.RetornaEstoqueAtualDoProduto(int.Parse(linhas[0].ToString())))
                    {
                        return;
                    }
                }
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtQtdEstoque.Text);

                preco = decimal.Parse(txtPreco.Text);

                if (daoProd.RetornaEstoqueAtualDoProduto(int.Parse(txtCodigo.Text)) < qtd)
                {
                    MessageBox.Show("O número inserido ultrapassou a quantidade existente no estoque", "Atenção, repor estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtQtdEstoque.Text = string.Empty;
                    txtQtdEstoque.Focus();
                    return;
                }
                else
                {
                    subtotal = qtd * preco;

                    total += subtotal;

                    carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDescricao.Text, qtd, preco, subtotal);

                    txtPrecoTotal.Text = total.ToString();

                    txtDescricao.Clear();
                    txtPreco.Clear();
                    txtQtdEstoque.Clear();

                    txtCodigo.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao levar produto ao carrinho", MessageBoxIcon.Error.ToString());
            }
        }
    }
}