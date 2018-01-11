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
    public partial class Form08Checkbox : Form
    {
        public Form08Checkbox()
        {
            InitializeComponent(); // esto inicializa los componentes del formulario. 
            //esto es el constructor de un objeto. me dice como quiero crear el objeto
                                    /* EN EL CONSTRUCTOR INICIAREMOS LA CLASE CON 
                                     * TODOS LOS VALORES INICIALES QUE DESEEMOS PARA LA CLASE (form)
                                     *              */
            DateTime fecha = DateTime.Now;
            this.txtfechaactual.Text = fecha.ToString();

        }

        private void btnincrementar_Click(object sender, EventArgs e)
        {
            //VAMOS A INCREMENTAR LA FECHA DEPENDIENDO DEL VALOR DE LOS RADIOS
            //RECUPERAMOS EL INCREMENTO DE LA CAJA
            int incremento = int.Parse(this.txtincrementar.Text);
            //tb recuperamos la fecha
            DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
            //PREGUNTAMOS POR EL ESTADO DE LOS RADIOS
            if (this.rbdias.Checked==true)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rbmeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }else 
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtfechafinal.Text = fecha.ToString();
            
            
            
            
            
            //ALGO DE TEORIA------------------
            //DateTime fecha = DateTime.Now;    NUTABILIDAD, concepto. 
            //fecha.AddDays(2);
            //this.txtfechafinal.Text = fecha.ToString(); mutabilidad, esta linea no cambia el objeto
            //devuelve otro igual . habria que igualar para cambiarlo. 
            //DateTime fecha = DateTime.Now;
            //fecha = fecha.AddDays(2); ------------  esto si que lo cambia
            //this.txtfechafinal.Text = fecha.ToString();
        }

        private void Form08Checkbox_Load(object sender, EventArgs e)
        {

        }

        private void chkformato_CheckedChanged(object sender, EventArgs e)
        {
            /*DENTRO DE DATETIME EXISTEN VARIOS METODOS DE CONVERSION DE FECHAS 
             TODOS ELLOS DEPENDEN DE LA CULTURA DE LA APLICACION
             .toShortdateString() ----> dd/mm/yyyy
             .ToLongDateString()  ----> jueves 22 de noviembre...
             .ToShortTimeString() ->  09:35
             .ToLongTimeString()---> 09:35:55 con sg. 
             */
            /*
            CAPTURAMOS LA FECHA DE LA CAJA DE TEXTO 
            */
            DateTime fecha = DateTime.Parse(this.txtfechaactual.Text);
            //PREGUNTAMOS POR EL TEXTBOX
            if(this.chkformato.Checked==true)
            {
                //formato largo
                this.txtfechaactual.Text =
                    fecha.ToLongDateString();
            }
            else
            {
                this.txtfechaactual.Text =
                    fecha.ToShortDateString();
            }

        }
    }
}
