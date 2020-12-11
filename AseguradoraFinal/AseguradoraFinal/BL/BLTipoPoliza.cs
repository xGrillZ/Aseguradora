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

            ///Asignar a la variable el resultado del procedimiento almacenado en una lista.
            resultado = this.modeloBD.pa_RetornaTipoPoliza(pNombre).ToList();
            ///Retorna el resultado
            return resultado;
        }

        /// <summary>
        /// Método para retornar el ID del tipo de póliza
        /// </summary>
        /// <param name="pIdTipoPoliza">Parámetro ID tipo póliza</param>
        /// <returns></returns>
        public pa_RetornaTipoPolizaID_Result retornaTipoPolizaID(int pIdTipoPoliza)
        {
            ///Creación de la variable que retornará los datos
            pa_RetornaTipoPolizaID_Result resultado = new pa_RetornaTipoPolizaID_Result();

            ///Asignar a la variable el resultado del procedimiento almacenado.
            resultado = this.modeloBD.pa_RetornaTipoPolizaID(pIdTipoPoliza).FirstOrDefault();
            ///Retorna el resultado
            return resultado;
        }

        /// <summary>
        /// Método para insertar un nuevo tipo de póliza
        /// </summary>
        /// <param name="pNombre">Parámetro nombre del tipo de póliza</param>
        /// <param name="pDetalles">Parámetro del detalle del tipo de póliza</param>
        /// <returns></returns>
        public bool insertaTipoPoliza(string pNombre, string pDetalles)
        {
            ///Contador de registros afectados
            int registrosAfectados = 0;

            ///Asignar a la variable el resultado del procedimiento almacenado
            registrosAfectados = this.modeloBD.pa_InsertaTipoPoliza(pNombre, pDetalles);

            ///Verificar si hay cambios en la variable
            if (registrosAfectados > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para modificar el tipo de poliza
        /// </summary>
        /// <param name="pIdTipoPoliza">Parámetro ID del tipo de póliza</param>
        /// <param name="pDesc">Parámetro del detalle del tipo de póliza</param>
        /// <returns></returns>
        public bool modificaTipoPoliza(int pIdTipoPoliza, string pDesc)
        {
            ///Cotnador de registros afectados
            int registrosAfectados = 0;
            ///Asignar a la variable el resultado del procedimiento almacenado
            registrosAfectados = this.modeloBD.pa_ModificaTipoPoliza(pIdTipoPoliza, pDesc);
            ///Retorna el resultado si hay cambios o no en la variable
            return registrosAfectados > 0;        
        }

        /// <summary>
        /// Método para eliminar el tipo de póliza
        /// </summary>
        /// <param name="pIdTipoPoliza">Parámetro ID del tipo de póliza</param>
        /// <returns></returns>
        public bool eliminaTipoPoliza(int pIdTipoPoliza)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados = this.modeloBD.pa_EliminaTipoPoliza(pIdTipoPoliza);
            ///Retorna el resultado si hay cambios o no en la variable
            return registrosAfectados > 0;
        }
        #endregion Métodos y funciones
    }
}