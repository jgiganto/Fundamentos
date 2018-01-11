namespace Fundamentos
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
            this.btncambiartexto = new System.Windows.Forms.Button();
            this.txttexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncambiartexto
            // 
            this.btncambiartexto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncambiartexto.Location = new System.Drawing.Point(100, 92);
            this.btncambiartexto.Name = "btncambiartexto";
            this.btncambiartexto.Size = new System.Drawing.Size(128, 32);
            this.btncambiartexto.TabIndex = 0;
            this.btncambiartexto.Text = "Mostrar texto";
            this.btncambiartexto.UseVisualStyleBackColor = true;
            this.btncambiartexto.Click += new System.EventHandler(this.btncambiartexto_Click);
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(171, 35);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(321, 20);
            this.txttexto.TabIndex = 1;
            this.txttexto.TextChanged += new System.EventHandler(this.txttexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba algo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.btncambiartexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncambiartexto;
        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.Label label1;
    }
}

