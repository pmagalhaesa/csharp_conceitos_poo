namespace ContaApplication
{
    partial class FormularioSaque
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
            this.txtValorSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValorSaque
            // 
            this.txtValorSaque.Location = new System.Drawing.Point(217, 99);
            this.txtValorSaque.Name = "txtValorSaque";
            this.txtValorSaque.Size = new System.Drawing.Size(117, 20);
            this.txtValorSaque.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor do saque";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(211, 160);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(88, 23);
            this.btnDepositar.TabIndex = 18;
            this.btnDepositar.Text = "SACAR";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // FormularioSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 262);
            this.Controls.Add(this.txtValorSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepositar);
            this.Name = "FormularioSaque";
            this.Text = "FormularioSaque";
            this.Load += new System.EventHandler(this.FormularioSaque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepositar;
    }
}