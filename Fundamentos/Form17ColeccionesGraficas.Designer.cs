namespace Fundamentos
{
    partial class Form17ColeccionesGraficas
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
            this.lstelementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.lblindice = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.ItemHeight = 18;
            this.lstelementos.Location = new System.Drawing.Point(63, 68);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstelementos.Size = new System.Drawing.Size(186, 310);
            this.lstelementos.TabIndex = 0;
            this.lstelementos.SelectedIndexChanged += new System.EventHandler(this.lstelementos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elementos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dato";
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(328, 108);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(113, 24);
            this.txtdato.TabIndex = 3;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(328, 169);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(113, 45);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.Text = "Nuevo dato";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(328, 243);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(113, 40);
            this.btnborrar.TabIndex = 5;
            this.btnborrar.Text = "Borrar datos";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.Location = new System.Drawing.Point(63, 400);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(60, 18);
            this.lblindice.TabIndex = 6;
            this.lblindice.Text = "lblindice";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(328, 319);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(113, 53);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar seleccionados";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Form17ColeccionesGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 478);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblindice);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstelementos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form17ColeccionesGraficas";
            this.Text = "Form17ColeccionesGraficas";
            this.Load += new System.EventHandler(this.Form17ColeccionesGraficas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label lblindice;
        private System.Windows.Forms.Button btneliminar;
    }
}