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
    public partial class Form35TemperaturasAnuales : Form
    {
        List<Año> años;// coleccion para almacenar todos los años
        public Form35TemperaturasAnuales()
        {
            InitializeComponent();
            this.años = new List<Año>();
        }

        private void Form35TemperaturasAnuales_Load(object sender, EventArgs e)
        {

        }

        private void txtnumerodeaños_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbaño.SelectedIndex!=-1)
            {
                int indice = this.cmbaño.SelectedIndex;
                Año anyo = this.años[indice];
                //limpiamos la lista de meses
                this.lstmeses.Items.Clear();
                foreach(Mes mes in anyo.Meses)
                {
                    this.lstmeses.Items.Add(mes);
                }
                this.txtmediaanual.Text =
                    anyo.GetTemperaturaMediaAnual().ToString();
                this.txtmaximaanual.Text = anyo.GetMaxima().ToString();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numanyos = int.Parse(this.txtnumerodeaños.Text);
            int anyoinicio = 2011;
            for(int i =0;i<=numanyos;i++)
            {
                //cada iteracion creamos un año atomaticamente ,con meses
                Año anyo = new Año(true);
                anyo.Nombre = anyoinicio.ToString();
                anyoinicio += 1;
                this.años.Add(anyo);
                this.cmbaño.Items.Add(anyo.Nombre);
            }
          
        }

        private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstmeses.SelectedIndex!=-1)
            {
                int indiceaño = this.cmbaño.SelectedIndex;
                int indicemes = this.lstmeses.SelectedIndex;
                Mes mes = this.años[indiceaño].Meses[indicemes];
                this.txtmediamensual.Text = mes.GetMedia().ToString();
            }
        }
    }
}
