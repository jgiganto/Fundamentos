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
    public partial class Form20TiendadeProductos : Form
    {
        public Form20TiendadeProductos()
        {
            InitializeComponent();
        }

        bool primero = true; int indice = 0; string textoitem="";
        bool recomponer = false;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (recomponer == true)
            {
                this.lstproductostienda.Items[indice] = textoitem;
            }
            int contadordiferentes=0;
            string producto = this.txtentradaproducto.Text;
            //for (int i = 0; i < this.lstproductostienda.Items.Count; i++) 
            for (int i = this.lstproductostienda.Items.Count - 1; i >= 0 ; i--)
            {

                if (primero == true)
                {
                    this.lstproductostienda.Items.Add(producto);
                    primero = false; 
                }
                else if (this.lstproductostienda.Items[i].ToString() == producto)
                {
                      indice = i ;
                }
                else if (this.lstproductostienda.Items[i].ToString() != producto)
                {
                      contadordiferentes++;
                        
                }
            }
            if (contadordiferentes == 0)
            {
                this.lstproductostienda.Items.Add(producto);
            }
            else if (contadordiferentes != 0)
            {
                
                    textoitem = this.lstproductostienda.Items[indice].ToString();
                    textoitem = textoitem + " repe";
                this.lstproductostienda.Items[indice] = textoitem;
                this.lstproductostienda.Items.RemoveAt(indice + 1);
                    recomponer = true;
               
            }
            

        }



        

        private void btnborrartienda_Click(object sender, EventArgs e)
        {
            this.lstproductostienda.Items.Clear();
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            for (int i =this.lstproductostienda.SelectedIndices.Count -1;i>=0;i--)
            {
                int pos = this.lstproductostienda.SelectedIndices[i];
                this.lstproductostienda.Items.RemoveAt(pos);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}
