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
    public partial class Form34HerenciaPersonaEmpleadocs : Form
    {
        public Form34HerenciaPersonaEmpleadocs()
        {
            InitializeComponent();
        }

        private void Form34HerenciaPersonaEmpleadocs_Load(object sender, EventArgs e)
        {

        }

        private void btnpersona_Click(object sender, EventArgs e)
        {
            this.lsdetalles.Items.Clear();
            Personaa humano = new Personaa("Jesus", "Giganto");
            Personaa humano2 = new Personaa();
            int edad = 25;
            

            this.lsdetalles.Items.Add("Personaa: " + humano.GetNombreCompleto());
            //this.lsdetalles.Items.Add("Personaa: " + humano2.RecuperarEdad(edad));

        }
    }
}
