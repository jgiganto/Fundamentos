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
    public partial class Form32Imagenes : Form
    {
        String[] ruta = new string[2]; int i = 0;int x = 0; int y = 0; int z = 0;
        //OpenFileDialog ofi1 = new OpenFileDialog();
        //ofi1.Filter = "Imágenes JPG|*.JPG";
        //    ofi1.Multiselect = true;

        public Form32Imagenes()
        {
            InitializeComponent();
        }

        private void grdialog_Enter(object sender, EventArgs e)
        {
            


        }

        private void btnabrir_Click(object sender, EventArgs e)
        {

            /*String[]*/ ruta = new string[2];

            OpenFileDialog ofi1 = new OpenFileDialog();
            ofi1.Filter = "Imágenes JPG|*.JPG";
            ofi1.Multiselect = true;

            if (ofi1.ShowDialog() == DialogResult.OK)
            {
                ruta = ofi1.FileNames;
                foreach (string c in ruta)
                {
                    //foreach (Control p in this.grimagenes.Controls)
                    //{
                    //    if (p is PictureBox)
                    //    {
                    //        PictureBox foto = p as PictureBox;
                    //        foto.Image = Image.FromFile(c);

                    //    }
                    //}


                }
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0) { x = 0;y = 1;z = 2; }
                    if (i == 1) { x = 2; y = 0; z = 1; }
                    if (i == 2) { x = 1; y = 2; z = 0; }

                    pictureBox1.Image = Image.FromFile(ruta[x]);
                    pictureBox2.Image = Image.FromFile(ruta[y]);
                    pictureBox3.Image = Image.FromFile(ruta[z]);


                    Application.DoEvents();
                        System.Threading.Thread.Sleep(1000);
                        if (i == 2) { i = -1; }
                }
               

            }
        }

        private void btnrotar_Click(object sender, EventArgs e)
        {
            Timer reloj = new Timer();
            reloj.Interval = 500;
            reloj.Tick += Reloj_Tick;
            reloj.Enabled = true;
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {


            pictureBox1.Image = Image.FromFile(ruta[i]);

            i++;
            if (i > 2) { i = 0; }

        }
    }
}
