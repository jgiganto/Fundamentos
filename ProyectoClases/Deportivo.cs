using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ProyectoClases
{
    //heredamos de un coche, para que tenga las mismas caracteristicas(Deportivo:Coche )
    public class Deportivo:Coche 
    {
        public Deportivo() //por defecto siempre lee el que no tiene parametros
        {
            Debug.Write("Sin parametros Deportivo");
            this.VelocidadMaxima = 300;
        }
        /*creamos un constructor con dos parametros
         o lo que queramos para el deportivo (los constructores no se heredan)*/

        //por defecto siempre lee el que no tiene parametros
        /*cuando queremos que un constructor lea otro constructor de la clase base 
     debemos hacerlo a continuacion de la firma con :base() */
        public Deportivo(String marca, String modelo):base(marca,modelo)
        {
            Debug.WriteLine("Con parametros de deportivo");
            this.VelocidadMaxima = 300;
            //this.Marca = marca;
            //this.Modelo = modelo;
        } 
        
        public override void Acelerar()
        {
            //queremos que un deportivo corra
            //siempre 20 mas que un coche
            /*los metodos sobreescritos se sustiuyen 
             lo que quiere decir que no realizan 
             nada del codigo padre(base)
             si deseamos que primero realice el codigo del padre y posteriormente el nuestro 
             debemos hacer la llamada explicita al metodo base*/

            //this.Acelerar();//bucle infinito
            base.Acelerar(); // primero acelera a 10
           
            this.VelocidadActual += 20; // nosotros le sumamos 20
        }
        //el deportivo podra acelerar usando turbo
        public void Acelerar(bool turbo)
        {
            this.VelocidadActual += 80;
        }
    }
}
