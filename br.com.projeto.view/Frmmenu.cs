using Org.BouncyCastle.Asn1.X509;
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
    public partial class Frmmenu : Form
    {
        public Frmmenu(string nome, string nivelAcesso)
        {
            InitializeComponent();

            lblNomeApresentacao.Text = $"Olá,\n{nome}.";
            lblNomeUsuario.Text = "Funcionárioª: " + nome;
            lblDataAtual.Text = DateTime.Now.ToShortDateString();

            if (nivelAcesso.Equals("Vendedor"))
            {
                mnuFuncionarios.Enabled = false;
                mnuFornecedores.Enabled = false;
                mnuHistoricoVendas.Enabled = false;
            }
        }

        private void tHoraAtual_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = DateTime.Now.ToLongTimeString();
        }

        private void mnuCadastroClientes_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.ShowDialog();
        }

        private void mnuConsultaClientes_Click(object sender, EventArgs e)
        {
            //Usando modifiers...

            var frm = new Frmclientes();
            frm.tcCadastroCliente.SelectedTab = frm.tpConsultaCliente;
            frm.ShowDialog();
        }

        private void mnuCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            var frm = new Frmfuncionarios();
            frm.ShowDialog();
        }

        private void mnuConsultaFuncionarios_Click(object sender, EventArgs e)
        {
            var frm = new Frmfuncionarios();
            frm.tcCadastroFunc.SelectedTab = frm.tpConsultaFunc;
            frm.ShowDialog();
        }

        private void mnuCadastroFornecedores_Click(object sender, EventArgs e)
        {
            var frm = new Frmfornecedores();
            frm.ShowDialog();
        }

        private void mnuConsultaFornecedores_Click(object sender, EventArgs e)
        {
            var frm = new Frmfornecedores();
            frm.tcCadastroFornecedor.SelectedTab = frm.tpConsultaFornecedor;
            frm.ShowDialog();
        }

        private void mnuCadastroProdutos_Click(object sender, EventArgs e)
        {
            var frm = new Frmprodutos();
            frm.ShowDialog();
        }

        private void mnuConsultaProdutos_Click(object sender, EventArgs e)
        {
            var frm = new Frmprodutos();
            frm.tcCadastroProduto.SelectedTab = frm.tpConsultaProduto;
            frm.ShowDialog();
        }

        private void mnuNovaVenda_Click(object sender, EventArgs e)
        {
            var frm = new Frmvendas();
            frm.ShowDialog();
        }

        private void mnuHistoricoVendas_Click(object sender, EventArgs e)
        {
            var frm = new Frmhistorico();
            frm.ShowDialog();
        }

        private void mnuTrocarUsuario_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Certeza que deseja efetuar novo Login ?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                var frm = new Frmlogin();
                frm.Show();

                this.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja sair do sistema ? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }        
    }
}
