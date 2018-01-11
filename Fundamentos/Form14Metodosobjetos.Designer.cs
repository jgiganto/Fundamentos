namespace Fundamentos
{
    partial class Form14Metodosobjetos
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnmostrardoble = new System.Windows.Forms.Button();
            this.lbrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnmostrardoble
            // 
            this.btnmostrardoble.Location = new System.Drawing.Point(99, 109);
            this.btnmostrardoble.Name = "btnmostrardoble";
            this.btnmostrardoble.Size = new System.Drawing.Size(109, 23);
            this.btnmostrardoble.TabIndex = 1;
            this.btnmostrardoble.Text = "mostrar doble";
            this.btnmostrardoble.UseVisualStyleBackColor = true;
            this.btnmostrardoble.Click += new System.EventHandler(this.btnmostrardoble_Click);
            // 
            // lbrespuesta
            // 
            this.lbrespuesta.AutoSize = true;
            this.lbrespuesta.Location = new System.Drawing.Point(33, 223);
            this.lbrespuesta.Name = "lbrespuesta";
            this.lbrespuesta.Size = new System.Drawing.Size(35, 13);
            this.lbrespuesta.TabIndex = 2;
            this.lbrespuesta.Text = "label1";
            // 
            // Form14Metodosobjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 343);
            this.Controls.Add(this.lbrespuesta);
            this.Controls.Add(this.btnmostrardoble);
            this.Controls.Add(this.button1);
            this.Name = "Form14Metodosobjetos";
            this.Text = "Form14Metodosobjetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmostrardoble;
        private System.Windows.Forms.Label lbrespuesta;
    }
}