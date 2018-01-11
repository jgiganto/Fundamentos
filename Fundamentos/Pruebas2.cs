using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fundamentos
{
    public partial class Pruebas2 : Form
    {
        public Pruebas2()
        {
            InitializeComponent();
        }
        int num = 0; int num2 = 0; int num3 = 0; int num4 = 0; int num5 = 0; int num6 = 0;
        int num7 = 0; int num8 = 0; int num9 = 0;
        bool primer = false; bool encontrado=false;
        bool seguir = true; int click = 0; int encontrados;
        int media=0; int total=0;
        private void btnrand_Click(object sender, EventArgs e)            
        {
            click++;
            Stopwatch krono = new Stopwatch();
            krono.Start();

            this.txtsalida.Text = "";
            Random ran = new Random();
            int j = 0; int vueltas=0; 
            String encuentra;
            encuentra = this.txttexto.Text;
            StringBuilder texto = new StringBuilder();
            char caracter; char caracter5; char caracter9;
            char caracter2; char caracter6;
            char caracter3; char caracter7;
            char caracter4; char caracter8;

            do
            {
            
                    j++;
                    vueltas++;

                    caracter = (char)num;
                    caracter2 = (char)num2;
                    caracter3 = (char)num3;
                    //caracter4 = (char)num4;
                    //caracter5 = (char)num5;
                    //caracter6 = (char)num6;
                    //caracter7 = (char)num7;
                    //caracter8 = (char)num8;
                    //caracter9 = (char)num9;

                    num = ran.Next(65, 90);
                    num2 = ran.Next(65, 90);
                    num3 = ran.Next(65, 90);
                    //num4 = ran.Next(65, 75);
                    //num5 = ran.Next(65, 68);
                    //num6 = ran.Next(65, 68);
                    //num7 = ran.Next(65, 68);
                    //num8 = ran.Next(65, 68);
                    //num9 = ran.Next(65, 68);


                    texto.Insert(0, caracter);
                    texto.Insert(1, caracter2);
                    texto.Insert(2, caracter3);
                    /*texto.Insert(3, caracter4)*/;
                    //texto.Insert(4, caracter5);
                    //texto.Insert(5, caracter6);
                    //texto.Insert(6, caracter7);
                    //texto.Insert(7, caracter8);
                    //texto.Insert(8, caracter9);

                    this.txtsalida.Text += texto;

                    if ((j %= 1) == 0)
                    {
                        if (texto.ToString().Equals(encuentra) == true)
                        {
                            encontrados++;
                            this.txtsalida.Text += "-encontrado\n";
                            encontrado = true; seguir = false;
                        }
                    }
                    if ((texto.Length == 2 || j == 0) && primer == true)
                    {
                        if (encontrado == false)
                        {
                            //this.txtsalida.Text += "\n";


                        }
                        texto.Clear();
                    }
                    primer = true;
                    encontrado = false;

                    this.lbvueltas.Text = vueltas.ToString();
               
                
            }
            while (seguir==true);
            seguir = true;
            krono.Stop();
            this.lblencontrados.Text = encontrados.ToString();
            this.lbltiempo.Text = krono.ElapsedMilliseconds+" Milisegundos";
            total = total + vueltas; media = total / click;
            this.lbmedia.Text = media.ToString();
        }

        private void Pruebas2_Load(object sender, EventArgs e)
        {

        }
    }
}
