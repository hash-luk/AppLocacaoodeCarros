using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appdegerenciamentofuncionários.Classes_de_Conexão
{
    public class Conexão
    {
        //Utilizando um comando próprio do c# para instaciar uma conexão com o sqlserver

        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexão()
        {
            con.ConnectionString = @"Data Source=DESKTOP-HGA905G\SQLEXPRESS;Initial Catalog=DB Locação-de-carros;Integrated Security=True";
        }
        //faz a conexão com o baco de dados informado acima,retornando uma conexão sql
        public SqlConnection conectar()
        {
            //Verifica se a conexão está fechada e a abre caso esteja,retornando con.
            if(con.State== System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Classe que não retorna nada,para se desconectar do banco de dados
        public void desconectar()
        {
            //Verifica se a conexão está aberta e a fecha caso esteja.
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void executarcomandossql(SqlCommand c)
        {
            con.Open();
            c.Connection = con;
            c.ExecuteNonQuery();
            con.Close();
        }
    }
}
