<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmTipoPolizaLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoTipoPoliza.frmTipoPolizaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="tipoPoliza-Lista">
        <div class="contenido-principal">
            <form id="form1" runat="server" class="form-inline">
                 <h1>Lista Tipo Poliza</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Nombre Poliza:"></asp:Label>
                     <asp:TextBox ID="txtPoliza" runat="server" class="form-control" ></asp:TextBox>            
                 </div>
                      <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" class="btn-success" OnClick="btnMostrarDatos_Click"  /> 
                 &nbsp;
                     <asp:HyperLink ID="hpNuevoTipo" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaInsertar.aspx">Ingresar nuevo Tipo Poliza</asp:HyperLink>
                 <br />
                 <br />
                <asp:GridView ID="grdTipoPoliza" runat="server" AllowCustomPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdTipoPoliza_PageIndexChanging" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre Poliza" />
                        <asp:BoundField DataField="detalles" HeaderText="Descripción" />
                        <asp:HyperLinkField DataNavigateUrlFields="idTipoPoliza" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaModificar.aspx?idTipoPoliza={0}" Text="Modificar" />
                        <asp:HyperLinkField DataNavigateUrlFields="idTipoPoliza" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoTipoPoliza/frmTipoPolizaEliminar?idTipoPoliza={0}" Text="Eliminar" />
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
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
