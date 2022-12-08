using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
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
    public class ItemVendaDAO
    {
        private SqlConnection conexao;

		public ItemVendaDAO()
		{
			this.conexao = new ConnectionFactory().GetConnection();
		}

        #region CadastraItemVenda

        public void CadastraItemVenda(ItemVenda obj)
        {
			try
			{
				string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
								values (@venda_id, @produto_id, @qtd, @subtotal)";

				var executaCmd = new SqlCommand(sql, conexao);
				executaCmd.Parameters.AddWithValue("@venda_id", obj.venda_id);
				executaCmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
				executaCmd.Parameters.AddWithValue("@qtd", obj.qtd);
				executaCmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

				conexao.Open();
				executaCmd.ExecuteNonQuery();

				conexao.Close();
            }
            catch (Exception ex)
			{
				MessageBox.Show("Erro" + ex);
			}
        }

        #endregion

        #region ListaItensPorVenda

		public DataTable ListaItensPorVenda(int vendaId)
		{
			try
			{
				var tabelaItensVenda = new DataTable();

				string sql =  @"select IV.Id  as 'Código',
								PR.descricao  as 'Descrição',
								IV.qtd		  as 'Quantidade',
								PR.preco      as 'Preço',
								IV.subtotal   as 'Subtotal'
								from tb_itensvendas as IV 
								join tb_produtos as PR on (IV.produto_id = PR.Id)
								where venda_id = @venda_id";

				var executaCmd = new SqlCommand(sql, conexao);
				executaCmd.Parameters.AddWithValue("@venda_id", vendaId);

				conexao.Open();
				executaCmd.ExecuteNonQuery();

				var dr = new SqlDataAdapter(executaCmd);
				dr.Fill(tabelaItensVenda);

				conexao.Close();
				return tabelaItensVenda;				
            }
			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex);
				return null;
			}
		}

        #endregion
    }
}
