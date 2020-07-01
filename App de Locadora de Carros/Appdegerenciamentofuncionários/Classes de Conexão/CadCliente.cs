using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Appdegerenciamentofuncionários.Classes_de_Conexão
{
    class CadCliente
    {
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();

        public void cadastrarcliente(string nome,string cpf,string cnh,string datacontratacao,string datatermino)
        {
            cmd.CommandText = "insert into clientes values(@nome,@cpf,@cnh,@iniciocontrato,@fimcontrato)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cnh", cnh);
            cmd.Parameters.AddWithValue("@iniciocontrato",datacontratacao);
            cmd.Parameters.AddWithValue("@fimcontrato", datatermino);
            con.executarcomandossql(cmd);
        }
    }
}
