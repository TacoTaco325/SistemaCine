using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsPelicula
    {
        public int idpel { get; set; }
        public string nombre { get; set; }
        public int genero { get; set; }
        public int clasificacion { get; set; }
        public DateTime estreno { get; set; }
        public Byte ima { get; set; }
        public bool estado { get; set; }
        public int operacion { get; set; }
    }
}
