namespace Fundamentos
{
    partial class Form08Checkbox
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
            this.txtfechaactual = new System.Windows.Forms.TextBox();
            this.chkformato = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtincrementar = new System.Windows.Forms.TextBox();
            this.rbdias = new System.Windows.Forms.RadioButton();
            this.rbmeses = new System.Windows.Forms.RadioButton();
            this.rbaños = new System.Windows.Forms.RadioButton();
            this.btnincrementar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechafinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha actual";
            // 
            // txtfechaactual
            // 
            this.txtfechaactual.Location = new System.Drawing.Point(111, 29);
            this.txtfechaactual.Name = "txtfechaactual";
            this.txtfechaactual.Size = new System.Drawing.Size(233, 20);
            this.txtfechaactual.TabIndex = 1;
            // 
            // chkformato
            // 
            this.chkformato.AutoSize = true;
            this.chkformato.Location = new System.Drawing.Point(111, 88);
            this.chkformato.Name = "chkformato";
            this.chkformato.Size = new System.Drawing.Size(135, 17);
            this.chkformato.TabIndex = 2;
            this.chkformato.Text = "Formato largo de fecha";
            this.chkformato.UseVisualStyleBackColor = true;
            this.chkformato.CheckedChanged += new System.EventHandler(this.chkformato_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incremento";
            // 
            // txtincrementar
            // 
            this.txtincrementar.Location = new System.Drawing.Point(234, 230);
            this.txtincrementar.Name = "txtincrementar";
            this.txtincrementar.Size = new System.Drawing.Size(134, 20);
            this.txtincrementar.TabIndex = 5;
            // 
            // rbdias
            // 
            this.rbdias.AutoSize = true;
            this.rbdias.Location = new System.Drawing.Point(38, 233);
            this.rbdias.Name = "rbdias";
            this.rbdias.Size = new System.Drawing.Size(48, 17);
            this.rbdias.TabIndex = 6;
            this.rbdias.TabStop = true;
            this.rbdias.Text = "Días";
            this.rbdias.UseVisualStyleBackColor = true;
            // 
            // rbmeses
            // 
            this.rbmeses.AutoSize = true;
            this.rbmeses.Location = new System.Drawing.Point(38, 274);
            this.rbmeses.Name = "rbmeses";
            this.rbmeses.Size = new System.Drawing.Size(56, 17);
            this.rbmeses.TabIndex = 7;
            this.rbmeses.TabStop = true;
            this.rbmeses.Text = "Meses";
            this.rbmeses.UseVisualStyleBackColor = true;
            // 
            // rbaños
            // 
            this.rbaños.AutoSize = true;
            this.rbaños.Location = new System.Drawing.Point(39, 316);
            this.rbaños.Name = "rbaños";
            this.rbaños.Size = new System.Drawing.Size(49, 17);
            this.rbaños.TabIndex = 8;
            this.rbaños.TabStop = true;
            this.rbaños.Text = "Años";
            this.rbaños.UseVisualStyleBackColor = true;
            // 
            // btnincrementar
            // 
            this.btnincrementar.Location = new System.Drawing.Point(234, 289);
            this.btnincrementar.Name = "btnincrementar";
            this.btnincrementar.Size = new System.Drawing.Size(134, 23);
            this.btnincrementar.TabIndex = 9;
            this.btnincrementar.Text = "Incrementar fecha";
            this.btnincrementar.UseVisualStyleBackColor = true;
            this.btnincrementar.Click += new System.EventHandler(this.btnincrementar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha Final";
            // 
            // txtfechafinal
            // 
            this.txtfechafinal.Location = new System.Drawing.Point(40, 420);
            this.txtfechafinal.Name = "txtfechafinal";
            this.txtfechafinal.Size = new System.Drawing.Size(212, 20);
            this.txtfechafinal.TabIndex = 11;
            // 
            // Form08Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 514);
            this.Controls.Add(this.txtfechafinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnincrementar);
            this.Controls.Add(this.rbaños);
            this.Controls.Add(this.rbmeses);
            this.Controls.Add(this.rbdias);
            this.Controls.Add(this.txtincrementar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkformato);
            this.Controls.Add(this.txtfechaactual);
            this.Controls.Add(this.label1);
            this.Name = "Form08Checkbox";
            this.Text = "Form08Checkbox";
            this.Load += new System.EventHandler(this.Form08Checkbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechaactual;
        private System.Windows.Forms.CheckBox chkformato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtincrementar;
        private System.Windows.Forms.RadioButton rbdias;
        private System.Windows.Forms.RadioButton rbmeses;
        private System.Windows.Forms.RadioButton rbaños;
        private System.Windows.Forms.Button btnincrementar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfechafinal;
    }
}