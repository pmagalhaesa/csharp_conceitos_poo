using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaApplication
{
    public partial class FormularioDeposito : Form
    {
        public FormularioDeposito()
        {
            InitializeComponent();
        }
         private string numConta = "";
        public FormularioDeposito(String numConta)
        {
            InitializeComponent();
            this.numConta = Helper.getConta(numConta).getNumConta();
        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtContaDep.Text != "" && txtValorDep.Text != "" && int.Parse(txtValorDep.Text)>0)
            {
                if (Helper.getConta(txtContaDep.Text) != null)
                {
                    Helper.getConta(this.numConta).depositar(float.Parse(txtValorDep.Text));
                    MessageBox.Show("Deposito realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Conta nao existe");
                }
                
            }
            else
            {
                MessageBox.Show("Erro!! Verifique se esqueceu de preencher algum campo!");
            }
        }
    }
}
