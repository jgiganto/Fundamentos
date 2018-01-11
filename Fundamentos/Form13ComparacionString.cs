using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace Fundamentos
{
    public partial class Form13ComparacionString : Form
    {
        public Form13ComparacionString()
        {
            InitializeComponent();
        }

        private void btninvertir_Click(object sender, EventArgs e)
        {
            String texto = this.txttexto.Text;
            int j = 0;

            for (int i = texto.Length-1; i >= 0; i--)
            {

                char caracter = texto[i];
                //this.txttexto.Text += ""+ caracter;
                texto = texto.Remove(texto.Length - 1, 1);
               
                    texto = texto.Insert(j, caracter.ToString());
                j++;

            }
            this.txttexto.Text = texto;
            //vamos a ver el tiempo que tarda el programa en realizar la accion
            //Stopwatch krono = new Stopwatch();
            ////capturamos la cadena de la caja
            //String cadena = this.txttexto.Text;
            ////iniciamos el krono
            //krono.Start();
            ////RECORREMOS TODOS LOS CARACTERES
            //for (int i = 0; i < cadena.Length; i++)
            //{
            //    //capturamos la ultima letra
            //    char letra = cadena[cadena.Length - 1];
            //    //eliminamos la letra del texto para cambiarla de posicion
            //    cadena = cadena.Remove(cadena.Length - 1, 1);
            //    //insertamos la letra capturada en cada posicion de i;
            //    cadena = cadena.Insert(i, letra.ToString());
            //}
            //krono.Stop();
            //this.txttexto.Text = cadena;
            //this.lbltiempo.Text = "segundos " + krono.Elapsed.Seconds +
            //    "\nMilisegundos: " + krono.ElapsedMilliseconds;


        }

        private void btnbouilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //iniciamos un objeto stringbuilder
            StringBuilder texto = new StringBuilder();
            //si deseamos añadir algo al objeto 
            //se realiza con el metodo append(String)
            texto.Append(this.txttexto.Text);
            //recorremos todo el contenido
            krono.Start();
            for(int i=0;i<texto.Length;i++)
            {
                char letra = texto[texto.Length - 1];
                texto.Remove(texto.Length - 1, 1);  // ya no se iguala porque es un objeto mutable
                texto.Insert(i, letra);

            }
            krono.Stop();
            this.txttexto.Text = texto.ToString();
            this.lbltiempo.Text = "segundos " + krono.Elapsed.Seconds +
              "\nMilisegundos: " + krono.ElapsedMilliseconds;

        }
    }
}
