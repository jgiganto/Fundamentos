namespace Fundamentos
{
    partial class Pruebas2
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
            this.txtsalida = new System.Windows.Forms.RichTextBox();
            this.btnrand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblencontrados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.txttexto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbvueltas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbmedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsalida
            // 
            this.txtsalida.Location = new System.Drawing.Point(35, 73);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(631, 488);
            this.txtsalida.TabIndex = 0;
            this.txtsalida.Text = "";
            // 
            // btnrand
            // 
            this.btnrand.Location = new System.Drawing.Point(262, 13);
            this.btnrand.Name = "btnrand";
            this.btnrand.Size = new System.Drawing.Size(100, 37);
            this.btnrand.TabIndex = 1;
            this.btnrand.Text = "random";
            this.btnrand.UseVisualStyleBackColor = true;
            this.btnrand.Click += new System.EventHandler(this.btnrand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encontrados:";
            // 
            // lblencontrados
            // 
            this.lblencontrados.AutoSize = true;
            this.lblencontrados.Location = new System.Drawing.Point(32, 40);
            this.lblencontrados.Name = "lblencontrados";
            this.lblencontrados.Size = new System.Drawing.Size(0, 18);
            this.lblencontrados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo:";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(507, 13);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(0, 18);
            this.lbltiempo.TabIndex = 5;
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(566, 43);
            this.txttexto.MaxLength = 3;
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(58, 24);
            this.txttexto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vueltas:";
            // 
            // lbvueltas
            // 
            this.lbvueltas.AutoSize = true;
            this.lbvueltas.Location = new System.Drawing.Point(101, 579);
            this.lbvueltas.Name = "lbvueltas";
            this.lbvueltas.Size = new System.Drawing.Size(0, 18);
            this.lbvueltas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Media:";
            // 
            // lbmedia
            // 
            this.lbmedia.AutoSize = true;
            this.lbmedia.Location = new System.Drawing.Point(587, 583);
            this.lbmedia.Name = "lbmedia";
            this.lbmedia.Size = new System.Drawing.Size(0, 18);
            this.lbmedia.TabIndex = 10;
            // 
            // Pruebas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 620);
            this.Controls.Add(this.lbmedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbvueltas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblencontrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrand);
            this.Controls.Add(this.txtsalida);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pruebas2";
            this.Text = "Pruebas2";
            this.Load += new System.EventHandler(this.Pruebas2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtsalida;
        private System.Windows.Forms.Button btnrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblencontrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbvueltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbmedia;
    }
}