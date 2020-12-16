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

        public bool insertaAdiccionCliente(int pIdAdiccion, int pIdCliente)
        {
            ///Variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de registros
            ///afectados debe ser mayor a 0
            int registrosAfectados = 0;

            ///Invocación del procedimiento almacenado con las variables
            registrosAfectados = this.modeloBD.pa_InsertaAdiccionesxCliente(pIdAdiccion, pIdCliente);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Método para verificar la adiccion por cliente
        /// </summary>
        /// <param name="pIdCliente">Variable a capturar</param>
        /// <param name="pIdAdiccion">Variable a capturar</param>
        /// <returns></returns>
        public bool verificaAdiccion(int pIdCliente, int pIdAdiccion)
        {
            ///Resultado de la operación
            bool resultado = true;
            try
            {
                ///Variable que almacenará el dato solicitado
                int cliente = pIdCliente;
                int adiccion = pIdAdiccion;
                ///Resultado de la operación
                resultado = this.modeloBD.MantAddicionxCliente.Count(adCliente => adCliente.idCliente == pIdCliente && adCliente.idAdiccion == adiccion ) <= 0;
            }
            catch
            {
                ///Mensaje de error
                string mensaje = "Error al verificar la cédula.";
            }
            ///Retorno del resultado
            return resultado;
        }

        /// <summary>
        /// Retrona el registro de Adicciones por cliente por medio del procedimiento almacenado
        /// </summary>
        /// <param name="pIdAdiccionCliente"></param>
        /// <returns></returns>
        public pa_RetornaAdiccionClienteID_Result retornaAdiccionClienteID(int pIdAdiccionCliente)
        {
            ///Variabla la cual retornará
            pa_RetornaAdiccionClienteID_Result resultado = new pa_RetornaAdiccionClienteID_Result();

            ///Asignacion del resultado del procedimiento almacenado a la variable
            resultado = this.modeloBD.pa_RetornaAdiccionClienteID(pIdAdiccionCliente).FirstOrDefault();

            return resultado;
        }
        /// <summary>
        /// Método para modificar la adiccion por cliente
        /// </summary>
        /// <param name="pIdAdiccion"></param>
        /// <param name="pIdAdiccionCliente"></param>
        /// <returns></returns>
        public bool modificaAdiccionCliente(int pIdAdiccion, int pIdAdiccionCliente)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.pa_ModificaAdiccionesxCliente(pIdAdiccion, pIdAdiccionCliente);

            return registrosAfectados > 0;

        }
        #endregion Métodos y funciones
    }
}