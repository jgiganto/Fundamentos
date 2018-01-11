namespace Fundamentos
{
    partial class Form35TemperaturasAnuales
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtmediamensual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtminimamensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaximamensual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstmeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbaño = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnumerodeaños = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmediaanual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtminimaanual = new System.Windows.Forms.TextBox();
            this.txtmaximaanual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(81, 110);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(162, 83);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar Temperaturas";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtmediamensual
            // 
            this.txtmediamensual.Location = new System.Drawing.Point(366, 544);
            this.txtmediamensual.Name = "txtmediamensual";
            this.txtmediamensual.Size = new System.Drawing.Size(100, 24);
            this.txtmediamensual.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Media Mensual";
            // 
            // txtminimamensual
            // 
            this.txtminimamensual.Location = new System.Drawing.Point(366, 455);
            this.txtminimamensual.Name = "txtminimamensual";
            this.txtminimamensual.Size = new System.Drawing.Size(100, 24);
            this.txtminimamensual.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tem.Minima";
            // 
            // txtmaximamensual
            // 
            this.txtmaximamensual.Location = new System.Drawing.Point(366, 363);
            this.txtmaximamensual.Name = "txtmaximamensual";
            this.txtmaximamensual.Size = new System.Drawing.Size(100, 24);
            this.txtmaximamensual.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tem.Maxima";
            // 
            // lstmeses
            // 
            this.lstmeses.FormattingEnabled = true;
            this.lstmeses.ItemHeight = 18;
            this.lstmeses.Location = new System.Drawing.Point(81, 289);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(231, 328);
            this.lstmeses.TabIndex = 10;
            this.lstmeses.SelectedIndexChanged += new System.EventHandler(this.lstmeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Meses";
            // 
            // cmbaño
            // 
            this.cmbaño.FormattingEnabled = true;
            this.cmbaño.Location = new System.Drawing.Point(75, 35);
            this.cmbaño.Name = "cmbaño";
            this.cmbaño.Size = new System.Drawing.Size(202, 26);
            this.cmbaño.TabIndex = 18;
            this.cmbaño.SelectedIndexChanged += new System.EventHandler(this.cmbaño_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Numero de años";
            // 
            // txtnumerodeaños
            // 
            this.txtnumerodeaños.Location = new System.Drawing.Point(437, 37);
            this.txtnumerodeaños.Name = "txtnumerodeaños";
            this.txtnumerodeaños.Size = new System.Drawing.Size(78, 24);
            this.txtnumerodeaños.TabIndex = 21;
            this.txtnumerodeaños.TextChanged += new System.EventHandler(this.txtnumerodeaños_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Media Anual";
            // 
            // txtmediaanual
            // 
            this.txtmediaanual.Location = new System.Drawing.Point(401, 239);
            this.txtmediaanual.Name = "txtmediaanual";
            this.txtmediaanual.Size = new System.Drawing.Size(100, 24);
            this.txtmediaanual.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Minima anual";
            // 
            // txtminimaanual
            // 
            this.txtminimaanual.Location = new System.Drawing.Point(494, 152);
            this.txtminimaanual.Name = "txtminimaanual";
            this.txtminimaanual.Size = new System.Drawing.Size(53, 24);
            this.txtminimaanual.TabIndex = 25;
            // 
            // txtmaximaanual
            // 
            this.txtmaximaanual.Location = new System.Drawing.Point(345, 152);
            this.txtmaximaanual.Name = "txtmaximaanual";
            this.txtmaximaanual.Size = new System.Drawing.Size(53, 24);
            this.txtmaximaanual.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Maxima anual";
            // 
            // Form35TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 666);
            this.Controls.Add(this.txtmaximaanual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtminimaanual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmediaanual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnumerodeaños);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbaño);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtmediamensual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtminimamensual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaximamensual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstmeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form35TemperaturasAnuales";
            this.Text = "Form35TemperaturasAnuales";
            this.Load += new System.EventHandler(this.Form35TemperaturasAnuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtmediamensual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtminimamensual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaximamensual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbaño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnumerodeaños;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmediaanual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtminimaanual;
        private System.Windows.Forms.TextBox txtmaximaanual;
        private System.Windows.Forms.Label label9;
    }
}