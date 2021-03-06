﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmTipoPolizaModificar.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza.frmTipoPolizaModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
   <section class="tipoPoliza-Modificar">
       <div class="contenido-principal">
         <form id="frmTipoPolizaModifica" runat="server" class="form-inline">      
              <h1 class="auto-style1">Mantenimiento Tipo Póliza - Modificar</h1>       
            <div class="principal">
            <div class="grupo-principal">
               <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                   <asp:TextBox ID="txtNombre" runat="server" class="form-control" Enabled="False"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVddl_NombreTipoPoliza" runat="server" ErrorMessage="Debes de agregar un nombre de póliza" ControlToValidate="txtNombre" Display="None"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="reVtxtNombre" runat="server" ErrorMessage="El nombre del tipo de póliza debe ser menor o igual a 50 carácteres." ControlToValidate="txtNombre" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
                   <asp:HiddenField ID="hdTipoPoliza" runat="server" />
               </div>
       <br />
               <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text="Detalles:"></asp:Label>   
                  <asp:TextBox ID="txtDetalles" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtDetalles" runat="server" ErrorMessage="Debes de ingresar el detalle de póliza" Display="None" ControlToValidate="txtDetalles"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtDesc" runat="server" ErrorMessage="La descripción del tipo de póliza debe ser menor o igual a 100 carácteres." ControlToValidate="txtDetalles" Display="None" ValidationExpression="^[\s\S]{1,100}$"></asp:RegularExpressionValidator>
               </div>
             <br />
             <br />

               <div class="form-group">
                   <asp:Button ID="btnModificar" runat="server"  Text="Modificar" class="btn-success" OnClick="btAceptar_Click" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:HyperLink ID="hpListaTipoPoliza" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaLista.aspx">Lista datos</asp:HyperLink>
               </div>   
                <br />
                <br />
                                                                  
              <br />
              <asp:ValidationSummary ID="vsModificarTipoPoliza" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </div>
            </div>
            </form>
           </div>
       </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
