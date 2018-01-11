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
    public partial class Form24SepararControlesColor : Form
    {
        public Form24SepararControlesColor()
        {
            InitializeComponent();
        }

        private void Form24SepararControlesColor_Load(object sender, EventArgs e)
        {
            //// List<Control> listadetodo = new List<Control>();
            ////Form formu = new Form();
            //foreach(Control c in this.Controls)
            //{
            //    if(c.Controls.GetType(this.Button)==true)
            //    {

            //    }
            //}

            //quiero recorrer todos los controles para diferenciarlos
            //tenemos la coleccion controls
            foreach(Control c in this.Controls)
            {
                //debemos preguntar por el tipo de control
                if(c is Button)
                {
                    c.BackColor = Color.Yellow;
                }else if (c is TextBox)
                {
                    c.BackColor = Color.LightBlue;
                    //le aplicamos el metodo paste()
                    //c.Paste();  aqui no funciona , hay que bajar un nivel a su clase especifica
                    //esto se hace con un casting
                    ((TextBox)c).Paste();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
