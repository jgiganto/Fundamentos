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
    public partial class Form02PosicionObjetos : Form
    {
        public Form02PosicionObjetos()
        {
            InitializeComponent();
        }

        private void btncambiarposicion_Click(object sender, EventArgs e)
        {
            //QUEREMOS CAMBIAR LA POSISION DEL LABEL (lblobjeto)
            //PARA CAMBIAR LA POSICION DEL OBJETO TENEMOS LA PROPIEDAD Location
            int x = int.Parse(txtposicionx.Text);
            int y = int.Parse(txtposiciony.Text);
            //CAMBIAMOS LAS COORDENADAS DEL OBJETO LABEL
            lblobjeto.Location = new Point(x,y);
            //QUIERO ESCRIBIR EN EL LABEL LAS COODENADAS
            //lblobjeto.Text = x.ToString();
            //otra forma-- 
            lblobjeto.Text = "Posición X: " + x + "\n" + "Posición Y: " +y; 
            // \n es salto de linea 
            //al concatenarlo no es necesario poner tostring
            //ENVIAMOS EL FOCO A LA CAJA X Y SELECCIONAMOS SU TEXTO
            txtposicionx.Focus();
            txtposicionx.SelectAll();

        }

        private void lblobjeto_Click(object sender, EventArgs e)
        {

        }

        private void btnarriba_Click(object sender, EventArgs e)
        {
            //vamos a mover hacia arriba
            //NEGATIVO (HAY QUE RESTAR)
            //RECUPERAMOS LA POSICION DEL ELEMENTO ACTUAL
            int posy = lblobjeto.Location.Y;
            //RESTAMOS UN NUMERO
            posy = posy - 10;
            //posy--;
            //posy -= 1;
            //posy *= 10;                        ALGUNA SINTAXIS
            //String texto = "aaa";
            //texto += "bbb"; aaabbb

            //ESTABLECEMOS LA POS DEL LABEL
            lblobjeto.Location =
                new Point(lblobjeto.Location.X, posy);
            //QUEREMOS CAMBIAR EL COLOR DE FONDO DEL FORMULARIO
            //CUANDO ESTAMOS EN UNA CLASE , PARA HACER REFERENCIA
            // AL OBJETO QUE REPRESENTA LA CLASE(donde estoy escribiendo) SE UTILIZA this(Form02PosicionObjetos). 

            this.BackColor = Color.FromArgb(80, 150, 15);

            

        }

        private void btnabajo_Click(object sender, EventArgs e)
        {
            int posy = lblobjeto.Location.Y;
            posy += 15;
            this.lblobjeto.Location =
                new Point(this.lblobjeto.Location.X, posy);

            this.BackColor = Color.FromArgb(180, 150, 15);

        }

        private void btnarriba_MouseMove(object sender, MouseEventArgs e)
        {
            int posy = lblobjeto.Location.Y;
            posy += 1;
            this.lblobjeto.Location =
                new Point(this.lblobjeto.Location.X, posy);

            this.BackColor = Color.FromArgb(180, 150, 15);
        }
    }
}
