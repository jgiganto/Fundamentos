namespace Fundamentos
{
    partial class Form09ValidarEmail
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(182, 45);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(173, 20);
            this.txtemail.TabIndex = 1;
            // 
            // btnvalidar
            // 
            this.btnvalidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidar.Location = new System.Drawing.Point(188, 105);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(173, 46);
            this.btnvalidar.TabIndex = 2;
            this.btnvalidar.Text = "Validar Email";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respuesta";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.BackColor = System.Drawing.SystemColors.Info;
            this.lblrespuesta.Location = new System.Drawing.Point(61, 303);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(294, 130);
            this.lblrespuesta.TabIndex = 4;
            this.lblrespuesta.Text = "-Exista @\r\n-@ al principio o final\r\n- Más de una @\r\n-Exista punto\r\n-Punto después" +
    " de @\r\n-Dominio de 2 a 4 caracteres\r\n";
            this.lblrespuesta.Click += new System.EventHandler(this.lblrespuesta_Click);
            // 
            // Form09ValidarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 540);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Name = "Form09ValidarEmail";
            this.Text = "Form09ValidarEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrespuesta;
    }
}