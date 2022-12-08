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
    public partial class Frmpagamentos : Form
    {
        decimal total;

        Cliente cliente = new Cliente();

        DataTable carrinho = new DataTable();

        DateTime dataAtual;

        public Frmpagamentos(Cliente cliente, DataTable carrinho, decimal total, DateTime dataAtual)
        {
            InitializeComponent();

            this.cliente = cliente;
            this.carrinho = carrinho;
            this.total = total;
            this.dataAtual = dataAtual;

            txtTotal.Text = total.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //1º passo == Calcular o Pagamento:

            try
            {
                decimal v_Dinheiro, v_Cartao, troco, totalPago, total;                

                int qtd_Estoque, qtd_Comprada, estoqueAtualizado;

                v_Dinheiro = decimal.Parse(txtDinheiro.Text);
                v_Cartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                //Calcular totalPago:

                totalPago = v_Dinheiro;

                if (totalPago < total)
                {
                    MessageBox.Show("O total pago é insuficiente para o valor total da compra", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //Calcular troco:

                    troco = totalPago - total;

                    txtTroco.Text = troco.ToString();

                    //Cadastrar Vendas: 

                    var vendas = new Venda();
                    vendas.cliente_id = cliente._codigo;
                    vendas.data_venda = dataAtual;
                    vendas.total_venda = total;
                    vendas.obs = txtObservacoes.Text;

                    var v_Dao = new VendaDAO();                                      

                    v_Dao.CadastrarVenda(vendas);

                    //2° passo -- Percorrer os itens do meu carrinho/DataTable;

                    //3º passo == Cadastrar itens das vendas dentro do looping:

                    var prod_Dao = new ProdutoDAO();

                    foreach (DataRow linha in carrinho.Rows)
                    {
                        var itens = new ItemVenda();
                       
                        itens.venda_id   = v_Dao.RetornaIdUltimaVenda();
                        itens.produto_id = int.Parse(linha[0].ToString());
                        itens.qtd        = int.Parse(linha[2].ToString());
                        itens.subtotal   = decimal.Parse(linha[4].ToString());

                        //Baixa no Estoque:
                        
                        qtd_Estoque       = prod_Dao.RetornaEstoqueAtualDoProduto(itens.produto_id);                       
                        qtd_Comprada      = itens.qtd;
                        estoqueAtualizado =  qtd_Estoque - qtd_Comprada;

                        prod_Dao.BaixaNoEstoqueDeProdutos(itens.produto_id, estoqueAtualizado);

                        var itens_Dao = new ItemVendaDAO();
                        itens_Dao.CadastraItemVenda(itens);
                    }

                    if (troco != 0)
                    {
                        MessageBox.Show($"Troco é: {troco}R$", "Compra efetuada com Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    else if (troco == 0)
                    {
                        MessageBox.Show("Sem troco", "Compra efetuada com Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }

                    btnPagar.Visible = false;
                    txtDinheiro.Enabled = false;
                    txtObservacoes.Enabled = false;

                    this.Close();
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao efetuar compra ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            txtTroco.Text = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }
    }
}