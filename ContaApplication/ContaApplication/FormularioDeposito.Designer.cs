namespace ContaApplication
{
    partial class FormularioDeposito
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
            this.txtValorDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContaDep = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorDep
            // 
            this.txtValorDep.Location = new System.Drawing.Point(204, 114);
            this.txtValorDep.Name = "txtValorDep";
            this.txtValorDep.Size = new System.Drawing.Size(117, 20);
            this.txtValorDep.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor do Deposito";
            // 
            // txtContaDep
            // 
            this.txtContaDep.Location = new System.Drawing.Point(204, 73);
            this.txtContaDep.Name = "txtContaDep";
            this.txtContaDep.Size = new System.Drawing.Size(117, 20);
            this.txtContaDep.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(113, 80);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(35, 13);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Conta";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(198, 175);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(88, 23);
            this.btnDepositar.TabIndex = 13;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // FormularioDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 262);
            this.Controls.Add(this.txtValorDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContaDep);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnDepositar);
            this.Name = "FormularioDeposito";
            this.Text = "FormularioDeposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContaDep;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnDepositar;
    }
}