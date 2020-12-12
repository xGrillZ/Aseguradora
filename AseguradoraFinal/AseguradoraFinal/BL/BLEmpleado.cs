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
        public List<pa_RetornaAdicciones_Result> RetornaAdicciones(string nombre) 
        {
            ///Crea variable que retornara
            List<pa_RetornaAdicciones_Result> resultado = new List<pa_RetornaAdicciones_Result>();
            ///Asignar a la variable el resultado del llamado del PA
            resultado = this.modeloBD.pa_RetornaAdicciones(nombre).ToList();
            ///Retornar el valor
            return resultado;
        }

        public bool InsertaAdicciones(string nombre, int idCategoriaAdiccion)
        {

            int registrosAfectados = 0;

            ///Invocación del procedimiento almacenado con las variables
            registrosAfectados = this.modeloBD.pa_InsertaAdicciones(nombre, idCategoriaAdiccion);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

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

        /// <summary>
        /// Método que modifica la última sesión de un empleado
        /// </summary>
        /// <param name="pIdUsuario"></param>
        /// <param name="pUltimaSesion"></param>
        /// <returns></returns>
        public bool ModificaSesionEmpleado(int pIdUsuario, DateTime pUltimaSesion)
        {
            ///Variable que posee la cantidad de registros afectados
            int registrosAfectados = 0;

            ///Invocar al procedimiento almacenado
            registrosAfectados = this.modeloBD.pa_ModificaUltimaSesionEmpleado(pIdUsuario, pUltimaSesion);

            ///Retorna la variable de registros afectados
            return registrosAfectados > 0;
        }
        #endregion Métodos y funciones

    }
}
