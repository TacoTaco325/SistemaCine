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
    
    public partial class Pelicula
    {
        public Pelicula()
        {
            this.Funcion = new HashSet<Funcion>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idgen { get; set; }
        public Nullable<int> idclasi { get; set; }
        public Nullable<bool> estado { get; set; }
        public byte[] img { get; set; }
        public Nullable<System.DateTime> estreno { get; set; }
        public string sinopsis { get; set; }
    
        public virtual Clasificacion Clasificacion { get; set; }
        public virtual ICollection<Funcion> Funcion { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
