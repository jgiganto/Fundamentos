namespace Fundamentos
{
    partial class Form13ComparacionString
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
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btninvertir = new System.Windows.Forms.Button();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.btnbouilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(38, 88);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(358, 386);
            this.txttexto.TabIndex = 0;
            this.txttexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca un texto";
            // 
            // btninvertir
            // 
            this.btninvertir.Location = new System.Drawing.Point(419, 88);
            this.btninvertir.Name = "btninvertir";
            this.btninvertir.Size = new System.Drawing.Size(105, 67);
            this.btninvertir.TabIndex = 2;
            this.btninvertir.Text = "Invertir texto (String)";
            this.btninvertir.UseVisualStyleBackColor = true;
            this.btninvertir.Click += new System.EventHandler(this.btninvertir_Click);
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(38, 495);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(48, 13);
            this.lbltiempo.TabIndex = 3;
            this.lbltiempo.Text = "lbltiempo";
            // 
            // btnbouilder
            // 
            this.btnbouilder.Location = new System.Drawing.Point(419, 213);
            this.btnbouilder.Name = "btnbouilder";
            this.btnbouilder.Size = new System.Drawing.Size(105, 74);
            this.btnbouilder.TabIndex = 4;
            this.btnbouilder.Text = "Invertir Texto (String builder)";
            this.btnbouilder.UseVisualStyleBackColor = true;
            this.btnbouilder.Click += new System.EventHandler(this.btnbouilder_Click);
            // 
            // Form13ComparacionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 571);
            this.Controls.Add(this.btnbouilder);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.btninvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttexto);
            this.Name = "Form13ComparacionString";
            this.Text = "Form13ComparacionString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninvertir;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btnbouilder;
    }
}