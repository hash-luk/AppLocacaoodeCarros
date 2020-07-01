using Appdegerenciamentofuncionários.Classes_de_Conexão;
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
    public partial class employeerecords_Screen : Form
    {
        public employeerecords_Screen()
        {
            InitializeComponent();
        }

        private void BackButn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cpflbl_Click(object sender, EventArgs e)
        {

        }

        private void CPFtxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registerbtn3_Click(object sender, EventArgs e)
        {
            CadFuncionario funcionario = new CadFuncionario();
            funcionario.cadastrarfuncionario(Nametxtbox.Text,CPFtxtbox.Text,Adresstxtbox.Text,Numbertxtbox.Text,Bairrotxtbox.Text,Admissiondatetxtbox.Text);
            if (Nametxtbox.Text == string.Empty||CPFtxtbox.Text==string.Empty||Adresstxtbox.Text == string.Empty||Numbertxtbox.Text == string.Empty||Bairrotxtbox.Text==string.Empty||Admissiondatetxtbox.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor válido nos campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bem-Vindo a nossa empresa!", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
