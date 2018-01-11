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
    public partial class Form10SumarNumeros : Form
    {
        public Form10SumarNumeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena = this.txtnumeros.Text;
            //recorremos todo el contenido del texto
            //variable sumar para todos los datos
            int suma = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                //recuperamos cada caracter del texto
                char caracter = cadena[i];
                //convertimos cada caracter a número
                int numero = int.Parse(caracter.ToString());
                //sumamos cada letra obtenida
                suma += numero;
            }
            this.lblsuma.Text = "Suma: " + suma;
        }
    }
}
