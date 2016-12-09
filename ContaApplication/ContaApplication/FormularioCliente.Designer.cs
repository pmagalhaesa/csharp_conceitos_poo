namespace ContaApplication
{
    partial class FormularioCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(263, 338);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Cliente";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(118, 116);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(308, 20);
            this.txtIdade.TabIndex = 4;
            this.txtIdade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(27, 123);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(118, 156);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(308, 20);
            this.txtRg.TabIndex = 6;
            this.txtRg.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(27, 163);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 5;
            this.lblRg.Text = "RG";
            this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(118, 203);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(308, 20);
            this.txtCpf.TabIndex = 8;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(27, 210);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(118, 244);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(308, 20);
            this.txtEnd.TabIndex = 10;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(27, 251);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(118, 285);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(308, 20);
            this.txtSaldo.TabIndex = 12;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Saldo inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 443);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label1;
    }
}