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
    
    public partial class pa_RetornaPoliza_Result
    {
        public int idRegistroPoliza { get; set; }
        public int idCoberturaPoliza { get; set; }
        public string nombre { get; set; }
        public int idCliente { get; set; }
        public string ape1Cliente { get; set; }
        public string ape2Cliente { get; set; }
        public string nomCliente { get; set; }
        public string numCedula { get; set; }
        public int idEmpleado { get; set; }
        public string ape1Empleado { get; set; }
        public string ape2Empleado { get; set; }
        public string nomEmpleado { get; set; }
        public int idAdiccion { get; set; }
        public double montoAsegurado { get; set; }
        public int cantAdicciones { get; set; }
        public double montoAsegurado1 { get; set; }
        public double primaAntesImpuestos { get; set; }
        public double impuestos { get; set; }
        public double primaFinal { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public int idSucursal { get; set; }
        public string nomSucursal { get; set; }
        public double porcentajePrima { get; set; }
    }
}
