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
    public partial class Afilliate_Screen : Form
    {
        public Afilliate_Screen()
        {
            InitializeComponent();
        }

        private void BackButn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resgisterbtn1_Click(object sender, EventArgs e)
        {
            CadAfiliado afiliado = new CadAfiliado();
            afiliado.cadastrarafiliado(Adresstxtbox.Text,Bairrotxtbox.Text,Numbertxtbox.Text,Managertxtbox.Text,Codetxtbox.Text);
            if (Adresstxtbox.Text == string.Empty||Bairrotxtbox.Text== string.Empty||Numbertxtbox.Text==string.Empty||Managertxtbox.Text == string.Empty||Codetxtbox.Text == string.Empty)
            {
                MessageBox.Show("Insira um valor válido nos campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("Novo afiliado registrado com sucesso", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
