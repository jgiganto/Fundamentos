namespace Fundamentos
{
    partial class Form08Char
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
            this.txtletras = new System.Windows.Forms.TextBox();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsimbolos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtotros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnanalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(35, 88);
            this.txtletras.Multiline = true;
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(181, 125);
            this.txtletras.TabIndex = 1;
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(361, 88);
            this.txtnumeros.Multiline = true;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(181, 125);
            this.txtnumeros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Números";
            // 
            // txtsimbolos
            // 
            this.txtsimbolos.Location = new System.Drawing.Point(36, 268);
            this.txtsimbolos.Multiline = true;
            this.txtsimbolos.Name = "txtsimbolos";
            this.txtsimbolos.Size = new System.Drawing.Size(181, 125);
            this.txtsimbolos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Símbolos";
            // 
            // txtpuntuacion
            // 
            this.txtpuntuacion.Location = new System.Drawing.Point(362, 268);
            this.txtpuntuacion.Multiline = true;
            this.txtpuntuacion.Name = "txtpuntuacion";
            this.txtpuntuacion.Size = new System.Drawing.Size(181, 125);
            this.txtpuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuación";
            // 
            // txtotros
            // 
            this.txtotros.Location = new System.Drawing.Point(37, 468);
            this.txtotros.Multiline = true;
            this.txtotros.Name = "txtotros";
            this.txtotros.Size = new System.Drawing.Size(505, 125);
            this.txtotros.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Otros";
            // 
            // btnanalizar
            // 
            this.btnanalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanalizar.Location = new System.Drawing.Point(581, 280);
            this.btnanalizar.Name = "btnanalizar";
            this.btnanalizar.Size = new System.Drawing.Size(132, 95);
            this.btnanalizar.TabIndex = 10;
            this.btnanalizar.Text = "Analizar código ASCII";
            this.btnanalizar.UseVisualStyleBackColor = true;
            this.btnanalizar.Click += new System.EventHandler(this.btnanalizar_Click);
            // 
            // Form08Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 650);
            this.Controls.Add(this.btnanalizar);
            this.Controls.Add(this.txtotros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsimbolos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.label1);
            this.Name = "Form08Char";
            this.Text = "Form08Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsimbolos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtotros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnanalizar;
    }
}