namespace Fundamentos
{
    partial class Form33HerenciaClases
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
            this.Detalles = new System.Windows.Forms.Label();
            this.lstdetalles = new System.Windows.Forms.ListBox();
            this.btndeportivo = new System.Windows.Forms.Button();
            this.btncoche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Detalles
            // 
            this.Detalles.AutoSize = true;
            this.Detalles.Location = new System.Drawing.Point(29, 103);
            this.Detalles.Name = "Detalles";
            this.Detalles.Size = new System.Drawing.Size(45, 13);
            this.Detalles.TabIndex = 7;
            this.Detalles.Text = "Detalles";
            // 
            // lstdetalles
            // 
            this.lstdetalles.FormattingEnabled = true;
            this.lstdetalles.Location = new System.Drawing.Point(29, 122);
            this.lstdetalles.Name = "lstdetalles";
            this.lstdetalles.Size = new System.Drawing.Size(226, 108);
            this.lstdetalles.TabIndex = 6;
            // 
            // btndeportivo
            // 
            this.btndeportivo.Location = new System.Drawing.Point(163, 31);
            this.btndeportivo.Name = "btndeportivo";
            this.btndeportivo.Size = new System.Drawing.Size(75, 23);
            this.btndeportivo.TabIndex = 5;
            this.btndeportivo.Text = "Deportivo";
            this.btndeportivo.UseVisualStyleBackColor = true;
            this.btndeportivo.Click += new System.EventHandler(this.btndeportivo_Click);
            // 
            // btncoche
            // 
            this.btncoche.Location = new System.Drawing.Point(29, 32);
            this.btncoche.Name = "btncoche";
            this.btncoche.Size = new System.Drawing.Size(75, 23);
            this.btncoche.TabIndex = 4;
            this.btncoche.Text = "Coche";
            this.btncoche.UseVisualStyleBackColor = true;
            this.btncoche.Click += new System.EventHandler(this.btncoche_Click);
            // 
            // Form33HerenciaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.lstdetalles);
            this.Controls.Add(this.btndeportivo);
            this.Controls.Add(this.btncoche);
            this.Name = "Form33HerenciaClases";
            this.Text = "Form33HerenciaClases";
            this.Load += new System.EventHandler(this.Form33HerenciaClases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Detalles;
        private System.Windows.Forms.ListBox lstdetalles;
        private System.Windows.Forms.Button btndeportivo;
        private System.Windows.Forms.Button btncoche;
    }
}