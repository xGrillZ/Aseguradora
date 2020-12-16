<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesPorClientesElimina.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdiccionesPorClientes.frmAdiccionesPorClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="adiccionesporCliente-Elimina">
        <div class="contenido-principal">
            <form id="frmAdiccionClienteModifica" runat="server" class="form-inline">      
              <h1 class="auto-style1">Eliminación adicciones por cliente.</h1>       
               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Adicción:"></asp:Label>      
                  <asp:DropDownList ID="ddlAdiccion" runat="server" DataTextField="nombre" DataValueField="idAdiccion" Enabled="False"></asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rqVddlAdiccion" runat="server"  ControlToValidate="ddlAdiccion" ErrorMessage="Debes ingresa una adicción." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <asp:HiddenField ID="hdIdAdiccionCliente" runat="server" />
                   <asp:HiddenField ID="hdIdCliente" runat="server" />
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Número cédula:"></asp:Label>                 
                   <asp:TextBox ID="txtCedula" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtCedula" runat="server"  ControlToValidate="txtCedula" ErrorMessage="Debes ingresar la cédula del cliente" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <br />
               </div>           
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Eliminar" class="btn-success" OnClick="btEliminar_Click" /> 
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                   <asp:HyperLink ID="hpRegresarLista" runat="server" class="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesLista.aspx">Lista de datos.</asp:HyperLink>
               </div>                                                                
              <br />
              <asp:ValidationSummary ID="vsInsertaAdiccionCliente" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
