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
    
    public partial class Adicciones
    {
        public Adicciones()
        {
            this.MantAddicionxCliente = new HashSet<MantAddicionxCliente>();
        }
    
        public int idAdiccion { get; set; }
        public string nombre { get; set; }
        public int idCategoriaAdiccion { get; set; }
    
        public virtual CategoriaAdicciones CategoriaAdicciones { get; set; }
        public virtual ICollection<MantAddicionxCliente> MantAddicionxCliente { get; set; }
    }
}
