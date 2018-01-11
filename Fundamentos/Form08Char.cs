using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form08Char : Form
    {
        public Form08Char()
        {
            InitializeComponent();
        }

        private void btnanalizar_Click(object sender, EventArgs e)
        {
            //UN BUCLE PARA RECORRER TODOS LOS CARACTERES DEL CODIGO ASCII(255)
           
            for (int i = 0; i <= 255; i++)
            {
                //NECESITAMOS CADA LETRA QUE CORRESPONDA AL NÚMERO
                char caracter = (char)i;
                //PREGUNTAMOS SOBRE EL TIPO DE CARACTER QUE ESTAMOS ALMACENANDO
                if(char.IsLetter(caracter)==true)
                {
                    this.txtletras.Text += caracter;
                }else if(char.IsNumber(caracter)==true)
                {
                    this.txtnumeros.Text += caracter;
                }
                else if(char.IsPunctuation(caracter)==true)
                {
                    this.txtpuntuacion.Text += caracter;
                }
                else if (char.IsSymbol(caracter) == true)
                {
                    this.txtsimbolos.Text += caracter;
                }
                else
                {
                    this.txtotros.Text += caracter;
                }
            }
        }
    }
}
