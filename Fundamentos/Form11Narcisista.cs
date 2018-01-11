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
    public partial class Form11Narcisista : Form
    {
        public Form11Narcisista()
        {
            InitializeComponent();
        }

        private void btnnarcisista_Click(object sender, EventArgs e)
        {
            string textonumero = this.txtnumero.Text;
            int numero = int.Parse(textonumero.ToString());
            int longitud = textonumero.Length;
            double resultado = 0;
            for(int i = 0;i<longitud;i++)
            {
                char num = textonumero[i];
                int nume = int.Parse(num.ToString());

               resultado += Math.Pow(nume, longitud);
            }
            if (resultado == numero)
            {
                this.lblresultado.Text = "El número : " + textonumero + " es narcisista";
            }
            else
            {
                this.lblresultado.Text = "El número : " + textonumero + " no es narcisista";
            }
        }

        
    }
}
