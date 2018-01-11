using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form22ColeccionesNoGraficas : Form
    {
        public Form22ColeccionesNoGraficas()
        {
            InitializeComponent();
        }

        private void Form22ColeccionesNoGraficas_Load(object sender, EventArgs e)
        {
            //coleccion no tipada
            //ArrayList listasintipo = new ArrayList();
            //listasintipo.Add(this.button1);
            //listasintipo.Add(this.button2);
            //listasintipo.Add("Un texto");                                CONCEPTO: ABSTRACCIÓN
            //foreach(Object boton in listasintipo)
            //{
            //    if(boton is Button)
            //    {
            //        ((Button)boton).BackColor = Color.Yellow;
            //        //boton.BackColor = Color.Yellow;
            //    }

            //}

            //coleccion TYPE-SAFE (tipada)
            /*
                        
             */
        ////    List<Control> listacontipo = new List<Button>//el compilador sabe lo que voy a almacenar en su interior
        //    listacontipo.Add(this.button1);
        //    listacontipo.Add(this.button2);
        //    listacontipo.Add(this.textBox1);
        //    //listacontipo.Add("Un texto");   //el compilador sabe que no es un boton. /
        //    foreach(Control boton in listacontipo)
        //    {
        //        boton.BackColor = Color.Yellow;
        //    }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
