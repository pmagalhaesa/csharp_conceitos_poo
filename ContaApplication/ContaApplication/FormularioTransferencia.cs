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
    public partial class FormularioTransferencia : Form
    {
        public FormularioTransferencia()
        {
            InitializeComponent();
        }

         private string numConta = "";
        public FormularioTransferencia(String numConta)
        {
            InitializeComponent();
            this.numConta = Helper.getConta(numConta).getNumConta();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtContaTransf.Text != "" && txtValorTransf.Text != "" && int.Parse(txtValorTransf.Text)>0)
            {
                if (Helper.getConta(this.numConta).getSaldo() >= float.Parse(txtValorTransf.Text))
                {
                    if (Helper.getConta(txtContaTransf.Text) != null)
                    {
                        Helper.getConta(this.numConta).transferir(float.Parse(txtValorTransf.Text), Helper.getConta(txtContaTransf.Text));
                        MessageBox.Show("Transferencia efetuado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Conta nao existe");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                MessageBox.Show("Transferência realizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro, verifique se esqueceu de preencher algum campo!");
            }
        }
    }
}
