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
    public partial class Form18SumaAleatorios : Form
    {
        public Form18SumaAleatorios()
        {
            InitializeComponent();
        }
        String sumatx = ""; int suma = 0;
        private void btnaleatorios_Click(object sender, EventArgs e)
        {
            int ran = 0;  suma = 0;
            Random ale = new Random();
           
            this.lsnumeros.Items.Clear();
            for(int i=0; i<9;i++)
            {
                ran = ale.Next(0, 100);
                String dato = ran.ToString();
                this.lsnumeros.Items.Add(dato);
                suma += ran;
            }
              sumatx = suma.ToString();
        }

       

        private void btnsumarseleccionados_Click(object sender, EventArgs e)
        {
             int nume = 0; suma = 0;

            int numero = int.Parse(this.lsnumeros.SelectedIndices.Count.ToString());
            int posicionitems = 0;
            for (int  i = 0;i < numero; i++)           
            {
                
                if (this.lsnumeros.SelectedItem != null)
                {
                    string numer = this.lsnumeros.SelectedItems[posicionitems].ToString();
                    nume = int.Parse(numer);
                    suma += nume;
                    posicionitems++;
                }
               

            }
            txtresultado.Text = suma.ToString();
            
        }

        private void btnsumartodos_Click(object sender, EventArgs e)
        {
            this.txtresultado.Text = sumatx;
        }

        private void lsnumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        

        
        private void Form18SumaAleatorios_Load(object sender, EventArgs e)
        {

        }
    }
}
