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
    public partial class RegisteraCar_Screen : Form
    {
        public RegisteraCar_Screen()
        {
            InitializeComponent();
        }

        private void BackButn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            CadVeiculo cadveiculo = new CadVeiculo();

            cadveiculo.cadastrarcarros(nomeveictxtbox.Text, placatxtbox.Text, chassitxtbox.Text, combustiveltxtbox.Text);

            if (nomeveictxtbox.Text == string.Empty||placatxtbox.Text==string.Empty||chassitxtbox.Text  == string.Empty|| combustiveltxtbox.Text==string.Empty)
            {
                MessageBox.Show("Insira um valor válido nos campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {

                MessageBox.Show("Cadastro efetuado com sucesso", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void combustiveltxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
