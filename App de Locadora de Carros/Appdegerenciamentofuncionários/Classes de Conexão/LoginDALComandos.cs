using System.Data.SqlClient;

namespace Appdegerenciamentofuncionários.Classes_de_Conexão
{
    class LoginDALComandos
    {
        /*possui recebe falso inicialmente,pois se o sistema não entrar no if do try catch,ele ja vai estar retornando falso
         * assim não sendo necessário utilizar um else*/

        public bool possui = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;

        //Verifica no banco de dados se as informações existem,retornando um valor booleano(V,F)
        public bool verifylogin(string login, string senha)
        {
            //linhas sql para verificar se o banco de dados possui os dados
            cmd.CommandText = "select * from users where usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            //Esse código dentro do try - catch é quem vai fazer toda execução das linhas acima.
            try
            {
                /*Pega a informação,armazena na variável dr(datareader - leitor de dados)verifica se possui informação solicitada
                 * retornando true para a variavel "possui"*/
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    possui = true;
                   
                }
                con.desconectar();
                dr.Close();

            }
            //Mensagem geral para qualquer erro gerado no banco de dados,podendo ser tratado posteriormente.
            catch (SqlException)
            {
                this.mensagem = "Erro na verificação com o banco de dados!";
            }

            return possui;
        }

        public string cadastrar(string usuario, string senha, string Confsenha, string email)
        {

            //Reaproveitamento de variável,dxando como falso para saber qual a mensagem exibida.
            possui = false;
            //comandos para inserir no banco de dados,e retornar se deu certo ou não a partir de mensagem

            if (senha.Equals(Confsenha))
            {
                cmd.CommandText = "insert into users values (@usuario,@senha,@email)";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);


                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";

                    //Reaproveitamento de variável para saber qual mensagem virá do sistema.

                    possui = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o banco de dados!";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            

            return mensagem;
        }
    }
}
