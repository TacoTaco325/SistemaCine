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
    
    public partial class Clasificacion
    {
        public Clasificacion()
        {
            this.Pelicula = new HashSet<Pelicula>();
        }
    
        public int idclasi { get; set; }
        public string clasificacion1 { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual ICollection<Pelicula> Pelicula { get; set; }
    }
}
