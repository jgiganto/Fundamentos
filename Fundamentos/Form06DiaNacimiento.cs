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
    public partial class Form06DiaNacimiento : Form
    {
        public Form06DiaNacimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia  = 0;int mes = 0;int año = 0 ; int paso1 = 0;
            int paso2 = 0; int paso3 = 0; int paso4 = 0;
            int parc5 = 0; int parc6 = 0; int parc7 = 0;
            dia = int.Parse(this.txtdia.Text);
            mes = int.Parse(this.txtmes.Text);
            año = int.Parse(this.txtaño.Text);

            if (mes == 01) {mes = 13; año = año - 1;  }
            if (mes == 02) { mes = 14;año = año - 1; }
            paso1 = ((mes + 1) * 3) / 5;
            paso2 = año / 4;
            paso3 = año / 100;
            paso4 = año / 400;
            parc5 = dia + (mes * 2) + año + paso1 + paso2 - paso3 + paso4 + 2;
            parc6 = parc5 / 7;
            parc7 = parc5 - (parc6 * 7);
            
            switch(parc7)
            {
                case 1:
                        this.txtresultado.Text = "Naciste un Domingo";
                    break;
                case 2:
                    this.txtresultado.Text = "Naciste un Lunes";
                    break;
                case 3:
                    this.txtresultado.Text = "Naciste un Martes";
                    break;
                case 4:
                    this.txtresultado.Text = "Naciste un Miércoles";
                    break;
                case 5:
                    this.txtresultado.Text = "Naciste un Jueves";
                    break;
                case 6:
                    this.txtresultado.Text = "Naciste un Viernes";
                    break;
                case 0:
                    this.txtresultado.Text = "Naciste un Sábado";
                    break;

            }



        }
    }
}
