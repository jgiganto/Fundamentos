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
    public partial class Form21EventosObjeto : Form
    {
        public Form21EventosObjeto()
        {
            InitializeComponent();
        }

        private void lblmouse_Click(object sender, EventArgs e)
        {

        }

        private void txtnumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblmouse.Text = "X: " + e.X + "Y: " + e.Y;
        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
            /*existe una enumeracion que nos devuelve el codigo ascii de cualquier
             tecla (keys)*/
             //Convert.ToChar(ASCII);

        {
            if (char.IsDigit(e.KeyChar) == false &&
                e.KeyChar !=Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtletras_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtletras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false &&
               e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
