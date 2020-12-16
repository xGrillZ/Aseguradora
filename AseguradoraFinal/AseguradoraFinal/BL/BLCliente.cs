﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;
using System.Net;
using System.Net.Mail;

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

        public bool insertaCliente(int pIdUsuario, string pNomCliente, string pPriApe, string pSegApe, string pNumCedula, string pGen, string pDireccion, string pPriTel, string pSecTel, DateTime pUltimoIngreso)
        {
            ///Variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de registros
            ///afectados debe ser mayor a 0
            int registrosAfectados = 0;

            ///Invocación del procedimiento almacenado con las variables
            registrosAfectados = this.modeloBD.pa_InsertaCliente(pIdUsuario, pNomCliente, pPriApe, pSegApe, pNumCedula, pGen, pDireccion, pPriTel, pSecTel, pUltimoIngreso);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void correoElectronicoIngreso(string pPriApellido, string pSecApellido, string pNombre, string pCorreo)
        {
            string emailOrigen = "segurosxxiumca@gmail.com";
            string emailDestino = pCorreo;
            string contrasena = "CastroCarazoProgra";

            MailMessage oMailMessage = new MailMessage(emailOrigen, emailDestino, "Su Cuenta En Seguros El Equipo Del Siglo XXI",
                                                       $"Estimado cliente: {pPriApellido} {pSecApellido}" +
                                                       $" {pNombre}, gracias por confiar en Seguros el Equipo del Siglo XXI." +
                                                       $" Para nosotros es un placer servirle.");
            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(emailOrigen, contrasena);

            oSmtpClient.Send(oMailMessage);

            oSmtpClient.Dispose();
        }

        public pa_RetornaClienteCorreo_Result retornaClienteCorreo(int pIdUsuario)
        {
            pa_RetornaClienteCorreo_Result resultado = new pa_RetornaClienteCorreo_Result();

            resultado = this.modeloBD.pa_RetornaClienteCorreo(pIdUsuario).FirstOrDefault();

            return resultado;
        }
        #endregion Métodos y funciones
    }
}