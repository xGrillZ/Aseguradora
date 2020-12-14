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
                                                           string pNomCoberturaPoliza = null, int? pCantidadAdiccion = null)
        {
            List<pa_RetornaPoliza_Result> resultadoPoliza = new List<pa_RetornaPoliza_Result>();

            resultadoPoliza = this.modeloBD.pa_RetornaPoliza(pPrimerApeCliente, pNumCedCliente, pNomCoberturaPoliza, pCantidadAdiccion).ToList();

            return resultadoPoliza;
        }
        #endregion Métodos y funciones
    }
}