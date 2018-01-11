namespace Fundamentos
{
    partial class Form32Imagenes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnrotar = new System.Windows.Forms.Button();
            this.btnabrir = new System.Windows.Forms.Button();
            this.grdialog = new System.Windows.Forms.GroupBox();
            this.grimagenes = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grimagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnrotar);
            this.panel1.Controls.Add(this.btnabrir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 596);
            this.panel1.TabIndex = 0;
            // 
            // btnrotar
            // 
            this.btnrotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnrotar.Location = new System.Drawing.Point(14, 155);
            this.btnrotar.Name = "btnrotar";
            this.btnrotar.Size = new System.Drawing.Size(106, 86);
            this.btnrotar.TabIndex = 1;
            this.btnrotar.Text = "Rotar";
            this.btnrotar.UseVisualStyleBackColor = false;
            this.btnrotar.Click += new System.EventHandler(this.btnrotar_Click);
            // 
            // btnabrir
            // 
            this.btnabrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnabrir.Location = new System.Drawing.Point(14, 49);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(106, 79);
            this.btnabrir.TabIndex = 0;
            this.btnabrir.Text = "Abrir Imágenes";
            this.btnabrir.UseVisualStyleBackColor = false;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // grdialog
            // 
            this.grdialog.Location = new System.Drawing.Point(200, 12);
            this.grdialog.Name = "grdialog";
            this.grdialog.Size = new System.Drawing.Size(419, 190);
            this.grdialog.TabIndex = 1;
            this.grdialog.TabStop = false;
            this.grdialog.Text = "grupo dialogo";
            this.grdialog.Enter += new System.EventHandler(this.grdialog_Enter);
            // 
            // grimagenes
            // 
            this.grimagenes.Controls.Add(this.pictureBox3);
            this.grimagenes.Controls.Add(this.pictureBox2);
            this.grimagenes.Controls.Add(this.pictureBox1);
            this.grimagenes.Location = new System.Drawing.Point(175, 250);
            this.grimagenes.Name = "grimagenes";
            this.grimagenes.Size = new System.Drawing.Size(487, 307);
            this.grimagenes.TabIndex = 2;
            this.grimagenes.TabStop = false;
            this.grimagenes.Text = "grupo imagenes";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(327, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(181, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form32Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 596);
            this.Controls.Add(this.grimagenes);
            this.Controls.Add(this.grdialog);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form32Imagenes";
            this.Text = "Form32Imagenes";
            this.panel1.ResumeLayout(false);
            this.grimagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnrotar;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.GroupBox grdialog;
        private System.Windows.Forms.GroupBox grimagenes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}