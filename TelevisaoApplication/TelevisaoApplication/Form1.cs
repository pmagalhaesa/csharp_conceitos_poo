using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisaoApplication
{
    public partial class Form1 : Form
    {
        private Televisao tv = new Televisao();


        public Form1()
        {
            InitializeComponent();
        }

        private void lblCan_Click(object sender, EventArgs e)
        {

        }

        private void lblVol_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntLigaDesliga_Click(object sender, EventArgs e)
        {
            this.tv.ligarDesligar();
            if (this.tv.getLigado())
            {
                lblOnOff.Text = "Ligado";
                btnAumentarCan.Enabled=true;
                btnDiminuirCan.Enabled = true;
                btnAumentarVol.Enabled = true;
                btnDiminuirVol.Enabled = true;
                lblVol.Visible = true;
                lblCan.Visible = true;
            }
            else
            {
                lblOnOff.Text = "Desligado";
                btnAumentarCan.Enabled = false;
                btnDiminuirCan.Enabled = false;
                btnAumentarVol.Enabled = false;
                btnDiminuirVol.Enabled = false;
                lblVol.Visible = false;
                lblCan.Visible = false;
            }
            
        }

        private void btnAumentarVol_Click(object sender, EventArgs e)
        {
            this.tv.aumentarVolume();

            lblVol.Text = Convert.ToString(this.tv.getVolume());
        }

        private void btnDiminuirVol_Click(object sender, EventArgs e)
        {
            this.tv.diminuirVolume();

            lblVol.Text = Convert.ToString(this.tv.getVolume());
        }

        private void btnAumentarCan_Click(object sender, EventArgs e)
        {
            this.tv.subirCanal();
            lblCan.Text = Convert.ToString(this.tv.getCanal());
        }

        private void btnDiminuirCan_Click(object sender, EventArgs e)
        {
            this.tv.baixarCanal();
            lblCan.Text = Convert.ToString(this.tv.getCanal());
        }
    }
}
