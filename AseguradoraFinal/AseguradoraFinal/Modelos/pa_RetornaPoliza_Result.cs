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
        public double montoAsegurado { get; set; }
        public double montoAdicciones { get; set; }
        public Nullable<int> cantidadAdicciones { get; set; }
        public double primaAntesImpuestos { get; set; }
        public double impuestos { get; set; }
        public double primaFinal { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public int idSucursal { get; set; }
        public string nomSucursal { get; set; }
        public double porcentajePrima { get; set; }
    }
}
