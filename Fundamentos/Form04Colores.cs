using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form04Colores : Form
    {
        public Form04Colores()
        {
            InitializeComponent();
        }

        private void Form04Colores_Load(object sender, EventArgs e)
        {
               
        }

        private void txtrojo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtverde_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtazul_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rojo = 0; 
            if (this.txtrojo.Text == "" ||
                int.Parse(this.txtrojo.Text) > 255 ||
                int.Parse(this.txtrojo.Text) < 0)
            {
                MessageBox.Show("Debe escribir en las cajas, 0-255", "ATENTO!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                rojo = int.Parse(this.txtrojo.Text);
               
                this.txtrojo.BackColor = Color.FromArgb(rojo, 0, 0);
                this.txtrojo.ForeColor = Color.FromArgb(0, 255-rojo, 255-rojo);
            }
            int verde = 0;
            if (this.txtverde.Text == ""
                ||
                int.Parse(this.txtverde.Text) > 255 ||
                int.Parse(this.txtverde.Text) < 0)
            {
                MessageBox.Show("Debe escribir en las cajas, 0-255", "ATENTO!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                verde = int.Parse(this.txtverde.Text);
                this.txtverde.BackColor = Color.FromArgb(0, verde, 0);
                this.txtverde.ForeColor = Color.FromArgb(255 - verde, 0, 255 - verde);
            }
            int azul = 0;
            if (this.txtazul.Text == ""
                ||
                int.Parse(this.txtazul.Text) > 255 ||
                int.Parse(this.txtazul.Text) < 0)
            {
                MessageBox.Show("Debe escribir en las cajas, 0-255", "ATENTO!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                azul = int.Parse(this.txtazul.Text);
                this.txtazul.BackColor = Color.FromArgb(0, 0, azul);
                this.txtazul.ForeColor = Color.FromArgb(200, 255 - azul, 0);
            }
            this.BackColor = Color.FromArgb(rojo, verde, azul);

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
