using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLPoliza
    {
        #region variableModelo

        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        #endregion variableModelo

        #region Métodos y funciones
        public List<pa_RetornaPoliza_Result> retornaPoliza(string pPrimerApeCliente = null, string pNumCedCliente = null,
                                                           string pNomCoberturaPoliza = null)
        {
            List<pa_RetornaPoliza_Result> resultadoPoliza = new List<pa_RetornaPoliza_Result>();

            resultadoPoliza = this.modeloBD.pa_RetornaPoliza(pPrimerApeCliente, pNumCedCliente, pNomCoberturaPoliza).ToList();

            return resultadoPoliza;
        }

        public pa_RetornaAdiccionesCantidad_Result retornaAdiccionesCantidad(int pIdCliente)
        {
            pa_RetornaAdiccionesCantidad_Result resultado = new pa_RetornaAdiccionesCantidad_Result();

            resultado = this.modeloBD.pa_RetornaAdiccionesCantidad(pIdCliente).FirstOrDefault();

            return resultado;
        }

        public pa_RetornaEmpleadoPoliza_Result retornaEmpleadoPoliza(int pIdUsuario)
        {
            pa_RetornaEmpleadoPoliza_Result resultado = new pa_RetornaEmpleadoPoliza_Result();

            resultado = this.modeloBD.pa_RetornaEmpleadoPoliza(pIdUsuario).FirstOrDefault();

            return resultado;
        }

        public pa_RetornaPolizaID_Result retornaPolizaID(int pIdPoliza)
        {
            pa_RetornaPolizaID_Result resultado = new pa_RetornaPolizaID_Result();

            resultado = this.modeloBD.pa_RetornaPolizaID(pIdPoliza).FirstOrDefault();

            return resultado;
        }

        public bool insertaPoliza(int pIdCoberturaPoliza, int pIdCliente, int pIdEmpleado, float pMontoAsegurado,
                                  int pCantAdicciones, float pMontoAdicciones, float pPrimaAntesImpuestos,
                                  float pImpuestos, float pPrimaFinal, DateTime pFechaRegistro, int pIdSucursal, float pPorcentajePrima)
        {
            ///Variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de registros
            ///afectados debe ser mayor a 0
            int registrosAfectados = 0;

            ///Invocación del procedimiento almacenado con las variables
            registrosAfectados = this.modeloBD.pa_InsertaPoliza(pIdCoberturaPoliza, pIdCliente, pIdEmpleado, pMontoAsegurado,
                                                                pCantAdicciones, pMontoAdicciones, pPrimaAntesImpuestos,
                                                                pImpuestos, pPrimaFinal, pFechaRegistro, pIdSucursal, pPorcentajePrima);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool modificaPoliza(int pIdRegistroPoliza, int pIdCoberturaPoliza, int pIdCliente, int pIdEmpleado,
                                   float pMontoAsegurado, int pCantAdicciones, float pMontoAdicciones, float pPrimaAntesImpuestos,
                                   float pImpuestos, float pPrimaFinal, DateTime pFechaRegistro, int pIdSucursal, float pPorcentajePrima)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.pa_ModificaPoliza(pIdRegistroPoliza, pIdCoberturaPoliza, pIdCliente, pIdEmpleado, pMontoAsegurado,
                                                pCantAdicciones, pMontoAdicciones, pPrimaAntesImpuestos, pImpuestos,
                                                pPrimaFinal, pFechaRegistro, pIdSucursal, pPorcentajePrima);

            return registrosAfectados > 0;
        }

        public bool eliminaPoliza(int pIdRegistroPoliza)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.pa_EliminaPoliza(pIdRegistroPoliza);

            return registrosAfectados > 0;
        }
        #endregion Métodos y funciones
    }
}