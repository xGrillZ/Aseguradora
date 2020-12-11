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
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.RegistroPoliza = new HashSet<RegistroPoliza>();
            this.MantAddicionxCliente = new HashSet<MantAddicionxCliente>();
        }
    
        public int idCliente { get; set; }
        public int idUsuario { get; set; }
        public string nomCliente { get; set; }
        public string ape1Cliente { get; set; }
        public string ape2Cliente { get; set; }
        public string numCedula { get; set; }
        public string genero { get; set; }
        public string direccionFisica { get; set; }
        public string pTelefono { get; set; }
        public string sTelefono { get; set; }
        public System.DateTime ultimoIngreso { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<RegistroPoliza> RegistroPoliza { get; set; }
        public virtual ICollection<MantAddicionxCliente> MantAddicionxCliente { get; set; }
    }
}
