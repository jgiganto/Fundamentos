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
    public partial class Form33HerenciaClases : Form
    {
        public Form33HerenciaClases()
        {
            InitializeComponent();
        }

        private void btncoche_Click(object sender, EventArgs e)
        {
            this.lstdetalles.Items.Clear();
            Coche car = new Coche();//sin parametros
            Coche car2 = new Coche("Renault", "Twingo");//con parametros
            car.Marca = "Seat";
            car.Modelo = "Panda";
            car.Acelerar();
            car.Frenar();

            this.lstdetalles.Items.Add("Coche " + car.ToString());
            this.lstdetalles.Items.Add("Valocidad Máxima" + car.GetVelocidadMaxima());
            this.lstdetalles.Items.Add("Velocidad actual " + car.VelocidadActual);
            this.lstdetalles.Items.Add("acelerando... ");
            car.Acelerar();
            this.lstdetalles.Items.Add("Velocidad actual " + car.VelocidadActual);
            car.Acelerar();
            this.lstdetalles.Items.Add("Velocidad actual " + car.VelocidadActual);
        }

        private void btndeportivo_Click(object sender, EventArgs e)
        {
            this.lstdetalles.Items.Clear();
            Deportivo car = new Deportivo();
            Deportivo car2 = new Deportivo("Ferrari","Testarossa"); 
            
            car.Marca = "Lambo";
            car.Modelo = "Murcielago";
           // car.VelocidadMaxima = 390;
            car.Acelerar();
            car.Frenar();

            this.lstdetalles.Items.Add("Coche " + car.ToString());
            this.lstdetalles.Items.Add("Valocidad Máxima" + car.GetVelocidadMaxima());
            this.lstdetalles.Items.Add("Velocidad actual " + car.VelocidadActual);
            this.lstdetalles.Items.Add("acelerando... ");
            car.Acelerar(true);
            this.lstdetalles.Items.Add("Velocidad actual " + car.VelocidadActual);
            car.Acelerar();
            this.lstdetalles.Items.Add("Velocidad actual " + car.VelocidadActual);
        }

        private void Form33HerenciaClases_Load(object sender, EventArgs e)
        {

        }
    }
}
