using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class VendaDAO
    {
        private SqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarVenda

        public void CadastrarVenda(Venda obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes)
							   values (@cliente_id, @data_venda, @total_venda, @observacoes)";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executaCmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
                executaCmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executaCmd.Parameters.AddWithValue("@observacoes", obj.obs);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar " + ex);
            }
        }

        #endregion

        #region ListarVendas
        public DataTable ListarVendas()
        {
            try
            {
                var tabelaHistorico = new DataTable();

                string sql =  @"select V.Id		 as 'Código',
                                V.data_venda	 as 'Data da venda',
                                CL.nome			 as 'Cliente',
                                V.total_venda	 as 'Total',
                                V.observacoes    as 'Obs'
                                from tb_vendas   as V 
                                join tb_clientes as CL on (V.cliente_id = CL.Id)";

                var executaCmd = new SqlCommand(sql, conexao);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                var da = new SqlDataAdapter(executaCmd);
                da.Fill(tabelaHistorico);

                conexao.Close();
                return tabelaHistorico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return null;
            }
        }

        #endregion

        #region RetornaIdUltimaVenda

        public int RetornaIdUltimaVenda()
        {
            try
            {
                //Retorna um id == integer;

                int idVenda = 0;

                string sql = @"select max(id) id from tb_vendas";

                var executaCmd = new SqlCommand(sql, conexao);

                conexao.Open();

                SqlDataReader dr = executaCmd.ExecuteReader();

                if (dr.Read())
                {
                    idVenda = dr.GetInt32(0);
                }

                conexao.Close();
                return idVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar id " + ex);
                conexao.Close();
                return 0;
            }
        }

        #endregion

        #region ListaVendasPorPeriodo

        public DataTable ListarVendasPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var tabelaHistorico = new DataTable();

                string sql =  @"select V.Id		 as 'Código',
                                V.data_venda	 as 'Data da venda',
                                CL.nome			 as 'Cliente',
                                V.total_venda	 as 'Total',
                                V.observacoes    as 'Obs'
                                from tb_vendas   as V 
                                join tb_clientes as CL on (V.cliente_id = CL.Id)
                                where V.data_venda between @dataInicio and @dataFim";

                var executaCmd = new SqlCommand(sql, conexao);
                executaCmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                executaCmd.Parameters.AddWithValue("@dataFim", dataFim);

                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //SqlDataAdapter preenche os dados no DataTable;
                
                var da = new SqlDataAdapter(executaCmd);
                da.Fill(tabelaHistorico);

                conexao.Close();
                return tabelaHistorico;            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return null;
            }
        }

        #endregion
    }
}
