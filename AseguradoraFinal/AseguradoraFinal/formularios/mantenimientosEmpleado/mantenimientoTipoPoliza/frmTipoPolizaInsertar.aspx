<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmTipoPolizaInsertar.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza.frmTipoPolizaInsertar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
   <section class="tipoPoliza-Insertar">
       <div class="contenido-principal">
           <form id="frmTipoPolizaInsertar" runat="server" class="form-inline">      
              <h1 class="auto-style1">Mantenimiento Tipo Póliza - Insertar</h1>       

               <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                   <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtNombre" runat="server" ErrorMessage="Debes ingresar un nombre" ControlToValidate="txtNombre" Display="None"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="reVtxtNombre" runat="server" ErrorMessage="El nombre del tipo de póliza debe ser menor o igual a 50 carácteres." ControlToValidate="txtNombre" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
               </div>
       
               <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>   
                  <asp:TextBox ID="txtDesc" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtDesc" runat="server" ErrorMessage="Debes ingresar una descripción" Display="None" ControlToValidate="txtDesc"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtDesc" runat="server" ErrorMessage="La descripción del tipo de póliza debe ser menor o igual a 100 carácteres." ControlToValidate="txtDesc" Display="None" ValidationExpression="^[\s\S]{1,100}$"></asp:RegularExpressionValidator>
               </div>
               <br />
               <br />

               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Insertar" CssClass="btn-success" OnClick="btAceptar_Click" />           
               </div>             
               <br />                                                       
               <asp:Label ID="lblMensaje" runat="server"></asp:Label>
               <br />
                                                                  
              <br />
              <asp:ValidationSummary ID="vsInsertarTipoPoliza" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
