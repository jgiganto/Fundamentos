using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form35TemperaturasClases : Form
    {
        List<Mes> meses = new List<Mes>();
        public Form35TemperaturasClases()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //al pulsar el boton debemos borrar la lista grafica(listbox)
            //borramos la memoria (list<>)
            this.meses.Clear();
            this.lstmeses.Items.Clear();
            Random rnd = new Random();
            DateTime fecha = DateTime.Parse("01/01/2000");
            for(int i = 1;i<= 12;i++)
            {
                Mes mes = new Mes(); // creo un objeto mes por cada iteracion
                mes.Nombre = fecha.ToString("MMMM");
                int max = rnd.Next(1, 40);
                int min = rnd.Next(-15, 1);
                mes.TemperaturaMaxima = max;
                mes.TemperaturaMinima = min;
                fecha = fecha.AddMonths(1);
                //cada mes lo dibujamos en la lista del listbox
                this.lstmeses.Items.Add(mes);
                //almacenamos en nuestra coleccion cada mes
                this.meses.Add(mes);
            }
        }

        private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstmeses.SelectedIndex != -1)
            {
                int indice =
                    this.lstmeses.SelectedIndex;
                Mes mes = this.meses[indice];
                this.txtmaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtminima.Text = mes.TemperaturaMinima.ToString();
                this.txtmedia.Text = mes.GetMedia().ToString();
            }
        }

        private void Form35TemperaturasClases_Load(object sender, EventArgs e)
        {

        }
    }
}
