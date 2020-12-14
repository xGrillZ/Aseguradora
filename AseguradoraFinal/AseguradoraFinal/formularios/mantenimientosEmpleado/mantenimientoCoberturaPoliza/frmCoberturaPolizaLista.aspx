<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmCoberturaPolizaLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza.frmCoberturaPolizaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="coberturaPoliza-Lista">
        <div class="contenido-principal">
            <form id="form1" runat="server" class="form-inline">
                 <h1>Lista Cobertura Poliza</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Nombre Cobertura:"></asp:Label>
                     <asp:TextBox ID="txtCobertura" runat="server" class="form-control" ></asp:TextBox>            
                 </div>
                  <div class="form-group">
                      <asp:Label ID="Label2" runat="server" Text="Nombre Tipo Poliza:"></asp:Label>
                      <asp:TextBox ID="txtTipoPoliza" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                      <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" class="btn-success" OnClick="btnMostrarDatos_Click"  /> 
                 &nbsp;
                     <asp:HyperLink ID="hpNuevaCobertura" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaInserta.aspx">Ingresar nueva Cobertura</asp:HyperLink>
                 <br />
                 <br />
                 <asp:GridView ID="grdListaCoberturaPoliza" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdListaCoberturaPoliza_PageIndexChanging">
                     <AlternatingRowStyle BackColor="#F7F7F7" />
                     <Columns>
                         <asp:BoundField DataField="nombre" HeaderText="Cobertura" />
                         <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                         <asp:BoundField DataField="porcentaje" HeaderText="Porcentaje" />
                         <asp:BoundField DataField="nombreTipoPoliza" HeaderText="Tipo Poliza" />
                         <asp:HyperLinkField DataNavigateUrlFields="idCoberturaPoliza" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaModifica?idCoberturaPoliza={0}" Text="Modificar" />
                         <asp:HyperLinkField DataNavigateUrlFields="idCoberturaPoliza" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaElimina.aspx?idCoberturaPoliza={0}" Text="Eliminar" />
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
