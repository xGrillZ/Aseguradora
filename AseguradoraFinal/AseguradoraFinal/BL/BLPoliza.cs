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
        #endregion Métodos y funciones
    }
}