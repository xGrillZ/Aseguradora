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
    
    public partial class CategoriaAdicciones
    {
        public CategoriaAdicciones()
        {
            this.Adicciones = new HashSet<Adicciones>();
        }
    
        public int idCategoriaAdiccion { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<Adicciones> Adicciones { get; set; }
    }
}
