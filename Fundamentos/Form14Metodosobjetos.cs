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
    public partial class Form14Metodosobjetos : Form
    {
        public Form14Metodosobjetos()
        {
            InitializeComponent();
        }

        private void btnmostrardoble_Click(object sender, EventArgs e)
        {
            int dato = 7;
            this.DobleReferencia(ref dato);
            this.lbrespuesta.Text = dato.ToString();
            /*si hablamos de objetos , TODOS son establecidos por referencia*/
            Button boton = this.button1; //funciona igual que la linea de abajo
            //this.button1.BackColor = Color.Yellow;
            boton.BackColor = Color.Yellow;
            this.CambiarColor(boton, Color.Fuchsia);
            this.CambiarColor(this.btnmostrardoble, Color.GreenYellow);
            int resultado = this.SumarNumeros(5, 6);
            this.lbrespuesta.Text += "\nresultado "+resultado.ToString();

        }
        /*vamos a hacer un metodo que recibira una variable wrapper por referencia
         es decir , si modificamos la variable del metodo , estamos modificando
         la variable de la llamada*/

            public void DobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        //metodos que devuelven valor
        //solamente pueden devolver un objeto
        public int SumarNumeros(int num1, int num2)
        {
            //acciones
            int suma = num1 + num2;
            return suma;
        }
        public void CambiarColor(Button boton,Color color)
        {
            boton.BackColor = color;
        }





        //vamos a crear un metodo para visualizar
        //una variable wrapper enviada por valor
        public void DobleValor(int numero)
        {
            numero = numero * 2;

        }
    }
}
