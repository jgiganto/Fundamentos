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
    public partial class Form03Sentencias : Form
    {
        public Form03Sentencias()
        {
            InitializeComponent();
        }

        private void Form03Sentencias_Load(object sender, EventArgs e)
        {

        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            /*COMPROBAMOS QUE HAYA CONTENIDO 
             * EN LAS CAJAS PARA EVALUAR EL NUMERO              
             */

            if (this.txtnumero1.Text=="" || this.txtnumero2.Text==string.Empty) //es lo mismo que "", vacio
            {
                /*MOSTRAR MENSAJES EN PANTALLA*/
                MessageBox.Show("Debe escribir en las cajas","ATENTO", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                int num1 = int.Parse(this.txtnumero1.Text);
                int num2 = int.Parse(this.txtnumero2.Text);
                //int mayor;//solo con esto da error de compilación porque en el caso que no cumpla el 
                //if nunca sera instanciada . inicializada
                int mayor = 0;
                if (num1 > num2)
                {
                    mayor = num1;
                }
                else if(num1<num2)
                {
                    mayor = num2;
                }

                this.lblrespuesta.Text = "Mayor = " + mayor;
            }
        }
    }
}
