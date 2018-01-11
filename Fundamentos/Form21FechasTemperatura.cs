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
    public partial class Form21FechasTemperatura : Form
    {
        public Form21FechasTemperatura()
        {
            InitializeComponent();
        }
        int media = 0;int maxima = -15;int minima = 30;
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            maxima = -15;   minima = 30;
            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("es-ES"); 
            DateTime meses = new DateTime();
            Random ale = new Random();
            int total = 0;
            this.lsttemperaturas.Items.Clear();

            for (int i = 0; i <= 11; i++)
            {
                int temp = ale.Next(-15, 30);
                string temperatura = temp.ToString();
                String mimes = meses.AddMonths(i).ToString("MMMM",cultura);
                mimes = mimes.ToUpper()+ ":" +temperatura;
                 this.lsttemperaturas.Items.Add(mimes);
                total += temp;
                
                if(temp>maxima)
                {
                    maxima = temp;
                }
                if(temp<minima)
                {
                    minima = temp;
                }
            }
            
             media = total / 12;
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            this.txmedia.Text = media.ToString();
            this.txminima.Text = minima.ToString();
            this.txmaxima.Text = maxima.ToString();
        }
    }
}
