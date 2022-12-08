using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;

            dataInicio = DateTime.Parse(dtpInicio.Value.ToString("yyyy-MM-dd"));
            dataFim = DateTime.Parse(dtpFim.Value.ToString("yyyy-MM-dd"));

            var dao = new VendaDAO();
            dgvHistorico.DataSource = dao.ListarVendasPorPeriodo(dataInicio, dataFim);
            
            if (dgvHistorico.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma venda encontrada neste período");

                dgvHistorico.DataSource = dao.ListarVendas();
            }                       
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            var layouts = new Layout();
            layouts.LayoutDataGridView(dgvHistorico);

            var dao = new VendaDAO();
            dgvHistorico.DataSource = dao.ListarVendas();            
        }

        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var venda = new Venda();
            string nomeCliente;
            int idVenda;

            idVenda = int.Parse(dgvHistorico.CurrentRow.Cells[0].Value.ToString());
            nomeCliente = dgvHistorico.CurrentRow.Cells[2].Value.ToString();
            venda.data_venda = DateTime.Parse(dgvHistorico.CurrentRow.Cells[1].Value.ToString());
            venda.total_venda = decimal.Parse(dgvHistorico.CurrentRow.Cells[3].Value.ToString());
            venda.obs = dgvHistorico.CurrentRow.Cells[4].Value.ToString();

            var frm = new Frmdetalhes(venda, nomeCliente, idVenda);
            frm.ShowDialog();
        }
    }
}
