using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Appdegerenciamentofuncionários.Classes_de_Conexão
{
    class CadAfiliado
    {
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();

        public void cadastrarafiliado(string endereco,string bairro,string número,string gerente,string codloja)
        {
            cmd.CommandText = "insert into afiliado values (@endereco,@bairro,@numero,@gerente,@codloja)";
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@bairro",bairro);
            cmd.Parameters.AddWithValue("@numero",número);
            cmd.Parameters.AddWithValue("@gerente",gerente);
            cmd.Parameters.AddWithValue("@codloja",codloja);
            con.executarcomandossql(cmd);
        }
    }
}
