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
    
    public partial class Categoria
    {
        public Categoria()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        public int idcat { get; set; }
        public string cat { get; set; }
        public Nullable<bool> estado { get; set; }
    
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
