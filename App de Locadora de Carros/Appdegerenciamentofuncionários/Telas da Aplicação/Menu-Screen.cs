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
    public partial class Menu_Screen : Form
    {
        public Menu_Screen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Afilliate_Screen afiliado = new Afilliate_Screen();
            afiliado.ShowDialog();
        }

        private void Regitreumcarrobtn_Click(object sender, EventArgs e)
        {
            RegisteraCar_Screen registrocarro = new RegisteraCar_Screen();
            registrocarro.ShowDialog();
        }

        private void Novoclientebtn_Click(object sender, EventArgs e)
        {
            Client_Screen cliente = new Client_Screen();
            cliente.ShowDialog();
        }

        private void Cadastrodefuncionáriosbtn_Click(object sender, EventArgs e)
        {
            employeerecords_Screen funcionarios = new employeerecords_Screen();
            funcionarios.ShowDialog();
        }
    }
}
