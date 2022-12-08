using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.projeto.model
{
    public class Cliente
    {
        //Atributos de Cliente para Tela;

        //Classe Modelo de Clientes;

        public int _codigo { get; set; }
        public string _nome { get; set; }   //Propriedades;
        public string _rg { get; set; }
        public string _cpf { get; set; }
        public string _email { get; set; }
        public string _telefone { get; set; }
        public string _celular { get; set; }
        public string _cep { get; set; }
        public string _endereco { get; set; }
        public int _numero { get; set; }
        public string _complemento { get; set; }
        public string  _bairro { get; set; }
        public string _cidade { get; set; }
        public string _estado { get; set; }
    }
}