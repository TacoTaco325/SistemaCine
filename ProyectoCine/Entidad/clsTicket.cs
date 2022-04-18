using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsTicket
    {
        public static int idTicket { get; set; }
        public static string fecha { get; set; }
        public static float Costo { get; set; }
        public static string Hora { get; set; }
        public static string cliente { get; set; }
        public static string pago { get; set; }
        public static int idEmp { get; set; }
        public static float Efectivo { get; set; }
        public static float devolucion { get; set; }
        public static int idfun { get; set; }
    }
}
