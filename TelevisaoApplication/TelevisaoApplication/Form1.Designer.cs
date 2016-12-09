namespace TelevisaoApplication
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
            this.bntLigaDesliga = new System.Windows.Forms.Button();
            this.btnAumentarVol = new System.Windows.Forms.Button();
            this.btnDiminuirVol = new System.Windows.Forms.Button();
            this.btnDiminuirCan = new System.Windows.Forms.Button();
            this.btnAumentarCan = new System.Windows.Forms.Button();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntLigaDesliga
            // 
            this.bntLigaDesliga.Location = new System.Drawing.Point(193, 62);
            this.bntLigaDesliga.Name = "bntLigaDesliga";
            this.bntLigaDesliga.Size = new System.Drawing.Size(112, 23);
            this.bntLigaDesliga.TabIndex = 0;
            this.bntLigaDesliga.Text = "Ligar/Desligar";
            this.bntLigaDesliga.UseVisualStyleBackColor = true;
            this.bntLigaDesliga.Click += new System.EventHandler(this.bntLigaDesliga_Click);
            // 
            // btnAumentarVol
            // 
            this.btnAumentarVol.Enabled = false;
            this.btnAumentarVol.Location = new System.Drawing.Point(175, 109);
            this.btnAumentarVol.Name = "btnAumentarVol";
            this.btnAumentarVol.Size = new System.Drawing.Size(62, 23);
            this.btnAumentarVol.TabIndex = 1;
            this.btnAumentarVol.Text = "Vol +";
            this.btnAumentarVol.UseVisualStyleBackColor = true;
            this.btnAumentarVol.Click += new System.EventHandler(this.btnAumentarVol_Click);
            // 
            // btnDiminuirVol
            // 
            this.btnDiminuirVol.Enabled = false;
            this.btnDiminuirVol.Location = new System.Drawing.Point(258, 109);
            this.btnDiminuirVol.Name = "btnDiminuirVol";
            this.btnDiminuirVol.Size = new System.Drawing.Size(62, 23);
            this.btnDiminuirVol.TabIndex = 2;
            this.btnDiminuirVol.Text = "Vol -";
            this.btnDiminuirVol.UseVisualStyleBackColor = true;
            this.btnDiminuirVol.Click += new System.EventHandler(this.btnDiminuirVol_Click);
            // 
            // btnDiminuirCan
            // 
            this.btnDiminuirCan.Enabled = false;
            this.btnDiminuirCan.Location = new System.Drawing.Point(258, 150);
            this.btnDiminuirCan.Name = "btnDiminuirCan";
            this.btnDiminuirCan.Size = new System.Drawing.Size(62, 23);
            this.btnDiminuirCan.TabIndex = 4;
            this.btnDiminuirCan.Text = "Canal -";
            this.btnDiminuirCan.UseVisualStyleBackColor = true;
            this.btnDiminuirCan.Click += new System.EventHandler(this.btnDiminuirCan_Click);
            // 
            // btnAumentarCan
            // 
            this.btnAumentarCan.Enabled = false;
            this.btnAumentarCan.Location = new System.Drawing.Point(175, 150);
            this.btnAumentarCan.Name = "btnAumentarCan";
            this.btnAumentarCan.Size = new System.Drawing.Size(62, 23);
            this.btnAumentarCan.TabIndex = 3;
            this.btnAumentarCan.Text = "Canal +";
            this.btnAumentarCan.UseVisualStyleBackColor = true;
            this.btnAumentarCan.Click += new System.EventHandler(this.btnAumentarCan_Click);
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.Location = new System.Drawing.Point(375, 67);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(54, 13);
            this.lblOnOff.TabIndex = 5;
            this.lblOnOff.Text = "Desligado";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(389, 119);
            this.lblVol.MaximumSize = new System.Drawing.Size(50, 30);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(19, 13);
            this.lblVol.TabIndex = 6;
            this.lblVol.Text = "50";
            this.lblVol.Visible = false;
            this.lblVol.Click += new System.EventHandler(this.lblVol_Click);
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(389, 160);
            this.lblCan.MaximumSize = new System.Drawing.Size(50, 30);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(19, 13);
            this.lblCan.TabIndex = 7;
            this.lblCan.Text = "50";
            this.lblCan.Visible = false;
            this.lblCan.Click += new System.EventHandler(this.lblCan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 260);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lblOnOff);
            this.Controls.Add(this.btnDiminuirCan);
            this.Controls.Add(this.btnAumentarCan);
            this.Controls.Add(this.btnDiminuirVol);
            this.Controls.Add(this.btnAumentarVol);
            this.Controls.Add(this.bntLigaDesliga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntLigaDesliga;
        private System.Windows.Forms.Button btnAumentarVol;
        private System.Windows.Forms.Button btnDiminuirVol;
        private System.Windows.Forms.Button btnDiminuirCan;
        private System.Windows.Forms.Button btnAumentarCan;
        private System.Windows.Forms.Label lblOnOff;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Label lblCan;
    }
}

