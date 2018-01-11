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
    public partial class Form23TemperaturasColecciones : Form
    {
        List<int> coleccionnumeros = new List<int>();
        public Form23TemperaturasColecciones()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int minima = this.coleccionnumeros[0];
            int maximo = this.coleccionnumeros[0];
            int suma = 0;
            foreach(int num in this.coleccionnumeros)
            {
                maximo = Math.Max(maximo, num);
                minima = Math.Max(minima, num);
                suma += num;
            }
            this.txmaxima.Text = maximo.ToString();
            this.txminima.Text = minima.ToString();
            this.txmedia.Text = (suma / 12).ToString();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse("01/01/2017");
            //limpiamos la lista grafica
            this.lsttemperaturas.Items.Clear();
            //limpiamos la lista de numeros
            this.coleccionnumeros.Clear();
            Random rnd = new Random();
            for(int i=0;i<=12;i++)
            {
                String nombremes =
                    fecha.ToString("MMMM").ToUpper();
                int aleatorio = rnd.Next(-50, 44);
                String descripccion = nombremes + ": " + aleatorio;
                this.coleccionnumeros.Add(aleatorio);
                fecha = fecha.AddMonths(1);
            }
        }

        private void Form23TemperaturasColecciones_Load(object sender, EventArgs e)
        {

        }
    }
}
