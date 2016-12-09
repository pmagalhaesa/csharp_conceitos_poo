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
    public partial class FormularioSaque : Form
    {
        
        public FormularioSaque()
        {
            InitializeComponent();
        }
        private string numConta = "";
        public FormularioSaque(String numConta)
        {
            InitializeComponent();
            this.numConta = Helper.getConta(numConta).getNumConta();
        }
        private void FormularioSaque_Load(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtValorSaque.Text != "" && int.Parse(txtValorSaque.Text)>0)
            {
                if (Helper.getConta(this.numConta).getSaldo() >= float.Parse(txtValorSaque.Text))
                {
                    Helper.getConta(this.numConta).sacar(float.Parse(txtValorSaque.Text));
                    MessageBox.Show("Saque efetuado com sucesso!"); 
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
