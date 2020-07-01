using Appdegerenciamentofuncionários.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appdegerenciamentofuncionários.Telas_da_Aplicação
{
    public partial class Register_Screen : Form
    {
        public Register_Screen()
        {
            InitializeComponent();
        }

        private void BackButn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            //Criação de string mensagem que recebee o metodo cadastrar.
            String mensagem = controle.cadastrar(Txbuser.Text, Txbsenha.Text, TxbConfsenha.Text, Txbemail.Text);

            if (Txbuser.Text == string.Empty || Txbsenha.Text == string.Empty || TxbConfsenha.Text == string.Empty || Txbemail.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor válido nos campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (controle.possui)
            {
                MessageBox.Show(mensagem, "Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
