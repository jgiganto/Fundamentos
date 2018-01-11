using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncambiartexto_Click(object sender, EventArgs e)
        {
            //LAS CONVERSIONES ENTRE TIPOS
            //AUTOMATICA (Capacidad mayor)
            int num1 = 78942378;
            double d = num1;
            //CONVERSION ENTRE WRAPPERS(Casting)
            //(clase)objeto
            double dd = 787.78;
            int num2 = (int)dd;
            //CONVERSION A STRING 
            int num3 = 456;
            String t = num3.ToString();
            //CONVERSION STRING A WRAPPER(Parse)
            String texto = "12"; //tienen que ser comillas dobles "
            int num4 = int.Parse(texto);
            //TIPOS DE ERRORES . (IMPORTANTE)
            //ERRORES DE COMPILACIÓN (errores de código)
            //   int num1 = 44;
            //  int numero = "33";
            //TODAS LAS PROPIEDADES TIENEN TIPOS DE DATOS DEFINIDOS
            //PROPIEDADES WRAPPER
            txttexto.Text = "Esto es un texto";
            //PROPIEDADES ENUMERADAS
            //LAS RECONOCEREMOS POR EL ICONO AMARILLO
            txttexto.TextAlign = HorizontalAlignment.Center;
            //PROPIEDADES DE OBJETO (new)
            txttexto.Size = new Size(250, 250);
            //PROPIEDADES CON CLASE FINAL 
            //Una clase final es aquella que no se instancia,
            //se "utiliza" porque los valores que ofrece son cerrados. 
            txttexto.BackColor = Color.Firebrick;
            txttexto.Multiline = true;
            //ACCEDER A UNA REFERENCIA EN UN ESPACIO DE NOMBRES
            //ES COMO UN ACCESO DIRECTO
            FileInfo fichero;
            //RUTA COMPLETA DEL NAMESPACE
            System.IO.FileInfo archivo;
            //TIPOS DE METODO
            //METODOS SIN PARAMETROS
            txttexto.Paste();
            txttexto.Focus();
            //METODOS CON PARAMETROS
            txttexto.Select(0, 4);



        }

        private void txttexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
