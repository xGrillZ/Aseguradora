using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLPaisProcedencia
    {

        /// <summary>
        /// Variable del modelo de EF, contiene todos los objetos
        /// seleccionados de la base de datos
        /// </summary>
        ClientesBDEntities modeloBD = new ClientesBDEntities();

        public List<sp_RetornaPaisProcedencia_Result> RetornaPaisProcedencia(string pNombre = null)
        {
            ///crear la variable que se retornará
            List<sp_RetornaPaisProcedencia_Result> resultado = new List<sp_RetornaPaisProcedencia_Result>();
            ///asignarle a la variable el resultado del llamado del procedimiento almacenado
            resultado = this.modeloBD.sp_RetornaPaisProcedencia(pNombre).ToList();
            return resultado;
        }
    }
}