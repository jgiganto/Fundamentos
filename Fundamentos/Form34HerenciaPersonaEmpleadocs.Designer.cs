namespace Fundamentos
{
    partial class Form34HerenciaPersonaEmpleadocs
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
            this.lsdetalles = new System.Windows.Forms.ListBox();
            this.btnpersona = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsdetalles
            // 
            this.lsdetalles.FormattingEnabled = true;
            this.lsdetalles.ItemHeight = 16;
            this.lsdetalles.Location = new System.Drawing.Point(40, 93);
            this.lsdetalles.Name = "lsdetalles";
            this.lsdetalles.Size = new System.Drawing.Size(436, 324);
            this.lsdetalles.TabIndex = 0;
            // 
            // btnpersona
            // 
            this.btnpersona.Location = new System.Drawing.Point(40, 30);
            this.btnpersona.Name = "btnpersona";
            this.btnpersona.Size = new System.Drawing.Size(75, 23);
            this.btnpersona.TabIndex = 1;
            this.btnpersona.Text = "Persona";
            this.btnpersona.UseVisualStyleBackColor = true;
            this.btnpersona.Click += new System.EventHandler(this.btnpersona_Click);
            // 
            // btnempleado
            // 
            this.btnempleado.Location = new System.Drawing.Point(218, 30);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(85, 23);
            this.btnempleado.TabIndex = 2;
            this.btnempleado.Text = "Empleado";
            this.btnempleado.UseVisualStyleBackColor = true;
            // 
            // Form34HerenciaPersonaEmpleadocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 471);
            this.Controls.Add(this.btnempleado);
            this.Controls.Add(this.btnpersona);
            this.Controls.Add(this.lsdetalles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form34HerenciaPersonaEmpleadocs";
            this.Text = "Form34HerenciaPersonaEmpleadocs";
            this.Load += new System.EventHandler(this.Form34HerenciaPersonaEmpleadocs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsdetalles;
        private System.Windows.Forms.Button btnpersona;
        private System.Windows.Forms.Button btnempleado;
    }
}