using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Appdegerenciamentofuncionários.Classes_de_Conexão
{
    class CadVeiculo
    {
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();

        public void cadastrarcarros(string nomeveiculo, string placa, string chassi, string combustivel)
        {
            cmd.CommandText = "insert into Veiculos values(@nome,@placa,@chassi,@combustivel)";
            cmd.Parameters.AddWithValue("@nome", nomeveiculo);
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@chassi", chassi);
            cmd.Parameters.AddWithValue("@combustivel", combustivel);
            con.executarcomandossql(cmd);
        }
    }
}
