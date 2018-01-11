using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado:Personaa
    {
        #region "CONTRUCTORES  EMPLEADO"

        public Empleado()
        {
            //Iniciamos el salario Minimo y la retención para un empleado
            this.SalarioMinimo = 750;
            this.Retencion = 0.15;
        }


        //Método que hace una llamada al constructor de la clase
        //persona para iniciar los valores
     public Empleado(String nom, String ape, Personaa.PersonaEstadoCivil estado, int sueldo)
        : base(nom, ape, estado)
        {   
            this.SalarioMinimo = 750;
            this.Retencion = 0.15;
            this.Salario = sueldo;
        }

       

        #endregion

        #region "PROPIEDADES DE LA CLASE EMPLEADO"

        private int _Salario;
        public int Salario
        {
            get
            {
                return this._Salario;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("El salario debe ser positivo");
                }
                else
                {
                    this._Salario = value;
                }
            }
        }


        public DateTime FechaVacaciones { get; set; }

        private DateTime _FechaAltaEmpresa;
        public DateTime FechaAltaEmpresa
        {
            get
            {
                return this._FechaAltaEmpresa;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("La fecha de alta no puede ser superior al dia actual");
                }
                else
                {
                    this._FechaAltaEmpresa = value;
                }
            }
        }
#endregion

    }
}
