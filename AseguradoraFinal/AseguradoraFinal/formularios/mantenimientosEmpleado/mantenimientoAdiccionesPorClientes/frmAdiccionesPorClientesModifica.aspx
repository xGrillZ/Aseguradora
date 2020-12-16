<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesPorClientesModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdiccionesPorClientes.frmAdiccionesPorClientesModifica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="adiccionesporCliente-Modifica">
        <div class="contenido-principal">
            <form id="frmAdiccionClienteModifica" runat="server" class="form-inline">      
              <h1 class="auto-style1">Modificación adicciones por cliente.</h1>
                <div class="principal">
                <div class="grupo-principal">
               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Adicción:"></asp:Label>      
                  <asp:DropDownList ID="ddlAdiccion" runat="server" DataTextField="nombre" DataValueField="idAdiccion"></asp:DropDownList>
                  <asp:RequiredFieldValidator ID="rqVddlAdiccion" runat="server"  ControlToValidate="ddlAdiccion" ErrorMessage="Debes ingresa una adicción." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <asp:HiddenField ID="hdIdAdiccionCliente" runat="server" />
                   <asp:HiddenField ID="hdIdCliente" runat="server" />
               </div>
                    <br />
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Número cédula:"></asp:Label>                 
                   <asp:TextBox ID="txtCedula" runat="server" ReadOnly="True"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtCedula" runat="server"  ControlToValidate="txtCedula" ErrorMessage="Debes ingresar la cédula del cliente" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <br />
               </div>   
                    <br />
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Modificar" class="btn-success" OnClick="btModificar_Click" /> 
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                   <asp:HyperLink ID="hpRegresarLista" runat="server" class="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesLista.aspx">Lista de datos.</asp:HyperLink>
               </div>                                                                
              <br />
              <asp:ValidationSummary ID="vsInsertaAdiccionCliente" runat="server" ShowMessageBox="True" ShowSummary="False" />
        </div>
                    </div>
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
