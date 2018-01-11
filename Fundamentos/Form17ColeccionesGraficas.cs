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
    public partial class Form17ColeccionesGraficas : Form
    {
        public Form17ColeccionesGraficas()
        {
            InitializeComponent();
        }

        private void Form17ColeccionesGraficas_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            String dato = this.txtdato.Text;
            //queremos añadir el dato a la coleccion del listbox
            this.lstelementos.Items.Add(dato);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.lstelementos.Items.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstelementos.SelectedIndex;
            //this.lstelementos.Items.RemoveAt(indice);
            /*vamos a eliminar todos los elementos seleccionados
             tenemos una coleccion (selectedindices) que nos devuelve los indices de los 
             elementos seleccionados*/
           // for (int i = 0; i < this.lstelementos.SelectedIndices.Count; i++) //hay que borrar del ultimo al primero, para que no afecte el reposicionamiento
           for (int i = this.lstelementos.SelectedIndices.Count-1; i>=0; i--)
            {
                int pos =
                    this.lstelementos.SelectedIndices[i];// la posicion del que estamos recorriendo
                this.lstelementos.Items.RemoveAt(pos);
            }



        }

        private void lstelementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblindice.Text = this.lstelementos.SelectedIndex.ToString();

        }
    }
}
