using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.projeto.model
{
    public class Funcionario : Cliente
    {
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string Nivel_Acesso { get; set; }
    }
}
