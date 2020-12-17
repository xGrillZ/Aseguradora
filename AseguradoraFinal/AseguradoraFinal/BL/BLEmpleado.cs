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
        /// <summary>
        /// Metodo para retornar datos de adicciones
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<pa_RetornaAdicciones_Result> RetornaAdicciones(string nombre=null ) 
        {
            ///Crea variable que retornara
            List<pa_RetornaAdicciones_Result> resultado = new List<pa_RetornaAdicciones_Result>();
            ///Asignar a la variable el resultado del llamado del PA
            resultado = this.modeloBD.pa_RetornaAdicciones(nombre).ToList();
            ///Retornar el valor
            return resultado;
        }
        /// <summary>
        /// Metodo para retornar la categoria adicciones
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public List<pa_RetornaCategoriaAdicciones_Result> retornaCategoriaAdicciones(string pNombre = null)
        {
            List<pa_RetornaCategoriaAdicciones_Result> resultado = new List<pa_RetornaCategoriaAdicciones_Result>();

            resultado = this.modeloBD.pa_RetornaCategoriaAdicciones(pNombre).ToList();

            return resultado;
        }
        /// <summary>
        /// Metodo para insertar adicciones
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idCategoriaAdiccion"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Metodo para eliminar adicciones
        /// </summary>
        /// <param name="idAdiccion"></param>
        /// <returns></returns>
        public bool EliminaAdicciones(int idAdiccion)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.pa_EliminaAdicciones(idAdiccion); 

            return registrosAfectados > 0;

        }

        /// <summary>
        /// Retrona el registro de un GastoCategoria por medio del procedimiento almacenado
        /// </summary>
        /// <param name="pIdAdiccion"></param>
        /// <returns></returns>
        public pa_RetornaAdiccionesID_Result RetornaAdiccionesID(int pIdAdiccion)
        {
            ///Variabla la cual retornará
            pa_RetornaAdiccionesID_Result resultado = new pa_RetornaAdiccionesID_Result();

            ///Asignacion del resultado del procedimiento almacenado a la variable
            resultado = this.modeloBD.pa_RetornaAdiccionesID(pIdAdiccion).FirstOrDefault();

            return resultado;
        }

        /// <summary>
        /// Metodo para modificar adicciones
        /// </summary>
        /// <param name="pIdAdiccion"></param>
        /// <param name="pNombre"></param>
        /// <param name="pIdCategoriaAdiccion"></param>
        /// <returns></returns>
        public bool ModificaAdicciones (int pIdAdiccion, string pNombre, int pIdCategoriaAdiccion)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
            this.modeloBD.pa_ModificaAdicciones(pIdAdiccion, pNombre, pIdCategoriaAdiccion);

            return registrosAfectados > 0;

        }
        /// <summary>
        /// Método para verificar el nombre de adicción
        /// </summary>
        /// <param name="pNombreAdiccion">Variable a capturar</param>
        /// <returns></returns>
        public bool verificaAdiccion(string pNombreAdiccion)
        {
            ///Resultado de la operación
            bool resultado = true;
            try
            {
                ///Variable que almacenará el dato solicitado
                string nuevoNombre = pNombreAdiccion;
                ///Resultado de la operación
                resultado = this.modeloBD.Adicciones.Count(adiccion => adiccion.nombre == nuevoNombre) <= 0;
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
        /// Metodo para retornar el usuario ID
        /// </summary>
        /// <param name="pIdUsuarioEmpleado"></param>
        /// <returns></returns>
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
