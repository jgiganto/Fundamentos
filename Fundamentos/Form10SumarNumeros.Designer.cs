﻿namespace Fundamentos
{
    partial class Form10SumarNumeros
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
            this.lblsuma = new System.Windows.Forms.Label();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.btnnumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números: ";
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuma.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblsuma.Location = new System.Drawing.Point(23, 239);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(82, 24);
            this.lblsuma.TabIndex = 1;
            this.lblsuma.Text = "lblsuma";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(107, 30);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(165, 20);
            this.txtnumeros.TabIndex = 2;
            // 
            // btnnumeros
            // 
            this.btnnumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnumeros.Location = new System.Drawing.Point(107, 95);
            this.btnnumeros.Name = "btnnumeros";
            this.btnnumeros.Size = new System.Drawing.Size(129, 49);
            this.btnnumeros.TabIndex = 3;
            this.btnnumeros.Text = "Sumar números";
            this.btnnumeros.UseVisualStyleBackColor = true;
            this.btnnumeros.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 335);
            this.Controls.Add(this.btnnumeros);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.label1);
            this.Name = "Form10SumarNumeros";
            this.Text = "Form10SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Button btnnumeros;
    }
}