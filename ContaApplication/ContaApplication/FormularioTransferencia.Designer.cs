namespace ContaApplication
{
    partial class FormularioTransferencia
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
            this.txtValorTransf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContaTransf = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorTransf
            // 
            this.txtValorTransf.Location = new System.Drawing.Point(199, 110);
            this.txtValorTransf.Name = "txtValorTransf";
            this.txtValorTransf.Size = new System.Drawing.Size(117, 20);
            this.txtValorTransf.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor da transferência";
            // 
            // txtContaTransf
            // 
            this.txtContaTransf.Location = new System.Drawing.Point(199, 69);
            this.txtContaTransf.Name = "txtContaTransf";
            this.txtContaTransf.Size = new System.Drawing.Size(117, 20);
            this.txtContaTransf.TabIndex = 20;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(61, 76);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(123, 13);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Conta para transferência";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(193, 171);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(88, 23);
            this.btnDepositar.TabIndex = 18;
            this.btnDepositar.Text = "TRANSFERIR";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // FormularioTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.txtValorTransf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContaTransf);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnDepositar);
            this.Name = "FormularioTransferencia";
            this.Text = "FormularioTransferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorTransf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContaTransf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnDepositar;
    }
}