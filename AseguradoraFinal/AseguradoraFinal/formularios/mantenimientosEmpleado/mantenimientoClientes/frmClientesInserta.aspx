<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClientesInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoClientes.frmClientesInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="clientes-Inserta">
        <div class="contenido-principal">
            <form id="frmClienteInserta" runat="server" class="form-inline">      
              <h1 class="auto-style1">Ingreso de nuevos asegurados</h1>       

               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Primer Apellido"></asp:Label>      
                  <asp:TextBox ID="txtPrimerApellido" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqvPrimerApellido" runat="server"  ControlToValidate="txtPrimerApellido" ErrorMessage="Debe ingresar el primer apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Segundo Apellido"></asp:Label>                 
                   <asp:TextBox ID="txtSegundoApellido" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqvTxtSegundoApellido" runat="server"  ControlToValidate="txtSegundoApellido" ErrorMessage="Debe ingresar el segundo apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>           
               <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
                     <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rqvTxtNombre" runat="server" ControlToValidate="txtNombre" CssClass="form-control" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                  <asp:Label ID="Label6" runat="server" Text="Teléfono 1"></asp:Label>
                  <asp:TextBox ID="txtTelefono1" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqvTxtTelefono1" runat="server" ControlToValidate="txtTelefono1" CssClass="form-control" ErrorMessage="Debe ingresar el teléfono principal" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
      
               <div class="form-group">
                  <asp:Label ID="Label7" runat="server" Text="Teléfono 2"></asp:Label>
                  <asp:TextBox ID="txtTelefono2" runat="server" class="form-control"></asp:TextBox>
               </div>
                <div class="form-group">
                  <asp:Label ID="Label1" runat="server" Text="Tipo Cliente"></asp:Label> 
                    <asp:DropDownList ID="ddlTipoCliente" runat="server"  CssClass="form-control" DataTextField="nombre" DataValueField="id_TipoCliente"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rqvddlTipoCliente" runat="server" ErrorMessage="Debe seleccionar el tipo de cliente" Display="None" ControlToValidate="ddlTipoCliente"></asp:RequiredFieldValidator>
                </div>

               <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text="País Procedencia"></asp:Label>      
                    <asp:DropDownList ID="lstPaisProcedencia" runat="server"  class="form-control" DataTextField="nombre" DataValueField="id_PaisProcedencia" ></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rqvlstPaisProcedencia" runat="server" ErrorMessage="Debe seleccionar el pais de procedencia" Display="None" ControlToValidate="lstPaisProcedencia"></asp:RequiredFieldValidator>
                </div>
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Insertar" class="btn-success" OnClick="btInsertar_Click" /> 
                    <asp:HyperLink ID="hpRegresarLista" runat="server" class="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoClientes/frmClientesLista.aspx">Lista de datos.</asp:HyperLink>
               </div>                                                             
              <br />
              <asp:ValidationSummary ID="vsInsertaCliente" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
