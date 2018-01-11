using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Fundamentos
{
    public partial class Form25TablaCajas : Form
    {
        public Form25TablaCajas()
        {
            InitializeComponent();
        }
        
        private void btnmostrartabla_Click(object sender, EventArgs e)
        {
            string indice = ""; int i = 1; string resultado = "";
            int numero = int.Parse(this.txtnumeroentrada.Text.ToString());

            //System.Windows.Forms.Timer reloj = new System.Windows.Forms.Timer();
            //reloj = new System.Windows.Forms.Timer()
            //{
            //    Enabled =true,
            //    Interval = 1000/2
                
            //};
            //reloj.Tick += delegate (object asender, EventArgs ae)
            //{
            //    for (int a = 0; a < 9; a++)
            //    {
            //        this.lbinfo.Text = a.ToString();
                  
            //    }


            //};




            foreach (Control z in this.Controls)
            {
                if (z is TextBox && z.Name != "txtnumeroentrada")
                {
                    i++;
                }
                
            }

            

            
            foreach (Control c in this.Controls)
            {
                
                if (c is TextBox && c.Name != "txtnumeroentrada")
                {
                    i--;
                    indice = i.ToString();
                    resultado = (i * numero).ToString();

                    if (c.Name == "textBox" + indice)
                    {
                        
                            c.Text = resultado;                        
                        
                       
                    }

                }
                
            }

        
        }

      

        private void Form25TablaCajas_Load(object sender, EventArgs e)
        {
           

        }

        private void txtnumeroentrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c.Name == "textBox1")
                {
                    c.BackColor = Color.Aquamarine;
                }

            }
        }

        private void textBox1_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c.Name == "textBox2")
                {
                    c.BackColor = Color.Yellow;
                }

            }

        }

       

        private void textBox2_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c.Name == "textBox3")
                {
                    c.BackColor = Color.Green;
                }

            }
        }
    }
    }

