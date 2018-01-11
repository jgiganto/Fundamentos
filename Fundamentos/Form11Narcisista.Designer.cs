namespace Fundamentos
{
    partial class Form11Narcisista
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnnarcisista = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un número";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(215, 34);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btnnarcisista
            // 
            this.btnnarcisista.Location = new System.Drawing.Point(215, 119);
            this.btnnarcisista.Name = "btnnarcisista";
            this.btnnarcisista.Size = new System.Drawing.Size(86, 23);
            this.btnnarcisista.TabIndex = 2;
            this.btnnarcisista.Text = "Comprobar";
            this.btnnarcisista.UseVisualStyleBackColor = true;
            this.btnnarcisista.Click += new System.EventHandler(this.btnnarcisista_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.Coral;
            this.lblresultado.Location = new System.Drawing.Point(29, 189);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 20);
            this.lblresultado.TabIndex = 3;
            // 
            // Form11Narcisista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 303);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnnarcisista);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form11Narcisista";
            this.Text = "Form11Narcisista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnnarcisista;
        private System.Windows.Forms.Label lblresultado;
    }
}