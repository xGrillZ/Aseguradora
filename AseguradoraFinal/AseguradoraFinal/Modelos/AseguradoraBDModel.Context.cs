﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AseguradoraFinal.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class aseguradorarjsEntities : DbContext
    {
        public aseguradorarjsEntities()
            : base("name=aseguradorarjsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CoberturaPoliza> CoberturaPoliza { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<MantAddicionxCliente> MantAddicionxCliente { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<Telefono> Telefono { get; set; }
        public DbSet<TipoPoliza> TipoPoliza { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<CategoriaAdicciones> CategoriaAdicciones { get; set; }
        public DbSet<Adicciones> Adicciones { get; set; }
        public DbSet<RegistroPoliza> RegistroPoliza { get; set; }
    
        public virtual ObjectResult<pa_AdiccionesxClienteSelect_Result> pa_AdiccionesxClienteSelect(string adiccion, string nombreCliente, string numCedula, string genero)
        {
            var adiccionParameter = adiccion != null ?
                new ObjectParameter("Adiccion", adiccion) :
                new ObjectParameter("Adiccion", typeof(string));
    
            var nombreClienteParameter = nombreCliente != null ?
                new ObjectParameter("NombreCliente", nombreCliente) :
                new ObjectParameter("NombreCliente", typeof(string));
    
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("NumCedula", numCedula) :
                new ObjectParameter("NumCedula", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_AdiccionesxClienteSelect_Result>("pa_AdiccionesxClienteSelect", adiccionParameter, nombreClienteParameter, numCedulaParameter, generoParameter);
        }
    
        public virtual int pa_ClienteDelete(string numCedula)
        {
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("NumCedula", numCedula) :
                new ObjectParameter("NumCedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ClienteDelete", numCedulaParameter);
        }
    
        public virtual int pa_ClienteInsert(Nullable<int> idUsuario, string nomCliente, string ape1Cliente, string ape2Cliente, string numCedula, string genero, string direccionFisica, string pTelefono, string sTelefono, string correoElectronico, Nullable<System.DateTime> ultimoIngreso)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var nomClienteParameter = nomCliente != null ?
                new ObjectParameter("nomCliente", nomCliente) :
                new ObjectParameter("nomCliente", typeof(string));
    
            var ape1ClienteParameter = ape1Cliente != null ?
                new ObjectParameter("ape1Cliente", ape1Cliente) :
                new ObjectParameter("ape1Cliente", typeof(string));
    
            var ape2ClienteParameter = ape2Cliente != null ?
                new ObjectParameter("ape2Cliente", ape2Cliente) :
                new ObjectParameter("ape2Cliente", typeof(string));
    
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("numCedula", numCedula) :
                new ObjectParameter("numCedula", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var direccionFisicaParameter = direccionFisica != null ?
                new ObjectParameter("direccionFisica", direccionFisica) :
                new ObjectParameter("direccionFisica", typeof(string));
    
            var pTelefonoParameter = pTelefono != null ?
                new ObjectParameter("pTelefono", pTelefono) :
                new ObjectParameter("pTelefono", typeof(string));
    
            var sTelefonoParameter = sTelefono != null ?
                new ObjectParameter("sTelefono", sTelefono) :
                new ObjectParameter("sTelefono", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("correoElectronico", correoElectronico) :
                new ObjectParameter("correoElectronico", typeof(string));
    
            var ultimoIngresoParameter = ultimoIngreso.HasValue ?
                new ObjectParameter("ultimoIngreso", ultimoIngreso) :
                new ObjectParameter("ultimoIngreso", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ClienteInsert", idUsuarioParameter, nomClienteParameter, ape1ClienteParameter, ape2ClienteParameter, numCedulaParameter, generoParameter, direccionFisicaParameter, pTelefonoParameter, sTelefonoParameter, correoElectronicoParameter, ultimoIngresoParameter);
        }
    
        public virtual int pa_CoberturaPolizaUpdate(string nombre, string descripcion, Nullable<double> porcentaje, Nullable<int> idTipoPoliza)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("porcentaje", porcentaje) :
                new ObjectParameter("porcentaje", typeof(double));
    
            var idTipoPolizaParameter = idTipoPoliza.HasValue ?
                new ObjectParameter("idTipoPoliza", idTipoPoliza) :
                new ObjectParameter("idTipoPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_CoberturaPolizaUpdate", nombreParameter, descripcionParameter, porcentajeParameter, idTipoPolizaParameter);
        }
    
        public virtual int pa_EliminaAdiccionesDelete(string nombre, Nullable<int> codigo, Nullable<int> idCategoriaAdicion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var codigoParameter = codigo.HasValue ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(int));
    
            var idCategoriaAdicionParameter = idCategoriaAdicion.HasValue ?
                new ObjectParameter("idCategoriaAdicion", idCategoriaAdicion) :
                new ObjectParameter("idCategoriaAdicion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_EliminaAdiccionesDelete", nombreParameter, codigoParameter, idCategoriaAdicionParameter);
        }
    
        public virtual int pa_EliminaAdiccionesxCliente(Nullable<int> idAdiccion, Nullable<int> idCliente)
        {
            var idAdiccionParameter = idAdiccion.HasValue ?
                new ObjectParameter("idAdiccion", idAdiccion) :
                new ObjectParameter("idAdiccion", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_EliminaAdiccionesxCliente", idAdiccionParameter, idClienteParameter);
        }
    
        public virtual int pa_EliminaTipoPoliza(Nullable<int> id_TipoPoliza)
        {
            var id_TipoPolizaParameter = id_TipoPoliza.HasValue ?
                new ObjectParameter("id_TipoPoliza", id_TipoPoliza) :
                new ObjectParameter("id_TipoPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_EliminaTipoPoliza", id_TipoPolizaParameter);
        }
    
        public virtual int pa_EmpleadoInsert(Nullable<int> idUsuario, string nomEmpleado, string ape1Empleado, string ape2Empleado, string numCedula, Nullable<int> idSucursal, Nullable<System.DateTime> ultimoIngreso)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var nomEmpleadoParameter = nomEmpleado != null ?
                new ObjectParameter("nomEmpleado", nomEmpleado) :
                new ObjectParameter("nomEmpleado", typeof(string));
    
            var ape1EmpleadoParameter = ape1Empleado != null ?
                new ObjectParameter("ape1Empleado", ape1Empleado) :
                new ObjectParameter("ape1Empleado", typeof(string));
    
            var ape2EmpleadoParameter = ape2Empleado != null ?
                new ObjectParameter("ape2Empleado", ape2Empleado) :
                new ObjectParameter("ape2Empleado", typeof(string));
    
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("numCedula", numCedula) :
                new ObjectParameter("numCedula", typeof(string));
    
            var idSucursalParameter = idSucursal.HasValue ?
                new ObjectParameter("idSucursal", idSucursal) :
                new ObjectParameter("idSucursal", typeof(int));
    
            var ultimoIngresoParameter = ultimoIngreso.HasValue ?
                new ObjectParameter("ultimoIngreso", ultimoIngreso) :
                new ObjectParameter("ultimoIngreso", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_EmpleadoInsert", idUsuarioParameter, nomEmpleadoParameter, ape1EmpleadoParameter, ape2EmpleadoParameter, numCedulaParameter, idSucursalParameter, ultimoIngresoParameter);
        }
    
        public virtual ObjectResult<pa_EmpleadoSelect_Result> pa_EmpleadoSelect(string numCedula)
        {
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("NumCedula", numCedula) :
                new ObjectParameter("NumCedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_EmpleadoSelect_Result>("pa_EmpleadoSelect", numCedulaParameter);
        }
    
        public virtual int pa_InsertaAdiccionesxCliente(Nullable<int> idAdiccion, Nullable<int> idCliente)
        {
            var idAdiccionParameter = idAdiccion.HasValue ?
                new ObjectParameter("idAdiccion", idAdiccion) :
                new ObjectParameter("idAdiccion", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_InsertaAdiccionesxCliente", idAdiccionParameter, idClienteParameter);
        }
    
        public virtual int pa_InsertaTipoPoliza(string nombre, string detalles)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var detallesParameter = detalles != null ?
                new ObjectParameter("detalles", detalles) :
                new ObjectParameter("detalles", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_InsertaTipoPoliza", nombreParameter, detallesParameter);
        }
    
        public virtual int pa_ModificaAdicciones(string nombre, Nullable<int> codigo, Nullable<int> idCategoriaAdicion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var codigoParameter = codigo.HasValue ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(int));
    
            var idCategoriaAdicionParameter = idCategoriaAdicion.HasValue ?
                new ObjectParameter("idCategoriaAdicion", idCategoriaAdicion) :
                new ObjectParameter("idCategoriaAdicion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaAdicciones", nombreParameter, codigoParameter, idCategoriaAdicionParameter);
        }
    
        public virtual int pa_ModificaAdiccionesxCliente(Nullable<int> idAdiccion, Nullable<int> idCliente)
        {
            var idAdiccionParameter = idAdiccion.HasValue ?
                new ObjectParameter("idAdiccion", idAdiccion) :
                new ObjectParameter("idAdiccion", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaAdiccionesxCliente", idAdiccionParameter, idClienteParameter);
        }
    
        public virtual int pa_ModificaCliente(Nullable<int> idCliente, string nomCliente, string ape1Cliente, string ape2Cliente, string numCedula, string genero, string direccionFisica, string pTelefono, string sTelefono)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            var nomClienteParameter = nomCliente != null ?
                new ObjectParameter("nomCliente", nomCliente) :
                new ObjectParameter("nomCliente", typeof(string));
    
            var ape1ClienteParameter = ape1Cliente != null ?
                new ObjectParameter("ape1Cliente", ape1Cliente) :
                new ObjectParameter("ape1Cliente", typeof(string));
    
            var ape2ClienteParameter = ape2Cliente != null ?
                new ObjectParameter("ape2Cliente", ape2Cliente) :
                new ObjectParameter("ape2Cliente", typeof(string));
    
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("numCedula", numCedula) :
                new ObjectParameter("numCedula", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("genero", genero) :
                new ObjectParameter("genero", typeof(string));
    
            var direccionFisicaParameter = direccionFisica != null ?
                new ObjectParameter("direccionFisica", direccionFisica) :
                new ObjectParameter("direccionFisica", typeof(string));
    
            var pTelefonoParameter = pTelefono != null ?
                new ObjectParameter("pTelefono", pTelefono) :
                new ObjectParameter("pTelefono", typeof(string));
    
            var sTelefonoParameter = sTelefono != null ?
                new ObjectParameter("sTelefono", sTelefono) :
                new ObjectParameter("sTelefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaCliente", idClienteParameter, nomClienteParameter, ape1ClienteParameter, ape2ClienteParameter, numCedulaParameter, generoParameter, direccionFisicaParameter, pTelefonoParameter, sTelefonoParameter);
        }
    
        public virtual int pa_ModificaTipoPoliza(Nullable<int> id_TipoPoliza, string detalles)
        {
            var id_TipoPolizaParameter = id_TipoPoliza.HasValue ?
                new ObjectParameter("id_TipoPoliza", id_TipoPoliza) :
                new ObjectParameter("id_TipoPoliza", typeof(int));
    
            var detallesParameter = detalles != null ?
                new ObjectParameter("detalles", detalles) :
                new ObjectParameter("detalles", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaTipoPoliza", id_TipoPolizaParameter, detallesParameter);
        }
    
        public virtual int pa_ModificaUltimaSesionCliente(Nullable<int> idUsuario, Nullable<System.DateTime> ultimoIngreso)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var ultimoIngresoParameter = ultimoIngreso.HasValue ?
                new ObjectParameter("ultimoIngreso", ultimoIngreso) :
                new ObjectParameter("ultimoIngreso", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaUltimaSesionCliente", idUsuarioParameter, ultimoIngresoParameter);
        }
    
        public virtual int pa_ModificaUltimaSesionEmpleado(Nullable<int> idUsuario, Nullable<System.DateTime> ultimoIngreso)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var ultimoIngresoParameter = ultimoIngreso.HasValue ?
                new ObjectParameter("ultimoIngreso", ultimoIngreso) :
                new ObjectParameter("ultimoIngreso", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaUltimaSesionEmpleado", idUsuarioParameter, ultimoIngresoParameter);
        }
    
        public virtual int pa_RegistroPolizaDelete(Nullable<int> numPoliza)
        {
            var numPolizaParameter = numPoliza.HasValue ?
                new ObjectParameter("NumPoliza", numPoliza) :
                new ObjectParameter("NumPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_RegistroPolizaDelete", numPolizaParameter);
        }
    
        public virtual ObjectResult<pa_RetornaAdiccionesxCliente_Result> pa_RetornaAdiccionesxCliente(Nullable<int> idMantAdiccionxCliente, Nullable<int> idAdiccion, Nullable<int> idCliente)
        {
            var idMantAdiccionxClienteParameter = idMantAdiccionxCliente.HasValue ?
                new ObjectParameter("idMantAdiccionxCliente", idMantAdiccionxCliente) :
                new ObjectParameter("idMantAdiccionxCliente", typeof(int));
    
            var idAdiccionParameter = idAdiccion.HasValue ?
                new ObjectParameter("idAdiccion", idAdiccion) :
                new ObjectParameter("idAdiccion", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaAdiccionesxCliente_Result>("pa_RetornaAdiccionesxCliente", idMantAdiccionxClienteParameter, idAdiccionParameter, idClienteParameter);
        }
    
        public virtual ObjectResult<pa_RetornaTipoPolizaID_Result> pa_RetornaTipoPolizaID(Nullable<int> id_TipoPoliza)
        {
            var id_TipoPolizaParameter = id_TipoPoliza.HasValue ?
                new ObjectParameter("id_TipoPoliza", id_TipoPoliza) :
                new ObjectParameter("id_TipoPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaTipoPolizaID_Result>("pa_RetornaTipoPolizaID", id_TipoPolizaParameter);
        }
    
        public virtual ObjectResult<pa_RetornaTipoUsuario_Result> pa_RetornaTipoUsuario(string rol)
        {
            var rolParameter = rol != null ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaTipoUsuario_Result>("pa_RetornaTipoUsuario", rolParameter);
        }
    
        public virtual ObjectResult<pa_RetornaTipoUsuarioID_Result> pa_RetornaTipoUsuarioID(Nullable<int> idTipoUsuario)
        {
            var idTipoUsuarioParameter = idTipoUsuario.HasValue ?
                new ObjectParameter("idTipoUsuario", idTipoUsuario) :
                new ObjectParameter("idTipoUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaTipoUsuarioID_Result>("pa_RetornaTipoUsuarioID", idTipoUsuarioParameter);
        }
    
        public virtual ObjectResult<pa_RetornaUsuarioCliente_Result> pa_RetornaUsuarioCliente(Nullable<int> idUsuario, string correoElectronico, string nombreCliente, string primerApellidoCliente, string segundoApellidoCliente)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("correoElectronico", correoElectronico) :
                new ObjectParameter("correoElectronico", typeof(string));
    
            var nombreClienteParameter = nombreCliente != null ?
                new ObjectParameter("nombreCliente", nombreCliente) :
                new ObjectParameter("nombreCliente", typeof(string));
    
            var primerApellidoClienteParameter = primerApellidoCliente != null ?
                new ObjectParameter("primerApellidoCliente", primerApellidoCliente) :
                new ObjectParameter("primerApellidoCliente", typeof(string));
    
            var segundoApellidoClienteParameter = segundoApellidoCliente != null ?
                new ObjectParameter("segundoApellidoCliente", segundoApellidoCliente) :
                new ObjectParameter("segundoApellidoCliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaUsuarioCliente_Result>("pa_RetornaUsuarioCliente", idUsuarioParameter, correoElectronicoParameter, nombreClienteParameter, primerApellidoClienteParameter, segundoApellidoClienteParameter);
        }
    
        public virtual ObjectResult<pa_RetornaUsuarioClienteID_Result> pa_RetornaUsuarioClienteID(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaUsuarioClienteID_Result>("pa_RetornaUsuarioClienteID", idUsuarioParameter);
        }
    
        public virtual ObjectResult<pa_RetornaUsuarioCorreoPwd_Result> pa_RetornaUsuarioCorreoPwd(string contrasena, string correoElectronico)
        {
            var contrasenaParameter = contrasena != null ?
                new ObjectParameter("contrasena", contrasena) :
                new ObjectParameter("contrasena", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("correoElectronico", correoElectronico) :
                new ObjectParameter("correoElectronico", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaUsuarioCorreoPwd_Result>("pa_RetornaUsuarioCorreoPwd", contrasenaParameter, correoElectronicoParameter);
        }
    
        public virtual ObjectResult<pa_RetornaUsuarioEmpleado_Result> pa_RetornaUsuarioEmpleado(Nullable<int> idUsuario, string correoElectronico, string nombreEmpleado, string primerApellidoEmpleado, string segundoApellidoEmpleado)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("correoElectronico", correoElectronico) :
                new ObjectParameter("correoElectronico", typeof(string));
    
            var nombreEmpleadoParameter = nombreEmpleado != null ?
                new ObjectParameter("nombreEmpleado", nombreEmpleado) :
                new ObjectParameter("nombreEmpleado", typeof(string));
    
            var primerApellidoEmpleadoParameter = primerApellidoEmpleado != null ?
                new ObjectParameter("primerApellidoEmpleado", primerApellidoEmpleado) :
                new ObjectParameter("primerApellidoEmpleado", typeof(string));
    
            var segundoApellidoEmpleadoParameter = segundoApellidoEmpleado != null ?
                new ObjectParameter("segundoApellidoEmpleado", segundoApellidoEmpleado) :
                new ObjectParameter("segundoApellidoEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaUsuarioEmpleado_Result>("pa_RetornaUsuarioEmpleado", idUsuarioParameter, correoElectronicoParameter, nombreEmpleadoParameter, primerApellidoEmpleadoParameter, segundoApellidoEmpleadoParameter);
        }
    
        public virtual ObjectResult<pa_RetornaUsuarioEmpleadoID_Result> pa_RetornaUsuarioEmpleadoID(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaUsuarioEmpleadoID_Result>("pa_RetornaUsuarioEmpleadoID", idUsuarioParameter);
        }
    
        public virtual ObjectResult<pa_RetornaUsuarioID_Result> pa_RetornaUsuarioID(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaUsuarioID_Result>("pa_RetornaUsuarioID", idUsuarioParameter);
        }
    
        public virtual int pa_TipoPolizaUpdate(Nullable<int> idTipoPoliza, string nombre, string detalles)
        {
            var idTipoPolizaParameter = idTipoPoliza.HasValue ?
                new ObjectParameter("idTipoPoliza", idTipoPoliza) :
                new ObjectParameter("idTipoPoliza", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var detallesParameter = detalles != null ?
                new ObjectParameter("detalles", detalles) :
                new ObjectParameter("detalles", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_TipoPolizaUpdate", idTipoPolizaParameter, nombreParameter, detallesParameter);
        }
    
        public virtual ObjectResult<pa_RetornaAdicciones_Result> pa_RetornaAdicciones(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaAdicciones_Result>("pa_RetornaAdicciones", nombreParameter);
        }
    
        public virtual int pa_InsertaCoberturaPoliza(string nombre, string desc, Nullable<double> porcentaje, Nullable<int> idTipoPoliza)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descParameter = desc != null ?
                new ObjectParameter("desc", desc) :
                new ObjectParameter("desc", typeof(string));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("porcentaje", porcentaje) :
                new ObjectParameter("porcentaje", typeof(double));
    
            var idTipoPolizaParameter = idTipoPoliza.HasValue ?
                new ObjectParameter("idTipoPoliza", idTipoPoliza) :
                new ObjectParameter("idTipoPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_InsertaCoberturaPoliza", nombreParameter, descParameter, porcentajeParameter, idTipoPolizaParameter);
        }
    
        public virtual int pa_ModificaCoberturaPoliza(Nullable<int> idCoberturaPoliza, string nombre, string descripcion, Nullable<double> porcentaje, Nullable<int> idTipoPoliza)
        {
            var idCoberturaPolizaParameter = idCoberturaPoliza.HasValue ?
                new ObjectParameter("idCoberturaPoliza", idCoberturaPoliza) :
                new ObjectParameter("idCoberturaPoliza", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("porcentaje", porcentaje) :
                new ObjectParameter("porcentaje", typeof(double));
    
            var idTipoPolizaParameter = idTipoPoliza.HasValue ?
                new ObjectParameter("idTipoPoliza", idTipoPoliza) :
                new ObjectParameter("idTipoPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_ModificaCoberturaPoliza", idCoberturaPolizaParameter, nombreParameter, descripcionParameter, porcentajeParameter, idTipoPolizaParameter);
        }
    
        public virtual ObjectResult<pa_RetornaCoberturaPoliza_Result> pa_RetornaCoberturaPoliza(string nombreCobertura, string nombreTipoPoliza)
        {
            var nombreCoberturaParameter = nombreCobertura != null ?
                new ObjectParameter("nombreCobertura", nombreCobertura) :
                new ObjectParameter("nombreCobertura", typeof(string));
    
            var nombreTipoPolizaParameter = nombreTipoPoliza != null ?
                new ObjectParameter("nombreTipoPoliza", nombreTipoPoliza) :
                new ObjectParameter("nombreTipoPoliza", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaCoberturaPoliza_Result>("pa_RetornaCoberturaPoliza", nombreCoberturaParameter, nombreTipoPolizaParameter);
        }
    
        public virtual ObjectResult<pa_RetornaCoberturaPolizaID_Result> pa_RetornaCoberturaPolizaID(Nullable<int> id_CoberturaPoliza)
        {
            var id_CoberturaPolizaParameter = id_CoberturaPoliza.HasValue ?
                new ObjectParameter("id_CoberturaPoliza", id_CoberturaPoliza) :
                new ObjectParameter("id_CoberturaPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaCoberturaPolizaID_Result>("pa_RetornaCoberturaPolizaID", id_CoberturaPolizaParameter);
        }
    
        public virtual int pa_InsertaAdicciones(string nombre, Nullable<int> idCategoriaAdiccion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var idCategoriaAdiccionParameter = idCategoriaAdiccion.HasValue ?
                new ObjectParameter("idCategoriaAdiccion", idCategoriaAdiccion) :
                new ObjectParameter("idCategoriaAdiccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_InsertaAdicciones", nombreParameter, idCategoriaAdiccionParameter);
        }
    
        public virtual ObjectResult<pa_RetornaTipoPoliza_Result> pa_RetornaTipoPoliza(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaTipoPoliza_Result>("pa_RetornaTipoPoliza", nombreParameter);
        }
    
        public virtual int pa_EliminaCoberturaPoliza(Nullable<int> idCoberturaPoliza)
        {
            var idCoberturaPolizaParameter = idCoberturaPoliza.HasValue ?
                new ObjectParameter("idCoberturaPoliza", idCoberturaPoliza) :
                new ObjectParameter("idCoberturaPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_EliminaCoberturaPoliza", idCoberturaPolizaParameter);
        }
    
        public virtual int pa_EliminaAdicciones(Nullable<int> idAdiccion)
        {
            var idAdiccionParameter = idAdiccion.HasValue ?
                new ObjectParameter("idAdiccion", idAdiccion) :
                new ObjectParameter("idAdiccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pa_EliminaAdicciones", idAdiccionParameter);
        }
    
        public virtual ObjectResult<pa_RetornaCliente_Result> pa_RetornaCliente(string numCedula)
        {
            var numCedulaParameter = numCedula != null ?
                new ObjectParameter("numCedula", numCedula) :
                new ObjectParameter("numCedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaCliente_Result>("pa_RetornaCliente", numCedulaParameter);
        }
    
        public virtual ObjectResult<pa_RetornaPoliza_Result> pa_RetornaPoliza(string primerApellidoCliente, string numCedulaCliente, string nombreCoberturaPoliza)
        {
            var primerApellidoClienteParameter = primerApellidoCliente != null ?
                new ObjectParameter("primerApellidoCliente", primerApellidoCliente) :
                new ObjectParameter("primerApellidoCliente", typeof(string));
    
            var numCedulaClienteParameter = numCedulaCliente != null ?
                new ObjectParameter("numCedulaCliente", numCedulaCliente) :
                new ObjectParameter("numCedulaCliente", typeof(string));
    
            var nombreCoberturaPolizaParameter = nombreCoberturaPoliza != null ?
                new ObjectParameter("nombreCoberturaPoliza", nombreCoberturaPoliza) :
                new ObjectParameter("nombreCoberturaPoliza", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pa_RetornaPoliza_Result>("pa_RetornaPoliza", primerApellidoClienteParameter, numCedulaClienteParameter, nombreCoberturaPolizaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> pa_RetornaAdiccionesxClienteCantidad(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_RetornaAdiccionesxClienteCantidad", idClienteParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> pa_RetornaAdiccionClienteCantidad(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("pa_RetornaAdiccionClienteCantidad", idClienteParameter);
        }
    }
}
