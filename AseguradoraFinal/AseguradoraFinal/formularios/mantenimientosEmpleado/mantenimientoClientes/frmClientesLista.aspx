<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClientesLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoClientes.frmClientesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="clientes-Lista">
        <div class="contenido-principal">
            <form runat="server" class="form-inline">
            <h1>Busqueda de clientes</h1>
             <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Primer Apellido:"></asp:Label>
                   <asp:TextBox ID="txtPrimerApellido" runat="server" class="form-control" ></asp:TextBox>            
                </div>
                 <div class="form-group">
                   <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                   <asp:TextBox ID="txtNombre" runat="server" class="form-control" ></asp:TextBox>            
                </div>
                 <div class="form-group">
                   <asp:Label ID="Label3" runat="server" Text="Cédula:"></asp:Label>
                   <asp:TextBox ID="txtCedula" runat="server" class="form-control" ></asp:TextBox>            
                </div>
                 <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Género:"></asp:Label>
                   <asp:TextBox ID="txtGenero" runat="server" class="form-control" ></asp:TextBox>            
                </div>
                <div class="form-group">
                    <br />
                    <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos." class="btn-success" OnClick="btnMostrarDatos_Click"  />  
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                    <asp:HyperLink ID="hpNuevoRegistro" runat="server" class="text-info" NavigateUrl="~/formularios/mantenimientoClientes/frmClientesInserta.aspx">Nuevo registro clientes.</asp:HyperLink>
                    <br />
                    <br />
                    <asp:GridView ID="grdListaClientes" runat="server" AllowPaging="True" AutoGenerateColumns="False">
                    </asp:GridView>
                </div>
             </form>
           </div>
        </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
