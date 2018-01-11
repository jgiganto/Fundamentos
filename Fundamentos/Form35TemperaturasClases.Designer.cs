namespace Fundamentos
{
    partial class Form35TemperaturasClases
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstmeses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaxima = new System.Windows.Forms.TextBox();
            this.txtminima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // lstmeses
            // 
            this.lstmeses.FormattingEnabled = true;
            this.lstmeses.ItemHeight = 18;
            this.lstmeses.Location = new System.Drawing.Point(12, 63);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(231, 328);
            this.lstmeses.TabIndex = 1;
            this.lstmeses.SelectedIndexChanged += new System.EventHandler(this.lstmeses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tem.Maxima";
            // 
            // txtmaxima
            // 
            this.txtmaxima.Location = new System.Drawing.Point(252, 74);
            this.txtmaxima.Name = "txtmaxima";
            this.txtmaxima.Size = new System.Drawing.Size(100, 24);
            this.txtmaxima.TabIndex = 3;
            // 
            // txtminima
            // 
            this.txtminima.Location = new System.Drawing.Point(252, 166);
            this.txtminima.Name = "txtminima";
            this.txtminima.Size = new System.Drawing.Size(100, 24);
            this.txtminima.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tem.Minima";
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(252, 255);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 24);
            this.txtmedia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Media Mensual";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(252, 317);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(162, 83);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar Temperaturas";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form35TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 505);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtminima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstmeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form35TemperaturasClases";
            this.Text = "Form35TemperaturasClases";
            this.Load += new System.EventHandler(this.Form35TemperaturasClases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaxima;
        private System.Windows.Forms.TextBox txtminima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerar;
    }
}