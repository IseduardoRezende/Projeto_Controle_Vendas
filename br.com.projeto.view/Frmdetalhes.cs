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
    public partial class Frmdetalhes : Form
    {
        int idVenda;

        public Frmdetalhes(Venda venda, string nomeCliente, int idVenda)
        {
            InitializeComponent();

            txtNomeCliente.Text = nomeCliente.ToString();
            txtDataVenda.Text = venda.data_venda.ToShortDateString();
            txtTotalVenda.Text = venda.total_venda.ToString();
            txtObs.Text = venda.obs.ToString();

            this.idVenda = idVenda;
        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvDadosVenda);

            var dao = new ItemVendaDAO();
            dgvDadosVenda.DataSource = dao.ListaItensPorVenda(idVenda);
        }
    }
}
