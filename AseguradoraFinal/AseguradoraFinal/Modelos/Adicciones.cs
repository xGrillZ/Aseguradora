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
    
    public partial class Adicciones
    {
        public Adicciones()
        {
            this.MantAddicionxCliente = new HashSet<MantAddicionxCliente>();
            this.RegistroPoliza = new HashSet<RegistroPoliza>();
        }
    
        public int idAdiccion { get; set; }
        public string nombre { get; set; }
        public int idCategoriaAdiccion { get; set; }
    
        public virtual ICollection<MantAddicionxCliente> MantAddicionxCliente { get; set; }
        public virtual ICollection<RegistroPoliza> RegistroPoliza { get; set; }
        public virtual CategoriaAdicciones CategoriaAdicciones { get; set; }
    }
}
