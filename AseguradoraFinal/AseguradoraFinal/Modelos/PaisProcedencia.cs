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
    
    public partial class PaisProcedencia
    {
        public PaisProcedencia()
        {
            this.Cliente = new HashSet<Cliente>();
        }
    
        public int id_PaisProcedencia { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
