//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cargo
    {
        public Cargo()
        {
            this.Empleado = new HashSet<Empleado>();
        }
    
        public int idcargo { get; set; }
        public string cargo1 { get; set; }
        public Nullable<double> sueldo { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
