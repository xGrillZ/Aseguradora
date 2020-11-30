    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLEmpleado
    {

        /// <summary>
        /// Variable del modelo de EF, contiene todos los objetos
        /// seleccionados de una DB
        /// </summary>
        aseguradorarjsEntities modeloBD = new aseguradorarjsEntities();

        public List<sp_Retorna_Catalogo_Categorias_Result> Retorna_Catalogo_Categorias(string pDescripcionCategoria = null)
        {
            ///Crea variable que retornara
            List<sp_Retorna_Catalogo_Categorias_Result> resultado = new List<sp_Retorna_Catalogo_Categorias_Result>();
            ///Asignar a la variable el resultado del llamado del PA
            resultado = this.modeloBD.sp_Retorna_Catalogo_Categorias(pDescripcionCategoria).ToList();
            ///Retornar el valor
            return resultado;
        }

    }
}
