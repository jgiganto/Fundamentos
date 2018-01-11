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
    public partial class Form09ValidarEmail : Form
    {
        public Form09ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            String email = this.txtemail.Text;
            if (email.Contains("@") == false)
            {
                this.lblrespuesta.Text =
                    "No existe @ en el Email";
            }
            else if (email.StartsWith("@") == true
               || email.EndsWith("@") == true)
            {
                this.lblrespuesta.Text =
                    "@ al inicio o al final del Email";
            }
            else if (email.IndexOf("@") !=
               email.LastIndexOf("@"))
            {
                this.lblrespuesta.Text =
                    "Existe más de una @";
                int ultimaarroba =
    email.LastIndexOf("@");
                this.txtemail.Focus();
                this.txtemail.Select(ultimaarroba, 1);
            }
            else if (email.IndexOf(".") == -1)
            {
                this.lblrespuesta.Text =
                    "No existe punto en el Email";
            }
            else if (email.LastIndexOf(".")
               < email.IndexOf("@"))
            {
                this.lblrespuesta.Text =
                    "Debe haber un punto después de @";
            }
            else
            {
                int ultimopunto = email.LastIndexOf(".");
                String dominio =
                    email.Substring(ultimopunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblrespuesta.Text =
                        "Email Perfecto";
                }
                else
                {
                    this.lblrespuesta.Text =
                        "El dominio debe tener de 2-4 caracteres";
                }
            }







        }

        private void lblrespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
