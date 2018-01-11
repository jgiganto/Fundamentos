using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
   public class Año
    {
        public List<Mes> Meses { get ; set; } //conjunto de meses;propiedad
        public String Nombre { get; set; } //nombre del año
        
        public Año()
        {//creamos la coleccion de meses
            this.Meses = new List<Mes>();
        }
        public Año(bool automatico)
        {
            this.Meses = new List<Mes>();
            this.GenerarMeses();
        }

        public int GetMinima() //metodo
        {
            //recorrer todos los meses
            int minima = this.Meses[0].TemperaturaMinima;
            foreach(Mes m in this.Meses)
            {
                minima = Math.Min(minima, m.TemperaturaMinima);
            }
            return minima;
        }
        public int GetMaxima() //metodo
        {
            //recorrer todos los meses
            int maxima = this.Meses[0].TemperaturaMinima;
            foreach (Mes m in this.Meses)
            {
                maxima = Math.Max(maxima, m.TemperaturaMaxima);
            }
            return maxima;
        }

        public double GetTemperaturaMediaAnual()
        {
            double suma = 0;
            foreach(Mes m in this.Meses)
            {
                suma += m.GetMedia();
            }
            double media = suma / this.Meses.Count;
            return media;
        }

        //metodo para generar los meses de forma dinamica
        private void GenerarMeses()
        {
            Random rnd = new Random();
            DateTime fecha = DateTime.Parse("01/01/2000");
            for (int i = 1;i<=12;i++)
            {
                Mes mes = new Mes();
                mes.Nombre = fecha.ToString("MMMM");
                mes.TemperaturaMaxima = rnd.Next(1, 40);
                mes.TemperaturaMinima = rnd.Next(-15, 0);
                this.Meses.Add(mes);
                fecha = fecha.AddMonths(1);
            }
        }

    }
}
