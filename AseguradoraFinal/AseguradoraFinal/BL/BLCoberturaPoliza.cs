using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLCoberturaPoliza
    {
        #region variableModelo

        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        #endregion variableModelo

        #region Métodos y funciones

        /// <summary>
        /// Método que invoca el procedimiento almacenado utilizando los parametros solicitados
        /// </summary>
        /// <param name="pNombreCobertura"></param>
        /// <param name="pNombreTipoPoliza"></param>
        /// <returns></returns>
        public List<pa_RetornaCoberturaPoliza_Result> retornaCoberturaPoliza(string pNombreCobertura = null, 
                                                                             string pNombreTipoPoliza = null)
        {
            ///Variable que retornará los datos
            List<pa_RetornaCoberturaPoliza_Result> resultado = new List<pa_RetornaCoberturaPoliza_Result>();

            ///Asignacion a la variable el resultado del procedimiento almacenado
            resultado = this.modeloBD.pa_RetornaCoberturaPoliza(pNombreCobertura, pNombreTipoPoliza).ToList();

            ///Retona el valor
            return resultado;
        }

        public bool insertaCoberturaPoliza(string pNombre, string pDesc, float pPorcentaje, int pIdTipoPoliza)
        {
            ///Variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de registros
            ///afectados debe ser mayor a 0
            int registrosAfectados = 0;

            ///Invocación del procedimiento almacenado con las variables
            registrosAfectados = this.modeloBD.pa_InsertaCoberturaPoliza(pNombre, pDesc, pPorcentaje, pIdTipoPoliza);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion Métodos y funciones
    }
}