//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AseguradoraFinal.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefono
    {
        public Telefono()
        {
            this.Sucursal = new HashSet<Sucursal>();
        }
    
        public int idTelefono { get; set; }
        public string telefono1 { get; set; }
        public Nullable<int> extension { get; set; }
    
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}
