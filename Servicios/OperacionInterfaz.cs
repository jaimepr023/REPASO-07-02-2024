using REPASO07022024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.Servicios
{
    internal interface OperacionInterfaz
    {
        public void darAltaActividad(List<ActividadDto> lista);

        public void borrarActtividad(List<ActividadDto> lista);

        public void mostrarLista(List<ActividadDto> lista);
    }
}
