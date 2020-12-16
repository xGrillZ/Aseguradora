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

        /// <summary>
        /// Método que modifica la última sesión de un Cliente
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <param name="pUltimaSesion"></param>
        /// <returns></returns>
        public bool ModificaSesionCliente(int pIdUsuario, DateTime pUltimaSesion)
        {
            ///Variable que posee la cantidad de registros afectados
            int registrosAfectados = 0;

            ///Invocar al procedimiento almacenado
            registrosAfectados = this.modeloBD.pa_ModificaUltimaSesionCliente(pIdUsuario, pUltimaSesion);

            ///Retorna la variable de registros afectados
            return registrosAfectados > 0;
        }

        public bool modificaClienteUsuario(int pIdCliente, string pDireccion, string pPriTelefono, string pSegTelefono = null)
        {
            ///Variable que posee la cantidad de registros afectados
            int registrosAfectados = 0;

            ///Invocar al procedimiento almacenado
            registrosAfectados = this.modeloBD.pa_ModificaClienteUsuario(pIdCliente, pDireccion, pPriTelefono, pSegTelefono);

            ///Retorna la variable de registros afectados
            return registrosAfectados > 0;
        }

        public List<pa_RetornaCliente_Result> retornaClientePoliza(string pNumCedula = null)
        {
            List<pa_RetornaCliente_Result> resultado = new List<pa_RetornaCliente_Result>();

            resultado = this.modeloBD.pa_RetornaCliente(pNumCedula).ToList();

            return resultado;
        }

        public pa_RetornaClienteCed_Result retornaClienteCedPoliza(string pNumCedula = null)
        {
            pa_RetornaClienteCed_Result resultado = new pa_RetornaClienteCed_Result();

            resultado = this.modeloBD.pa_RetornaClienteCed(pNumCedula).FirstOrDefault();

            return resultado;
        }

        public List<pa_RetornaClienteEmpleado_Result> retornaClienteEmpleado(string pPrimerApellido, string pNombreCliente, string pCedCliente, string pGeneroCliente)
        {
            ///Creacion de la variable que retornará los datos
            List<pa_RetornaClienteEmpleado_Result> resultado = new List<pa_RetornaClienteEmpleado_Result>();
            ///Asignación de los datos a la variable resultado
            resultado = this.modeloBD.pa_RetornaClienteEmpleado(pPrimerApellido, pNombreCliente, pCedCliente, pGeneroCliente).ToList();
            ///Retornar el valor
            return resultado;
        }
        #endregion Métodos y funciones
    }
}