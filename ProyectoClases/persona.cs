using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ProyectoClases
{
    public class Persona
    {
        //propiedades con enumeracion
        // lo primero sera crear la enumeracion
        public enum SexoPersona
        {
            HOMBRE = 0,MUJER = 1
        }
        //CAMPO PARA MANEJAR LA PROPIEDAD ENUMERADA
        private SexoPersona _Sexo;
        //propiedad enumerada
        public SexoPersona Sexo
        {
            get { return _Sexo; }
            set {
                /*enlas propiedades enumeradas deberia controlar que me esten
                 enviando valores correctos*/
                 if(value==SexoPersona.HOMBRE||value==SexoPersona.MUJER)
                {
                    //correcto
                }
                else
                {
                    throw new Exception("Te has pasado de listo");
                }
                _Sexo = value; }
        }





        #region propiedades de la clase
        //region solo sirve para organizar el codigo
        //public int Edad;
        /*DEBEMOS CREAR UN CAMPO PARA MANEJAR LA PROPIEDAD 
         DENTRO DE LA MISMA CLASE , DICHO CAMPO DEBE SER INACCESIBLE
         PRIVADO*/
        private int _Edad;
        private string _Nombre;
        


        public int Edad
        {
          
            get
            { //cuando intenta recuperar un valor
                //aqui debemos devolver un valor
                //return Edad;blucle infinito
                return _Edad;
               // return 50;
            }
            set { // cuando establecen un valor
                // value , significa el contenido que estan asignando
                //Edad = value; bucle infinito
                //PODEMOS PREGUNTAR POR EL VALOR ASIGNADO Y REALIZAR ACCIONES
                if(value<0)
                {
                    //la edad que han metido es negativa
                    //error silencioso(asignar otro valor)
                    //value = 0;
                    //tb puedo lanzar una excepcion con THROW
                    throw new Exception("  La edad no puede ser negativa");

                   


                }

                _Edad = value;
                //value = 22;
                //Edad = 22; bucle infinito
                // no se maneja la propiedad dentro de la propiedad
               
                }
        }
        /*queremos una propiedad que devuelva un valor
         cualquiera de la persona, pero que no pueda cambiar*/
         //propiedad de solo lectura
         public String MensajePersona
        {
            get
            {
                return "  Hoy es viernes ";
            }
        }

        public string Nombre
        {
            get {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }

        }
        #endregion

     
    }


}
