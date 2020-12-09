using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLEmpleado
    {
        #region variableModelo
        /// <summary>
        /// Variable del modelo de EF, contiene todos los objetos
        /// seleccionados de una DB
        /// </summary>
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();
        #endregion variableModelo

        #region Métodos y funciones
        public List<pa_AdiccionesxClienteSelect_Result> Retorna_AdiccionesxClienteSelect(string pAdiccion, string pNombreCliente, string pNumCedula, string pGenero)
        {
            ///Crea variable que retornara
            List<pa_AdiccionesxClienteSelect_Result> resultado = new List<pa_AdiccionesxClienteSelect_Result>();
            ///Asignar a la variable el resultado del llamado del PA
            resultado = this.modeloBD.pa_AdiccionesxClienteSelect(pAdiccion, pNombreCliente, pNumCedula, pGenero).ToList();
            ///Retornar el valor
            return resultado;
        }

        public pa_RetornaUsuarioEmpleadoID_Result retornaUsuarioEmpleadoID(int pIdUsuarioEmpleado)
        {
            ///Creación de la variable que se retornará
            pa_RetornaUsuarioEmpleadoID_Result resultado = new pa_RetornaUsuarioEmpleadoID_Result();

            ///Asignar a la variable el resultado del llamado del procedimiento almacenado.
            ///FirstOrDefault permite retornar un único registro.
            resultado = this.modeloBD.pa_RetornaUsuarioEmpleadoID(pIdUsuarioEmpleado).FirstOrDefault();

            ///Retornación del resultado
            return resultado;
        }
        #endregion Métodos y funciones

    }
}
