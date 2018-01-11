using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes //public, lo hago visible
    {
        public String Nombre { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }
        public double GetMedia()
        {
            double media = (this.TemperaturaMaxima + this.TemperaturaMinima) / 2;
            return media;
        }
        public override string ToString() //lo adapto
        {

            return this.Nombre
                + " Max: "
                + this.TemperaturaMaxima
                + " Min: "
                + this.TemperaturaMinima;

        }
    }
}
