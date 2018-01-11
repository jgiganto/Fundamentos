namespace Fundamentos
{
    partial class Form02PosicionObjetos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtposicionx = new System.Windows.Forms.TextBox();
            this.txtposiciony = new System.Windows.Forms.TextBox();
            this.btncambiarposicion = new System.Windows.Forms.Button();
            this.lblobjeto = new System.Windows.Forms.Label();
            this.btnarriba = new System.Windows.Forms.Button();
            this.btnabajo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posición X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posición Y";
            // 
            // txtposicionx
            // 
            this.txtposicionx.Location = new System.Drawing.Point(163, 48);
            this.txtposicionx.Name = "txtposicionx";
            this.txtposicionx.Size = new System.Drawing.Size(100, 20);
            this.txtposicionx.TabIndex = 2;
            // 
            // txtposiciony
            // 
            this.txtposiciony.Location = new System.Drawing.Point(163, 130);
            this.txtposiciony.Name = "txtposiciony";
            this.txtposiciony.Size = new System.Drawing.Size(100, 20);
            this.txtposiciony.TabIndex = 3;
            // 
            // btncambiarposicion
            // 
            this.btncambiarposicion.Location = new System.Drawing.Point(63, 211);
            this.btncambiarposicion.Name = "btncambiarposicion";
            this.btncambiarposicion.Size = new System.Drawing.Size(200, 53);
            this.btncambiarposicion.TabIndex = 4;
            this.btncambiarposicion.Text = "Cambiar Posición";
            this.btncambiarposicion.UseVisualStyleBackColor = true;
            this.btncambiarposicion.Click += new System.EventHandler(this.btncambiarposicion_Click);
            // 
            // lblobjeto
            // 
            this.lblobjeto.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblobjeto.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobjeto.Location = new System.Drawing.Point(310, 45);
            this.lblobjeto.Name = "lblobjeto";
            this.lblobjeto.Size = new System.Drawing.Size(158, 70);
            this.lblobjeto.TabIndex = 5;
            this.lblobjeto.Click += new System.EventHandler(this.lblobjeto_Click);
            // 
            // btnarriba
            // 
            this.btnarriba.Location = new System.Drawing.Point(66, 287);
            this.btnarriba.Name = "btnarriba";
            this.btnarriba.Size = new System.Drawing.Size(197, 24);
            this.btnarriba.TabIndex = 6;
            this.btnarriba.Text = "Arriba";
            this.btnarriba.UseVisualStyleBackColor = true;
            this.btnarriba.Click += new System.EventHandler(this.btnarriba_Click);
            this.btnarriba.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnarriba_MouseMove);
            // 
            // btnabajo
            // 
            this.btnabajo.Location = new System.Drawing.Point(66, 331);
            this.btnabajo.Name = "btnabajo";
            this.btnabajo.Size = new System.Drawing.Size(197, 29);
            this.btnabajo.TabIndex = 7;
            this.btnabajo.Text = "Abajo";
            this.btnabajo.UseVisualStyleBackColor = true;
            this.btnabajo.Click += new System.EventHandler(this.btnabajo_Click);
            // 
            // Form02PosicionObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(491, 455);
            this.Controls.Add(this.btnabajo);
            this.Controls.Add(this.btnarriba);
            this.Controls.Add(this.lblobjeto);
            this.Controls.Add(this.btncambiarposicion);
            this.Controls.Add(this.txtposiciony);
            this.Controls.Add(this.txtposicionx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form02PosicionObjetos";
            this.Text = "Form02PosicionObjetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtposicionx;
        private System.Windows.Forms.TextBox txtposiciony;
        private System.Windows.Forms.Button btncambiarposicion;
        private System.Windows.Forms.Label lblobjeto;
        private System.Windows.Forms.Button btnarriba;
        private System.Windows.Forms.Button btnabajo;
    }
}