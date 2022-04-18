using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsFuncion
    {
        public int idfun { get; set; }
        public int Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int idsala { get; set; }
        public int idpelicula { get; set; }
        public bool estado { get; set; }
        public int operacion { get; set; }
    }
}
