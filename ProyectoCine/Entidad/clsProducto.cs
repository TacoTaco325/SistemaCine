using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public int idcat { get; set; }
        public double precio { get; set; }
        public bool estado { get; set; }
        public int operacion { get; set; }
    }
}
