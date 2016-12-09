namespace ContaApplication
{
    partial class Form1
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
            this.mnGeral = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mnGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnGeral
            // 
            this.mnGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.saldoToolStripMenuItem,
            this.saqueToolStripMenuItem,
            this.depositoToolStripMenuItem,
            this.transferênciaToolStripMenuItem});
            this.mnGeral.Location = new System.Drawing.Point(0, 0);
            this.mnGeral.Name = "mnGeral";
            this.mnGeral.Size = new System.Drawing.Size(911, 24);
            this.mnGeral.TabIndex = 0;
            this.mnGeral.Text = "menuStrip1";
            this.mnGeral.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnGeral_ItemClicked);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.importarArquivoToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadastrarToolStripMenuItem.Text = "Cliente";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clienteToolStripMenuItem.Text = "Cadastrar cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // importarArquivoToolStripMenuItem
            // 
            this.importarArquivoToolStripMenuItem.Name = "importarArquivoToolStripMenuItem";
            this.importarArquivoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.importarArquivoToolStripMenuItem.Text = "Importar arquivo";
            this.importarArquivoToolStripMenuItem.Click += new System.EventHandler(this.importarArquivoToolStripMenuItem_Click);
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.saldoToolStripMenuItem.Text = "Saldo";
            this.saldoToolStripMenuItem.Click += new System.EventHandler(this.saldoToolStripMenuItem_Click);
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.saqueToolStripMenuItem.Text = "Saque";
            this.saqueToolStripMenuItem.Click += new System.EventHandler(this.saqueToolStripMenuItem_Click);
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.depositoToolStripMenuItem.Text = "Deposito";
            this.depositoToolStripMenuItem.Click += new System.EventHandler(this.depositoToolStripMenuItem_Click);
            // 
            // transferênciaToolStripMenuItem
            // 
            this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.transferênciaToolStripMenuItem.Text = "Transferência";
            this.transferênciaToolStripMenuItem.Click += new System.EventHandler(this.transferênciaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(386, 102);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "USAR CONTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnGeral);
            this.MainMenuStrip = this.mnGeral;
            this.Name = "Form1";
            this.Text = "Conta Bancaria";
            this.mnGeral.ResumeLayout(false);
            this.mnGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnGeral;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.ToolStripMenuItem importarArquivoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

