using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLAdiccionCliente
    {
        #region variableModelo
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();
        #endregion variableModelo

        #region Métodos y funciones
        /// <summary>
        /// Método que invoca el procedimiento almacenado pa_RetornaAdiccionesxCliente
        /// </summary>
        /// <param name="pCorreo"></param>
        /// <param name="pPriApellido"></param>
        /// <param name="pNombreCliente"></param>
        /// <returns></returns>
        public List<pa_RetornaAdiccionCliente_Result> retornaAdiccionCliente(string pCorreo = null, string pPriApellido = null, string pNombreCliente = null, string pNombreAdiccion = null, string pDescCategoria = null)
        {
            ///Creacion de la variable que retornará los datos
            List<pa_RetornaAdiccionCliente_Result> resultado = new List<pa_RetornaAdiccionCliente_Result>();
            ///Asignación de los datos a la variable resultado
            resultado = this.modeloBD.pa_RetornaAdiccionCliente(pCorreo, pPriApellido, pNombreCliente, pNombreAdiccion, pDescCategoria).ToList();
            ///Retornar el valor
            return resultado;
        }
        #endregion Métodos y funciones
    }
}