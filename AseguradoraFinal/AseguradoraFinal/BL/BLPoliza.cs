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
        /// <summary>
        /// Metodo para retornar datos de poliza
        /// </summary>
        /// <param name="pPrimerApeCliente"></param>
        /// <param name="pNumCedCliente"></param>
        /// <param name="pNomCoberturaPoliza"></param>
        /// <returns></returns>
        public List<pa_RetornaPoliza_Result> retornaPoliza(string pPrimerApeCliente = null, string pNumCedCliente = null,
                                                           string pNomCoberturaPoliza = null)
        {
            List<pa_RetornaPoliza_Result> resultadoPoliza = new List<pa_RetornaPoliza_Result>();

            resultadoPoliza = this.modeloBD.pa_RetornaPoliza(pPrimerApeCliente, pNumCedCliente, pNomCoberturaPoliza).ToList();

            return resultadoPoliza;
        }
        /// <summary>
        /// Metodo para retonar la cantidad adicciones
        /// </summary>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
        public pa_RetornaAdiccionesCantidad_Result retornaAdiccionesCantidad(int pIdCliente)
        {
            pa_RetornaAdiccionesCantidad_Result resultado = new pa_RetornaAdiccionesCantidad_Result();

            resultado = this.modeloBD.pa_RetornaAdiccionesCantidad(pIdCliente).FirstOrDefault();

            return resultado;
        }
        /// <summary>
        /// Metodo para retornar poliza empleado
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public pa_RetornaEmpleadoPoliza_Result retornaEmpleadoPoliza(int pIdUsuario)
        {
            pa_RetornaEmpleadoPoliza_Result resultado = new pa_RetornaEmpleadoPoliza_Result();

            resultado = this.modeloBD.pa_RetornaEmpleadoPoliza(pIdUsuario).FirstOrDefault();

            return resultado;
        }
        /// <summary>
        /// Metodo para retornar datos por medio del ID
        /// </summary>
        /// <param name="pIdPoliza"></param>
        /// <returns></returns>
        public pa_RetornaPolizaID_Result retornaPolizaID(int pIdPoliza)
        {
            pa_RetornaPolizaID_Result resultado = new pa_RetornaPolizaID_Result();

            resultado = this.modeloBD.pa_RetornaPolizaID(pIdPoliza).FirstOrDefault();

            return resultado;
        }
        /// <summary>
        /// Metodo para insertar una nueva poliza
        /// </summary>
        /// <param name="pIdCoberturaPoliza"></param>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdEmpleado"></param>
        /// <param name="pMontoAsegurado"></param>
        /// <param name="pCantAdicciones"></param>
        /// <param name="pMontoAdicciones"></param>
        /// <param name="pPrimaAntesImpuestos"></param>
        /// <param name="pImpuestos"></param>
        /// <param name="pPrimaFinal"></param>
        /// <param name="pFechaRegistro"></param>
        /// <param name="pIdSucursal"></param>
        /// <param name="pPorcentajePrima"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para modificar la poliza
        /// </summary>
        /// <param name="pIdRegistroPoliza"></param>
        /// <param name="pIdCoberturaPoliza"></param>
        /// <param name="pIdCliente"></param>
        /// <param name="pIdEmpleado"></param>
        /// <param name="pMontoAsegurado"></param>
        /// <param name="pCantAdicciones"></param>
        /// <param name="pMontoAdicciones"></param>
        /// <param name="pPrimaAntesImpuestos"></param>
        /// <param name="pImpuestos"></param>
        /// <param name="pPrimaFinal"></param>
        /// <param name="pFechaRegistro"></param>
        /// <param name="pIdSucursal"></param>
        /// <param name="pPorcentajePrima"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para eliminar la poliza
        /// </summary>
        /// <param name="pIdRegistroPoliza"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método para verificar el numero de cedula
        /// </summary>
        /// <param name="pNumCedula">Variable a capturar</param>
        /// <returns></returns>
        public bool verificaCedula(string pNumCedula)
        {
            ///Resultado de la operación
            bool resultado = true;
            try
            {
                ///Variable que almacenará el dato solicitado
                string ced = pNumCedula;
                ///Resultado de la operación
                resultado = this.modeloBD.Cliente.Count(cliente => cliente.numCedula != ced) <= 0;
            }
            catch
            {
                ///Mensaje de error
                string mensaje = "Error al verificar la cédula.";
            }
            ///Retorno del resultado
            return resultado;
        }
        #endregion Métodos y funciones
    }
}