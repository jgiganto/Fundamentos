namespace Fundamentos
{
    partial class Form21FechasTemperatura
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
            this.lsttemperaturas = new System.Windows.Forms.ListBox();
            this.lbmaxima = new System.Windows.Forms.Label();
            this.lbminima = new System.Windows.Forms.Label();
            this.lbmedia = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.txmaxima = new System.Windows.Forms.TextBox();
            this.txminima = new System.Windows.Forms.TextBox();
            this.txmedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperaturas";
            // 
            // lsttemperaturas
            // 
            this.lsttemperaturas.FormattingEnabled = true;
            this.lsttemperaturas.ItemHeight = 18;
            this.lsttemperaturas.Location = new System.Drawing.Point(50, 125);
            this.lsttemperaturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsttemperaturas.Name = "lsttemperaturas";
            this.lsttemperaturas.Size = new System.Drawing.Size(277, 292);
            this.lsttemperaturas.TabIndex = 1;
            // 
            // lbmaxima
            // 
            this.lbmaxima.AutoSize = true;
            this.lbmaxima.Location = new System.Drawing.Point(447, 116);
            this.lbmaxima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmaxima.Name = "lbmaxima";
            this.lbmaxima.Size = new System.Drawing.Size(60, 18);
            this.lbmaxima.TabIndex = 2;
            this.lbmaxima.Text = "Máxima";
            // 
            // lbminima
            // 
            this.lbminima.AutoSize = true;
            this.lbminima.Location = new System.Drawing.Point(447, 264);
            this.lbminima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbminima.Name = "lbminima";
            this.lbminima.Size = new System.Drawing.Size(56, 18);
            this.lbminima.TabIndex = 3;
            this.lbminima.Text = "Mínima";
            // 
            // lbmedia
            // 
            this.lbmedia.AutoSize = true;
            this.lbmedia.Location = new System.Drawing.Point(447, 420);
            this.lbmedia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmedia.Name = "lbmedia";
            this.lbmedia.Size = new System.Drawing.Size(48, 18);
            this.lbmedia.TabIndex = 4;
            this.lbmedia.Text = "Media";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(498, 508);
            this.btnmostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(112, 58);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Generar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(498, 606);
            this.btngenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(112, 75);
            this.btngenerar.TabIndex = 6;
            this.btngenerar.Text = "Mostrar datos";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // txmaxima
            // 
            this.txmaxima.Location = new System.Drawing.Point(558, 112);
            this.txmaxima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txmaxima.Name = "txmaxima";
            this.txmaxima.Size = new System.Drawing.Size(90, 24);
            this.txmaxima.TabIndex = 7;
            // 
            // txminima
            // 
            this.txminima.Location = new System.Drawing.Point(558, 254);
            this.txminima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txminima.Name = "txminima";
            this.txminima.Size = new System.Drawing.Size(90, 24);
            this.txminima.TabIndex = 8;
            // 
            // txmedia
            // 
            this.txmedia.Location = new System.Drawing.Point(558, 408);
            this.txmedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txmedia.Name = "txmedia";
            this.txmedia.Size = new System.Drawing.Size(90, 24);
            this.txmedia.TabIndex = 9;
            // 
            // Form21FechasTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 720);
            this.Controls.Add(this.txmedia);
            this.Controls.Add(this.txminima);
            this.Controls.Add(this.txmaxima);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lbmedia);
            this.Controls.Add(this.lbminima);
            this.Controls.Add(this.lbmaxima);
            this.Controls.Add(this.lsttemperaturas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form21FechasTemperatura";
            this.Text = "Form21FechasTemperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsttemperaturas;
        private System.Windows.Forms.Label lbmaxima;
        private System.Windows.Forms.Label lbminima;
        private System.Windows.Forms.Label lbmedia;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.TextBox txmaxima;
        private System.Windows.Forms.TextBox txminima;
        private System.Windows.Forms.TextBox txmedia;
    }
}