using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Appdegerenciamentofuncionários.Classes_de_Conexão
{
    class CadFuncionario
    {
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        //SqlDataReader dr;

        public void cadastrarfuncionario(string nome,string cpf,string endereco,string numero,string bairro,string iniciocontrato)
        {
            cmd.CommandText = "insert into empregados values(@nome,@cpf,@endereco,@numero,@bairro,@data_da_contratacao)";
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@cpf",cpf);
            cmd.Parameters.AddWithValue("@endereco",endereco);
            cmd.Parameters.AddWithValue("@numero",numero);
            cmd.Parameters.AddWithValue("@bairro",bairro);
            cmd.Parameters.AddWithValue("@data_da_contratacao",iniciocontrato);
            con.executarcomandossql(cmd);
        }
    }
}
