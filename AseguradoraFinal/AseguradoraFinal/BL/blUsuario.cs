using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
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

        public List<pa_RetornaUsuarioCorreo_Result> retornaUsuarioCorreo(string pCorreo = null)
        {
           List<pa_RetornaUsuarioCorreo_Result> resultado = new List<pa_RetornaUsuarioCorreo_Result>();

            resultado = this.modeloBD.pa_RetornaUsuarioCorreo(pCorreo).ToList();

            return resultado;
        }

        public bool insertaUsuario(string pContrasena, int pIdTipoUsuario, string pCorreo)
        {
            ///Variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de registros
            ///afectados debe ser mayor a 0
            int registrosAfectados = 0;

            ///Invocación del procedimiento almacenado con las variables
            registrosAfectados = this.modeloBD.pa_InsertaUsuario(pContrasena, pIdTipoUsuario, pCorreo);

            ///Verificar si hay cambios en la variable
            if (registrosAfectados > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para verificar el correo electronico
        /// </summary>
        /// <param name="pCorreo">Variable a capturar</param>
        /// <returns></returns>
        public bool verificaCorreo(string pCorreo)
        {
            ///Resultado de la operación
            bool resultado = true;
            try
            {
                ///Variable que almacenará el dato solicitado
                string correo = pCorreo;
                ///Resultado de la operación
                resultado = this.modeloBD.Usuario.Count(usuario => usuario.correoElectronico == correo) <= 0;
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