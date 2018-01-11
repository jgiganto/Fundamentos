using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases

{
    public class Personaa
    {

        //propidedades autoimplementadas de direccion
        public Direccion DireccionVacaciones { get; set; }
        public Direccion DireccionParticular { get; set; }
        //constructor, se crea con el nombre de la clase
        public Personaa()
        {
            this.Sexo = SexoPersona.Mujer;
            this.Nombre = "sin asignar";
            this.Apellido = "sin asignar";
            //todas las personas tendran una direccion particular
            //this.DireccionParticular = new Direccion();
        }
        //un constructor es un metodo, el primer metodo de la clase, como cualquier metodo
        //tiene sobrecarga
        public Personaa(String nombre, String apellidos)
        {
            this.Nombre = nombre;
            this.Apellido = apellidos;
            this.DireccionParticular = new Direccion
            {
                Calle = "tajamar",
                Ciudad = "Madrid",
                CodigoPostal = 22222
            };
        }

        



        /*una propiedad indizada o default es una propiedad que no se 
         escribe, se accede desde el objeto y se pasa un indice
         String texto = "abcd";
         texto[0];    
             */
        //ueremos que una persona tenga capacidad para incluir 3 descripciones 
        //posibles.. 
        //Persona persona = new Persona();
        //persona.Descripccion1 = "ojos castaños";
        //persona.Descripccion2 = "castaño";
        //OTRA FORMA , MAS CORRECTA
        //persona[0] = "Descripccion 1";
        //persona[1] = "Descripccion 2";
        //persona[2] = "Descripccion 3";
        //  ....etc
        //LA SINTAXIS PARA UNA PROPIEDAD INDIZADA SE CREA CON this
        //SOLAMENTE PUEDE HABER UNA PROPIEDAD INDIZADA POR CLASE
        //NECESITAMOS UN OBJETO CONJUNTO (ARRAY O LIST)
        //PARA MANEJAR LA PROPIEDAD
        //CAMPO ARRAY DE TRES STRING
        //private String[] Descripcciones = new String[3];
        ////DECLARAMOS LA PROPIEDAD INDIZADA PARA EL USUARIO
        //public String this[int indice]
        //{
        //    get {
        //        return Descripcciones[indice];
        //    }
        //    set {
        //        //persona[0]
        //        //value
        //        Descripcciones[indice] = value;
        //    }
        //}




        #region "Propiedades extendidas"


        private string _Apellido;
        public String Apellido
        {
            get
            {
                return this._Apellido;
            }
            set
            {
                this._Apellido = value;
            }
        }

        private string _Nombre;
        public string Nombre
        {
            get
            {
                return this._Nombre;
            }
            set
            {
                this._Nombre = value;
            }
        }
        private string[] _Descripccion;
        public string[] Descripccion
        {
            get { return this._Descripccion; }
            set { this._Descripccion = value; }
        }
        private string _DireccionTrabajo;
        public string DireccionTrabajo
        {
            get { return this._DireccionTrabajo; }
            set { this._DireccionTrabajo = value; }
        }
        private string DomicilioParticular;
        public string _DomicilioParticular
        {
            get { return this._DomicilioParticular; }
            set { this._DomicilioParticular = value; }
        }
        private string _DomicilioVacaciones;
        public string DomicilioVacaciones
        {
            get { return this._DomicilioVacaciones; }
            set { this._DomicilioVacaciones = value; }
        }
        
        #endregion

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get
            {
                return this._FechaNacimiento;
            }
            set
            {
                if (value >= DateTime.Now.Date)
                {
                    throw new Exception("La fecha no es válida");
                }
                else
                {
                    this._FechaNacimiento = value;
                }
            }
        }

        //queremos crear un metodo que nos devuelva el nombre completo de una persona
        public String GetNombreCompleto()
        {
            return this._Nombre + " " + this._Apellido;
        }
        /*QUEREMOS OTRO METODO QUE NOS DEVUELVA EL NOMBRE EN FORMATO (Apellido Nombre)*/

            public String GetNombreCompletoFormal()
        {
            return this._Apellido + " " + this._Nombre;
        }
        /*OTRO METODO QUE NOS DEVUELVA EL NOMBRE COMPLETO, JUNTO A LA EDAD*/
        public String GetNombreCompletoEdad()
        {
            return "..";
        }
        public int RecuperarEdad()
        {
            int edad = DateTime.Now.Year - this._FechaNacimiento.Year;
            return edad;
        }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - this.FechaNacimiento.Year;
            }
        }
        public enum SexoPersona
        {
            Hombre = 0,
            Mujer = 1
        }

        private SexoPersona _Sexo;
        public SexoPersona Sexo
        {
            get
            {
                return this._Sexo;
            }
            set
            {
                if (value != SexoPersona.Hombre && value != SexoPersona.Mujer)
                {
                    throw new Exception("Valor no válido para el sexo");
                }
                else
                {
                    this._Sexo = value;
                }
            }
        }

        public enum PersonaEstadoCivil
        {
            Soltero = 0,
            Casado = 1,
            Viudo = 2,
            Divorciado = 3
        }
        private PersonaEstadoCivil _EstadoCivil;
        public PersonaEstadoCivil EstadoCivil
        {
            get
            {
                return this._EstadoCivil;
            }
            set
            {
                if (value != PersonaEstadoCivil.Soltero && value != PersonaEstadoCivil.Viudo
                && value != PersonaEstadoCivil.Casado && value != PersonaEstadoCivil.Divorciado)
                {
                    throw new Exception("Valor no válido para el estado civil");
                }
                else
                {
                    this._EstadoCivil = value;
                }
            }
        }

        public enum Paises
        {
            España = 0, Ingles = 1, Alemania = 2, Francia = 3, Holanda = 4, Argentina = 5
        }

        private Paises _Nacionalidad;
        public Paises Nacionalidad
        {
            get
            {
                return this._Nacionalidad;
            }
            set
            {
                this._Nacionalidad = value;
            }
        }
        public string DescripcionEstado
        {
            get
            {
                string resultado = "";
                if (this._Sexo == SexoPersona.Mujer)
                {
                    switch (this._EstadoCivil)
                    {
                        case PersonaEstadoCivil.Casado:
                            resultado = "Mujer casada";
                            break;
                        case PersonaEstadoCivil.Soltero:
                            resultado = "Mujer soltera";
                            break;
                        case PersonaEstadoCivil.Viudo:
                            resultado = "Mujer viuda";
                            break;
                        case PersonaEstadoCivil.Divorciado:
                            resultado = "Mujer Divorciada";
                            break;
                    }
                }
                else if (this._Sexo == SexoPersona.Hombre)
                {
                    switch (this._EstadoCivil)
                    {
                        case PersonaEstadoCivil.Casado:
                            resultado = "Hombre casado";
                            break;
                        case PersonaEstadoCivil.Soltero:
                            resultado = "Hombre soltero";
                            break;
                        case PersonaEstadoCivil.Viudo:
                            resultado = "Hombre viudo";
                            break;
                        case PersonaEstadoCivil.Divorciado:
                            resultado = "Hombre divorciado";
                            break;
                    }
                }
                return resultado;
            }
        }

        /*Los parámetros opcionales son valores que se envían a un método,
         * pero que no son obligatorios, el programador puede decidir
         * que elementos se envían y cuales se omiten. 
         * Si un método recibe dos parámetros opcionales, el programador
         * puede enviar un parámetro, dos o ninguno.
            Método con parametros opcionales:             */
        public void MetodoParametrosOpcionales(int numero, int parametroopcional = 20)
        {
        }


        //        Propiedades con valor por defecto o indizadas
        //          Listado para 10 descripciones

        private string[] _Descripcion = new string[10];
        public string this[int indice]
        {
            get
            {
                return this._Descripcion[indice];
            }
            set
            {
                if (indice < 0 || indice > _Descripcion.GetUpperBound(0))
                {
                    throw new IndexOutOfRangeException("Sobrepasado el limite de descripcion en persona");
                }
                else
                {
                    this._Descripcion[indice] = value;
                }
            }
        }

        #region "Metodos sobrecargados"
        //Métodos sobrecargados(Polimorfismo)
        public string NombreCompleto()
        {
            return this._Nombre + " " + this._Apellido;
        }


        public string NombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this._Apellido + " " + this._Nombre;
            }
            else
            {
                return this.NombreCompleto();
            }
        }

        public enum FormatoNombre
        {
            Mayusculas = 0,
            Minusculas = 1,
            Iniciales = 2
        }


        public string NombreCompleto(FormatoNombre formato)
        {
            if (formato == FormatoNombre.Mayusculas)
            {
                return this.NombreCompleto().ToUpper();
            }
            else if (formato == FormatoNombre.Minusculas)
            {
                return this.NombreCompleto().ToLower();
            }
            else if (formato == FormatoNombre.Iniciales)
            {
                return this.ConvertirIniciales(this.NombreCompleto());
            }
            else
            {
                return "Formato seleccionado incorrecto";
            }
        }



        private string ConvertirIniciales(string cadena)
        {
            int i;
            string letra;
            cadena = cadena.ToLower();
            letra = cadena[0].ToString();
            letra = letra.ToUpper();
            cadena = cadena.Remove(0, 1);
            cadena = cadena.Insert(0, letra);
            for (i = 1; i < cadena.Length; i++)
            {
                letra = cadena[i].ToString();
                if (char.IsWhiteSpace(cadena[i - 1]))
                {
                    letra = letra.ToUpper();
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, letra);
                }
            }
            return cadena;
        }



        public string NombreCompleto(FormatoNombre formato, bool orden)
        {
            if (formato == FormatoNombre.Mayusculas)
            {
                return this.NombreCompleto(orden).ToUpper();
            }
            else if (formato == FormatoNombre.Minusculas)
            {
                return this.NombreCompleto(orden).ToLower();
            }
            else if (formato == FormatoNombre.Iniciales)
            {
                return this.ConvertirIniciales(this.NombreCompleto(orden));
            }
            else
            {
                return "Formato seleccionado incorrecto";
            }
        }

#endregion

        public Personaa(string nom, string ape, Personaa.PersonaEstadoCivil estado)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Estado = estado;
        }
        public int SalarioMinimo { get; set; }
        public double Retencion { get; set; }
      
        public Personaa.PersonaEstadoCivil Estado { get; set; }

    }

}
