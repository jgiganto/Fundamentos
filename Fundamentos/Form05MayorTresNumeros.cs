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
    public partial class Form05MayorTresNumeros : Form
    {
        public Form05MayorTresNumeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0; int b = 0; int c = 0;int menor = 0; int intermedio = 0;
            
            int mayor = 0;
            //String may, men, med = "";
            a = int.Parse(this.txtnum1.Text);
            b = int.Parse(this.txtnum2.Text);
            c = int.Parse(this.txtnum3.Text);
            if (a > b && b > c) { mayor = a; intermedio = b; menor = c; }
            if (b > a && a > c) { mayor = b; intermedio = a; menor = c; }
            if (c > a && a > b) { mayor = c; intermedio = a; menor = b; }
            if (a > c && c > b) { mayor = a; intermedio = c; menor = b; }
            if (b > c && c > a) { mayor = b; intermedio = c; menor = a; }
            if (c > b && b > a) { mayor = c; intermedio = b; menor = a; }

            this.txtmayor.Text = mayor.ToString();
            this.txtmenor.Text = menor.ToString();
            this.txtintermedio.Text = intermedio.ToString();

        }
    }
}
