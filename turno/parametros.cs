using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turno
{
    internal class parametros
    {

        private static string id;
        private static Boolean accion;
      

        public static string Id { get => id; set => id = value; }
        public static bool Accion { get => accion; set => accion = value; }
       
    }
}
