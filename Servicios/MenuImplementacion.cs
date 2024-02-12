using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            int opcion;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Opcion 0. Cerrar menu.");
            Console.WriteLine("Opcion 1. Alta de una actividad.");
            Console.WriteLine("Opcion 2. Eliminar actividad.");
            Console.WriteLine("Opcion 3. Mostrar Lista");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Elija una opcion");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
