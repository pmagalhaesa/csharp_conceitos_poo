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
    public partial class FormularioSaldo : Form
    {
        public FormularioSaldo()
        {
            InitializeComponent();
        }

        public FormularioSaldo(String numConta)
        {
            InitializeComponent();
            txtSaldo.Text = Helper.getConta(numConta).getNumConta();
        }
        

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
