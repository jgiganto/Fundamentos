using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ProyectoClases
{
    public class Coche
    {

        /*vamos a sobreescribir el metodo de la clase object
         para adaptarlo a nuestra clase 
         para hacerlo se usa el metodo---> override*/
        public override string ToString()
        {
            return this.Marca + " " + this.Modelo + " (metodo sobreescrito)";
        }



        //vamos a crear un constructor para que 
        // la velocidad maxima de un coche sea 200
        public Coche()//constructor
        {
            Debug.Write("Constructor sin parámetros del COCHE");
            this.VelocidadMaxima = 200;
            this.VelocidadActual = 0;
        }
        public Coche(String marca, String modelo)
        {
            Debug.Write("Constructor con parámetros: COCHE ");
            this.Marca = marca;
            this.Modelo = modelo;

        }
        public int GetVelocidadMaxima()
        {
            return this.VelocidadMaxima;
        }
        protected int VelocidadMaxima { get; set; } 
        public int VelocidadActual { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        /*con virtual le indico que acelerar podra ser sobreescrito , override, en las clases que hereden(deportivo)*/
        public virtual void Acelerar()//metodo
        {
            //incrementamos la velocidad de 10 en 10
            this.VelocidadActual += 20;            
        }
        public void Frenar()
        {
            this.VelocidadActual -= 20;
        }
    }
}
