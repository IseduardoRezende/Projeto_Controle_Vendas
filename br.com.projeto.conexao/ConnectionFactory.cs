using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Projeto_Controle_Vendas.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        //Unico método para conectar ao bd;

        //private static string server = @"EDUARDO\SQLEXPRESS";
        //private static string dataBase = "BDVENDAS";

        //public static string StrCon
        //{
        //    get { return "Data Source=" + server + "; Integrated Security=false;Initial Catalog=" + dataBase ; } 
        //}

        public SqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["BDVENDAS"].ConnectionString;

            return new SqlConnection(conexao);
        }
    }
}
