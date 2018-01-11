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
    public partial class Form12ValidarISBN : Form
    {
        public Form12ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            string textoisbn = this.txtisbn.Text;
            long total = 0 ;
            for (int i = 0; i < textoisbn.Length; i++)
            {

                if (textoisbn.Length != 10 || char.IsNumber(textoisbn[i]) == false)
                {
                this.lblresultado.Text = "Debe introducir 10 caracteres numéricos";
                    
                }
            else
                {

               
                    //char caracter = textoisbn[i];
                    //if (char.IsNumber(textoisbn[i]) == false)
                    //{
                    //    this.lblresultado.Text = "Debe introducir solo números";
                    //    break;
                    //}
                    long nume = long.Parse(textoisbn[i].ToString());
                      total = total + (nume * (i+1));

                }


                


            }
            if ((total %= 11) == 0 && textoisbn.Length == 10 )
            {
                this.lblresultado.Text = "El ISBN es correcto";

            }
            else
            {
                this.lblresultado.Text += " El ISBN NO es correcto";

            }



        }
    }
}
