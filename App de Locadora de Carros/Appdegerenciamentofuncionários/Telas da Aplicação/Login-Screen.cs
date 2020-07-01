using Appdegerenciamentofuncionários.Modelos;
using Appdegerenciamentofuncionários.Telas_da_Aplicação;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Appdegerenciamentofuncionários
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(Usertxb.Text, PasswordLabel.Text);
            if (Usertxb.Text == string.Empty || PasswordLabel.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor válido nos campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (controle.possui)
            {
                Menu_Screen menu = new Menu_Screen();
                menu.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos,vefrifique e tente novamente.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            Register_Screen registro = new Register_Screen();
            registro.ShowDialog();

        }

        private void ExitImage_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SupportImage_Click(object sender, EventArgs e)
        {
            Support_message suporte = new Support_message();
            suporte.ShowDialog();
        }

        private void ForgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://127.0.0.1:5500/index.html");
        }

        private void Usertxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
