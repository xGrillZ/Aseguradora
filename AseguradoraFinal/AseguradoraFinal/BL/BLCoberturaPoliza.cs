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

        #endregion Métodos y funciones
    }
}