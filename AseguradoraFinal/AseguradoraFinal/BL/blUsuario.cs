using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class blUsuario
    {
        #region variableModelo

        /// <summary>
        /// Variable del modelo del entitiframework. Contiene todos los objetos
        /// seleccionados de la base de datos
        /// </summary>
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        #endregion variableModelo

        #region Métodos y funciones

        /// <summary>
        /// Método que retorna el registro de un Usuario por medio del procedimiento almacenado
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public pa_RetornaUsuarioID_Result retornaUsuarioID(int pIdUsuario)
        {
            ///Creación de la variable que se retornará
            pa_RetornaUsuarioID_Result resultado = new pa_RetornaUsuarioID_Result();

            ///Asignar a la variable el resultado del llamado del procedimiento almacenado.
            ///FirstOrDefault permite retornar un único registro.
            resultado = this.modeloBD.pa_RetornaUsuarioID(pIdUsuario).FirstOrDefault();

            ///Retornación del resultado
            return resultado;
        }

        public List<pa_RetornaTipoUsuario_Result> retornaTipoUsuario(string pRol = null)
        {
            List<pa_RetornaTipoUsuario_Result> resultado = new List<pa_RetornaTipoUsuario_Result>();

            resultado = this.modeloBD.pa_RetornaTipoUsuario(pRol).ToList();

            return resultado;
        }

        #endregion Métodos y funciones
    }
}