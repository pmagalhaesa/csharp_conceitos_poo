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
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtIdade.Text != "" && txtRg.Text != "" && txtCpf.Text != "" && txtEnd.Text != "")
            {


                Cliente cli = new Cliente();
                cli.setNome(txtNome.Text);
                cli.setIdade(int.Parse(txtIdade.Text));
                cli.setCpf(txtCpf.Text);
                cli.setEnd(txtEnd.Text);
                cli.setRg(txtRg.Text);

                Random ran = new Random();
                Conta cont = new Conta(float.Parse(txtSaldo.Text), cli, 0, Convert.ToString(ran.Next(1, 9999999)));

                Helper.addConta(cont);

                MessageBox.Show("Enviado com sucesso!");
            }
            else
            {
                MessageBox.Show("Verifique se esqueceu de preencher algum campo!");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
