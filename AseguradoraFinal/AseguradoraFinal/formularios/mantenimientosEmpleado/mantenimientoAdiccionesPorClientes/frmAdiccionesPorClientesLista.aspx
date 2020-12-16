<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesPorClientesLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdiccionesPorClientes.frmAdiccionesPorClientesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="adiccionesporCliente-Lista">
        <div class="contenido-principal">
             <form runat="server" class="form-inline">
            <h1>Busqueda de adicciones por cliente</h1>
            <div class="principal">
            <div class="grupo-principal">
                 <div class="form-group">
                   <asp:Label ID="Label3" runat="server" Text="Correo electrónico:"></asp:Label>
                   <asp:TextBox ID="txtCorreoElectrónico" runat="server" class="form-control" ></asp:TextBox>  
                </div>
                <br />
                 <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Primer apellido:"></asp:Label>
                   <asp:TextBox ID="txtPriApellido" runat="server" class="form-control" ></asp:TextBox>  
                </div>
                <br />
                 <div class="form-group">
                   <asp:Label ID="Label2" runat="server" Text="Nombre cliente:"></asp:Label>
                   <asp:TextBox ID="txtNombreCliente" runat="server" class="form-control" ></asp:TextBox>  
                </div>
                <br />
                 <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Nombre adicción:"></asp:Label>
                   <asp:TextBox ID="txtAdiccion" runat="server" class="form-control" ></asp:TextBox>  
                </div>
                <br />
                 <div class="form-group">
                   <asp:Label ID="Label5" runat="server" Text="Categoría:"></asp:Label>
                   <asp:TextBox ID="txtCategoria" runat="server" class="form-control" ></asp:TextBox>  
                </div>
                <br />
                <div class="form-group">
                     <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" class="btn-success" OnClick="btnMostrarDatos_Click"  />  
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                    <asp:HyperLink ID="hpNuevoRegistro" runat="server" class="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesInserta.aspx">Nuevo Registro</asp:HyperLink>
                </div>
            <br />
            <br />
                 <asp:GridView ID="grdAdiccionCliente" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                     <AlternatingRowStyle BackColor="#F7F7F7" />
                     <Columns>
                         <asp:BoundField DataField="nomCliente" HeaderText="Nombre" />
                         <asp:BoundField DataField="ape1Cliente" HeaderText="Primer apellido" />
                         <asp:BoundField DataField="ape2Cliente" HeaderText="Segundo apellido" />
                         <asp:BoundField DataField="correoElectronico" HeaderText="Correo electrónico" />
                         <asp:BoundField DataField="nombre" HeaderText="Adicción" />
                         <asp:BoundField DataField="descripcion" HeaderText="Categoría" />
                         <asp:HyperLinkField DataNavigateUrlFields="idMantAdiccionxCliente" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesModifica.aspx?idMantAdiccionxCliente={0}" Text="Modificar" />
                         <asp:HyperLinkField Text="Eliminar" DataNavigateUrlFields="idMantAdiccionxCliente" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoAdiccionesPorClientes/frmAdiccionesPorClientesElimina.aspx?idMantAdiccionxCliente={0}" />
                     </Columns>
                     <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                     <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                     <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                     <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                     <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                     <SortedAscendingCellStyle BackColor="#F4F4FD" />
                     <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                     <SortedDescendingCellStyle BackColor="#D8D8F0" />
                     <SortedDescendingHeaderStyle BackColor="#3E3277" />
                 </asp:GridView>
            <br />
                </div>
                </div>
            </form>
        </div>
   </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
