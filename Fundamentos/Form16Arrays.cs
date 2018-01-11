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
    public partial class Form16Arrays : Form
    {
        public Form16Arrays()
        {
            InitializeComponent();
        }

        private void Form16Arrays_Load(object sender, EventArgs e)
        {
            //declaración de ARRAY
            Button[] arraybotones = new Button[3];
            arraybotones[0] = this.button1;
            arraybotones[1] = this.button2;
            arraybotones[2] = this.button3;

            arraybotones[1].Text = "Botón 2";
            foreach (Button boton in arraybotones)
            {
                boton.BackColor = Color.GreenYellow;
            }

            /* Existe un conjunto dentro de los formularios que contiene todos los 
         controles que hayamos dibujado
         La propiedad es .Controls
         Debemos cambiar el color de fondo a todos los controles del formulario*/
          
            foreach(Control c in this.Controls)
            {
                c.BackColor = Color.Yellow;
            }

        }

        
        
    }
}
