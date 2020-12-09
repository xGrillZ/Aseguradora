using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLCliente
    {
        #region variableModelo

        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        #endregion variableModelo

        #region Métodos y funciones
        /// <summary>
        /// Método que retorna el registro de un Usuario por medio del procedimiento almacenado
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <returns></returns>
        public pa_RetornaUsuarioClienteID_Result retornaUsuarioClienteID(int pIdUsuarioCliente)
        {
            ///Creación de la variable que se retornará
            pa_RetornaUsuarioClienteID_Result resultado = new pa_RetornaUsuarioClienteID_Result();

            ///Asignar a la variable el resultado del llamado del procedimiento almacenado.
            ///FirstOrDefault permite retornar un único registro.
            resultado = this.modeloBD.pa_RetornaUsuarioClienteID(pIdUsuarioCliente).FirstOrDefault();

            ///Retornación del resultado
            return resultado;
        }
        #endregion Métodos y funciones
    }
}