//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AseguradoraFinal.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int idTipoUsuario { get; set; }
        public string rol { get; set; }
    
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
