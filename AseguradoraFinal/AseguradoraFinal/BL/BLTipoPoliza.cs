using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLTipoPoliza
    {
        #region variableModelo
        #endregion variableModelo

        #region Métodos y funciones
        /// <summary>
        /// Variable del modelo de EF, contiene todos los objetos
        /// seleccionados de la base de datos
        /// </summary>
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        public List<pa_RetornaTipoPoliza_Result> retornaTipoPoliza(string pNombre = null)
        {
            ///Creación de la variable que retornará los datos
            List<pa_RetornaTipoPoliza_Result> resultado = new List<pa_RetornaTipoPoliza_Result>();

            ///Asignar a la variable el resultado del procedimiento almacenado
            resultado = this.modeloBD.pa_RetornaTipoPoliza(pNombre).ToList();
            return resultado;
        }
        #endregion Métodos y funciones
    }
}