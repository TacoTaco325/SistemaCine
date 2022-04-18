using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class clsEmpMant
    {
        public int idEmp { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public int idCargo { get; set; }
        public bool estado { get; set; }
        public int edad { get; set; }
        public int operacion { get; set; }
    }
}
