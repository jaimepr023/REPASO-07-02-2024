using REPASO07022024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
      

        public void borrarActtividad(List<ActividadDto> lista)
        {
            Console.WriteLine("¿Que actividad quieres ver?");
            string actividadb = Console.ReadLine();
            foreach (ActividadDto item in lista)
            {

                if (item.NombreActividad.Equals(actividadb))
                {
                    lista.Remove(item);
                }
                break;
            }
        }


        private ActividadDto crearActividad()
        {
          

            Console.WriteLine("¿Cual es el nombre de su actividad?");
            string NombreActividad = Console.ReadLine();
            Console.WriteLine("¿Cuando se inicio la actividad?(ponle el siguiente formato g/G [dia/mes/año_largo horas:min:segundos])");
            DateTime FechaInicio = DateTime.Parse(Console.ReadLine());
            
            ActividadDto actividad = new ActividadDto(NombreActividad, FechaInicio);
            return actividad;
        }
        public void darAltaActividad(List<ActividadDto> lista)
        {
            ActividadDto actividadNueva = crearActividad();
            lista.Add(actividadNueva);
        }


        public void mostrarLista(List<ActividadDto> lista)
        {
            if(lista.Count > 0)
            {
                Console.WriteLine("¿Que actividad quieres ver?");
                string actividad = Console.ReadLine();
                foreach(ActividadDto item in lista)
                {
                    if (item.NombreActividad.Equals(actividad))
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }else { Console.WriteLine("Debe de ingresar algun elemento para poder untilizar esta funcion"); }
        }
    }
}
