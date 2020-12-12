<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmTipoPolizaEliminar.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza.frmTipoPolizaEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
   <section class="tipoPoliza-Eliminar">
       <div class="contenido-principal">
         <form id="frmGastoCategoriaEliminar" runat="server" class="form-inline">      
              <h1 class="auto-style1">Mantenimiento Tipo Póliza - Eliminar</h1>       
          
               <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                   <asp:TextBox ID="txtNombre" runat="server" class="form-control" Enabled="False"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtNombre" runat="server" ErrorMessage="Debes de agregar un nombre de póliza" ControlToValidate="txtNombre" Display="None"></asp:RequiredFieldValidator>
                   <asp:HiddenField ID="hdIdTipoPoliza" runat="server" />
               </div>

               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>   
                  <asp:TextBox ID="txtDesc" runat="server" class="form-control" Enabled="False"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtDesc" runat="server" ErrorMessage="Debes de agregar un detalle de póliza" Display="None" ControlToValidate="txtDesc"></asp:RequiredFieldValidator>
               </div>
             <br />
             <br />

               <div class="form-group">
                   <asp:Button ID="btnEliminar" runat="server"  Text="Eliminar" class="btn-success" OnClick="btAceptar_Click" />
               </div>   
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                <br />
                                                                  
              <br />
              <asp:ValidationSummary ID="vsEliminarTipoPoliza" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
            </form>
           </div>
       </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
