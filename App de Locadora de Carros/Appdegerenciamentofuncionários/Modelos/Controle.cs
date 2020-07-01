using Appdegerenciamentofuncionários.Classes_de_Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appdegerenciamentofuncionários.Modelos
{
    public class Controle
    {
        public bool possui;
        public string mensagem="";

        //Recebe valores do formulário,são passados como parametro pro método acesssar.
        public bool acessar(string login,string senha )
        {

            //Realiza a verificação,mandando os dados recebidos para o outro script como parametro.
            LoginDALComandos LoginDal = new LoginDALComandos();
            possui = LoginDal.verifylogin(login, senha);
            //Verifica se há algum erro,caso retorne algo o programa avisará.
            if (!LoginDal.mensagem.Equals(""))
            {
                this.mensagem = LoginDal.mensagem;
            }
            return possui;
        }

        //Método para o cadastro.
        public string cadastrar(string usuario,string senha,string Confsenha,string email)
        {
            LoginDALComandos LoginDal = new LoginDALComandos();
            this.mensagem = LoginDal.cadastrar(usuario,senha,Confsenha,email);


            /*se isso for verdadeiro a mensagem que virar é de sucesso,n precisa colocar o "=",
            pois o sistema já define isso como sendo verdadeiro*/
            if (LoginDal.possui)
            {
                this.possui = true;
            }


            return mensagem;
        }
    }
}
