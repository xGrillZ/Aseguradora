using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AseguradoraFinal.Modelos;

namespace AseguradoraFinal.BL
{
    public class BLCliente
    {
        /// <summary>
        /// Variable del modelo de EF, contiene todos los objetos
        /// seleccionados de la base de datos
        /// </summary>

        ClientesBDEntities modeloBD = new ClientesBDEntities();

        /// <summary>
        /// Invoca el procedimiento almacenado sp_RetornaCliente_Result
        /// utilizando los parametros correspondientes
        /// </summary> 

        ///  <param name="pPrimerApellido"></param>
        ///  <param name="pNombre"></param>
        ///  <returns></returns>


        public List<sp_RetornaCliente_Result>
            RetornaClientes(string pPrimerApellido = null, string pNombre = null)

        {
            ///crear la variable que se retornará
            List<sp_RetornaCliente_Result> resultado = new List<sp_RetornaCliente_Result>();
            ///Asignarle a la variable el resultado del llamado del Procedimiento almacenado
            resultado = this.modeloBD.sp_RetornaCliente(pPrimerApellido, pNombre).ToList();
            ///retorna el valor
            return resultado;
        }



        public bool InsertaCliente(int pId_TipoCliente,
            string pPrimerApellido, string pSegundoApellido, string pNombre,
            int pId_PaisProcedencia, string pTelefono1, string pTelefono2)

        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
             this.modeloBD.sp_InsertaCliente(
             pId_TipoCliente,
             pPrimerApellido,
             pSegundoApellido,
             pNombre,
             pId_PaisProcedencia,
             pTelefono1,
             pTelefono2);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public sp_RetornaClienteID_Result RetornaClienteID(int pIdCliente)
        {
            ///crear la variable que se retornara
            sp_RetornaClienteID_Result resultado = new sp_RetornaClienteID_Result();

            ///Asignarle a la variable el resultado del llamado del procedimiento almacenado
            ///es necesario incluir la instruccion FirstOrDefault
            ///para que retorne un unico registro, ya que EF asume que siempre
            ///se retornan "n" registros en los procedimientos almacenados que ejecutan
            ///la sentencia select 
            resultado =
                this.modeloBD.sp_RetornaClienteID(pIdCliente).FirstOrDefault();

            return resultado;
        }


        public bool ModificaCliente(int pId_Cliente, int pId_TipoCliente, string pPrimerApellido,
           string pSegundoApellido, string pNombre, int pId_PaisProcedencia,
           string pTelefono1, string pTelefono2)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_ModificaCliente(
                    pId_Cliente,
                    pId_TipoCliente,
                    pPrimerApellido,
                    pSegundoApellido,
                    pNombre,
                    pId_PaisProcedencia,
                    pTelefono1,
                    pTelefono2);

            return registrosAfectados > 0;
        }
        public bool EliminaCliente(int pId_Cliente)
        {
            ///variable que posee la cantidad de registros afectados
            ///al realizar insert/update/delete la cantidad de 
            ///registros afectados debe ser mayor a 0
            int registrosAfectados = 0;
            ///invocar al procedimiento almacenado
            registrosAfectados =
                this.modeloBD.sp_EliminaCliente(pId_Cliente);

            return registrosAfectados > 0;



        }
    }
}