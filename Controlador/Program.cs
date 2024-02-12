using REPASO07022024.Dtos;
using REPASO07022024.Servicios;

namespace REPASO07022024
{
    class program
    {
        public static void Main(string[] args)
        {
            List<ActividadDto> actividad = new List<ActividadDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            int opcionMenu;
            bool cerrarMenu=false;
            do
            {
                opcionMenu = mi.menu();
                switch(opcionMenu)
                {
                    case 0 : cerrarMenu = true; break;

                    case 1 :op.darAltaActividad(actividad);break;

                    case 2:
                        if (actividad.Count > 0)
                        {
                            foreach (ActividadDto item in actividad)
                            {
                                Console.WriteLine(item.ToString());

                            }       op.borrarActtividad(actividad);break;
                        }
                        else
                        {
                            Console.WriteLine("Imposible poder utilizar esta funcion porque no hay actividad disponible");
                            break;
                        }
                       
                        case 3 : op.mostrarLista(actividad);break;

                    default: break;
                }

            } while (!cerrarMenu);
        }
    }
}
