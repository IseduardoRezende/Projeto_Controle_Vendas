using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.projeto.model
{
    public class Produto
    {
        public int id { get; set; }
        public string Descricao { get; set; }
        public decimal  Preco { get; set; }
        public int QtdEstoque { get; set; }
        public int for_id { get; set; }
    }
}
