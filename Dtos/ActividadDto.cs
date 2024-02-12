using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.Dtos
{
    internal class ActividadDto
    {
        string nombreActividad = "aaaaa";
        DateTime fechaInicio;
        DateTime fechaFinal= DateTime.Now;
        double diferenciaMin = 0;

        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public double DiferenciaMin { get => diferenciaMin; set => diferenciaMin = value; }

        public ActividadDto(string nombreActividad, DateTime fechaInicio)
        {
            this.nombreActividad = nombreActividad;
            this.fechaInicio = fechaInicio;
            this.diferenciaMin = tranformarFecha(fechaInicio, this.fechaFinal);
        }

        public ActividadDto()
        {

        }

        private double tranformarFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
          

            TimeSpan difFecha = fechaFinal - fechaInicio ;
           
            double minutos = difFecha.TotalMinutes;
           
            return minutos;
        }

      

        override
            public string ToString()
        {
            string mostrar =
            "nombre--> " + this.nombreActividad + "\n" +
            "Tiempo min --> " + this.diferenciaMin + " minutos";
            return mostrar;
        }
    }
}
