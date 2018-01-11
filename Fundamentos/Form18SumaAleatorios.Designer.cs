namespace Fundamentos
{
    partial class Form18SumaAleatorios
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
            this.lsnumeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaleatorios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsumartodos = new System.Windows.Forms.Button();
            this.btnsumarseleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsnumeros
            // 
            this.lsnumeros.FormattingEnabled = true;
            this.lsnumeros.Location = new System.Drawing.Point(31, 72);
            this.lsnumeros.Name = "lsnumeros";
            this.lsnumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsnumeros.Size = new System.Drawing.Size(162, 329);
            this.lsnumeros.TabIndex = 0;
            this.lsnumeros.SelectedIndexChanged += new System.EventHandler(this.lsnumeros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numeros:";
            // 
            // btnaleatorios
            // 
            this.btnaleatorios.Location = new System.Drawing.Point(255, 121);
            this.btnaleatorios.Name = "btnaleatorios";
            this.btnaleatorios.Size = new System.Drawing.Size(103, 55);
            this.btnaleatorios.TabIndex = 2;
            this.btnaleatorios.Text = "Generar números";
            this.btnaleatorios.UseVisualStyleBackColor = true;
            this.btnaleatorios.Click += new System.EventHandler(this.btnaleatorios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suma";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(255, 72);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 4;
            // 
            // btnsumartodos
            // 
            this.btnsumartodos.Location = new System.Drawing.Point(255, 214);
            this.btnsumartodos.Name = "btnsumartodos";
            this.btnsumartodos.Size = new System.Drawing.Size(103, 59);
            this.btnsumartodos.TabIndex = 5;
            this.btnsumartodos.Text = "Sumar todos";
            this.btnsumartodos.UseVisualStyleBackColor = true;
            this.btnsumartodos.Click += new System.EventHandler(this.btnsumartodos_Click);
            // 
            // btnsumarseleccionados
            // 
            this.btnsumarseleccionados.Location = new System.Drawing.Point(255, 304);
            this.btnsumarseleccionados.Name = "btnsumarseleccionados";
            this.btnsumarseleccionados.Size = new System.Drawing.Size(103, 64);
            this.btnsumarseleccionados.TabIndex = 6;
            this.btnsumarseleccionados.Text = "Sumar seleccionados";
            this.btnsumarseleccionados.UseVisualStyleBackColor = true;
            this.btnsumarseleccionados.Click += new System.EventHandler(this.btnsumarseleccionados_Click);
            // 
            // Form18SumaAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 501);
            this.Controls.Add(this.btnsumarseleccionados);
            this.Controls.Add(this.btnsumartodos);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaleatorios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsnumeros);
            this.Name = "Form18SumaAleatorios";
            this.Text = "Form18SumaAleatorios";
            this.Load += new System.EventHandler(this.Form18SumaAleatorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsnumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaleatorios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsumartodos;
        private System.Windows.Forms.Button btnsumarseleccionados;
    }
}