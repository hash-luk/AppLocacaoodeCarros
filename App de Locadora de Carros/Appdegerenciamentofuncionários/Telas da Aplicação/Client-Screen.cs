using Appdegerenciamentofuncionários.Classes_de_Conexão;
using System;
using System.Windows.Forms;

namespace Appdegerenciamentofuncionários.Telas_da_Aplicação
{
    public partial class Client_Screen : Form
    {
        public Client_Screen()
        {
            InitializeComponent();
        }

        private void BackButn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerbtn2_Click(object sender, EventArgs e)
        {
            CadCliente cliente = new CadCliente();
            cliente.cadastrarcliente(Nomeclientetxtbox.Text, cpftxtbox.Text, habilitaçãotxtbox.Text, datainicialtxtbox.Text, datafinaltxtbox.Text);

            if (Nomeclientetxtbox.Text == string.Empty||cpftxtbox.Text == string.Empty||habilitaçãotxtbox.Text == string.Empty||datainicialtxtbox.Text==string.Empty||datafinaltxtbox.Text==string.Empty)
            {
                MessageBox.Show("Insira um valor válido nos campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Locação efetuada com sucesso", "Parabens", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
