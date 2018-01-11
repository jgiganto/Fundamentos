using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fundamentos
{
    public partial class pruebas : Form
    {
        public pruebas()
        {
            InitializeComponent();
        }
        int num = 0;
        private void btnrand_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            num = ran.Next(65, 70);
            char caracter = (char)num;
            int j = 0;
            StringBuilder texto = new StringBuilder();
            // String mitexto = "AB";
            texto.Insert(0, caracter);
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < 2; i++)
                {
                    j++;
                    num = ran.Next(65, 90);
                      caracter = (char)num;
                    //texto = caracter.ToString();
                    if (texto.Length == 2)
                    {
                        texto.Remove(1, 1);                        
                    }
                    texto.Insert(i, caracter);

                    this.txtresultado.Text += texto;

                    if ((j %= 1) == 0)
                    {
                        
                        if (texto.ToString().Equals("AB")==true)
                        {
                            this.txtresultado.Text += "-encontrado\n";
                            break;
                        }

                        
                    }
                    if (texto.Length == 2|| j==0) { this.txtresultado.Text += "\n"; }
                    

                }
                


            }
        }
    }
}
