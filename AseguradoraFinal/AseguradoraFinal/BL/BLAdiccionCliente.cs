﻿using System;
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
        /// <summary>
        /// Método para insertar una nueva adicción por cliente
        /// </summary>
        /// <param name="pIdAdiccion"></param>
        /// <param name="pIdCliente"></param>
        /// <returns></returns>
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
        /// Método para verificar la adiccion por cliente, prueba
        /// </summary>
        /// <param name="pIdCliente">Variable a capturar</param>
        /// <param name="pIdAdiccion">Variable a capturar</param>
        /// <returns></returns>
        public bool verificaAdiccionV2(int pIdCliente, int pIdAdiccion)
        {
            ///Resultado de la operación
            bool resultado = true;
            try
            {
                ///Variable que almacenará el dato solicitado
                int cliente = pIdCliente;
                int adiccion = pIdAdiccion;
                ///Resultado de la operación
                resultado = this.modeloBD.MantAddicionxCliente.Count(adCliente => adCliente.idCliente != pIdCliente && adCliente.idAdiccion != adiccion) <= 0;
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
        /// Método para modificar la adiccion por cliente
        /// </summary>
        /// <param name="pIdAdiccion"></param>
        /// <param name="pIdMantAdiccionCliente"></param>
        /// <returns></returns>
        public bool modificaAdiccionCliente(int pIdAdiccion, int pIdMantAdiccionCliente)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.pa_ModificaAdiccionCliente(pIdAdiccion, pIdMantAdiccionCliente);

            return registrosAfectados > 0;

        }
        /// <summary>
        /// Método para obtener los datos de adicciones por clientes por medio del ID
        /// </summary>
        /// <param name="pIdAdiccionCliente"></param>
        /// <returns></returns>
        public pa_RetornaAdiccionClienteID_Result retornaAdiccionPorClienteID(int pIdAdiccionCliente)
        {
            pa_RetornaAdiccionClienteID_Result resultado = new pa_RetornaAdiccionClienteID_Result();

            resultado = this.modeloBD.pa_RetornaAdiccionClienteID(pIdAdiccionCliente).FirstOrDefault();

            return resultado;
        }
        /// <summary>
        /// Método para eliminar las adicciones por cliente
        /// </summary>
        /// <param name="pIdMantAdiccionCliente"></param>
        /// <returns></returns>
        public bool eliminaAdiccionPorCliente(int pIdMantAdiccionCliente)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.pa_EliminaAdiccionCliente(pIdMantAdiccionCliente);

            return registrosAfectados > 0;

        }
        #endregion Métodos y funciones
    }
}