<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmUsuarioInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoUsuario.frmUsuarioInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="usuario-Inserta">
        <div class="contenido-principal">
            <form id="frmClienteInserta" runat="server" class="form-inline">      
              <h1 class="auto-style1">Ingreso de nuevos usuarios.</h1>       

               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>      
                  <asp:TextBox ID="txtContrasena" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtContrasena" runat="server"  ControlToValidate="txtContrasena" ErrorMessage="Debes ingresar una contraseña." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtContrasena" runat="server" ErrorMessage="La contraseña debe ser menor o igual a 15 carácteres." ControlToValidate="txtContrasena" Display="None" ValidationExpression="^[\s\S]{1,15}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Correo electrónico:"></asp:Label>                 
                   <asp:TextBox ID="txtCorreo" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtCorreo" runat="server"  ControlToValidate="txtCorreo" ErrorMessage="Debes ingresar el correo electrónico." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="reVtxtCorreo" runat="server" ErrorMessage="El correo electrónico debe ser menor o igual a 50 carácteres." ControlToValidate="txtCorreo" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
                   <asp:RegularExpressionValidator ID="reVtxtCorreoDos" runat="server" ErrorMessage="Debes de ingresar un correo electrónico válido" ControlToValidate="txtCorreo" Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
               </div>  
               <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Tipo usuario:"></asp:Label>                 
                   <asp:DropDownList ID="ddlTipoUsuario" runat="server" DataSourceID="idTipoUsuario" DataTextField="rol"></asp:DropDownList>
                   <asp:RequiredFieldValidator ID="rqVddlTipoUsuario" runat="server"  ControlToValidate="ddlTipoUsuario" ErrorMessage="Debes seleccionar el tipo de usuario." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Insertar" class="btn-success" OnClick="btInsertar_Click" /> 
               </div>                                                             
              <br />
              <asp:ValidationSummary ID="vsInsertaUsuario" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
