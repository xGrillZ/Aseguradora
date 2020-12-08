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
    
    public partial class RegistroPoliza
    {
        public int idRegistroPoliza { get; set; }
        public int idCoberturaPoliza { get; set; }
        public int idCliente { get; set; }
        public int idEmpleado { get; set; }
        public int idAdiccion { get; set; }
        public double montoAsegurado { get; set; }
        public int cantAdicciones { get; set; }
        public double montoAdicciones { get; set; }
        public double primaAntesImpuestos { get; set; }
        public double impuestos { get; set; }
        public double primaFinal { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public int idSucursal { get; set; }
        public double porcentajePrima { get; set; }
    
        public virtual Adicciones Adicciones { get; set; }
        public virtual CoberturaPoliza CoberturaPoliza { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
