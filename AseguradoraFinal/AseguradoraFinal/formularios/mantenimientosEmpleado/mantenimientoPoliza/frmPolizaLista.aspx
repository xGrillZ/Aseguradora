<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmPolizaLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza.frmPolizaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="poliza-Lista">
        <div class="contenido-principal">
            <form id="frmPolizaLista" runat="server" class="form-inline">
                 <h1>Lista pólizas.</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Primer apellido cliente:"></asp:Label>
                     <asp:TextBox ID="txtPriApeCliente" runat="server" class="form-control" ></asp:TextBox>            
                 </div>
                  <div class="form-group">
                      <asp:Label ID="Label2" runat="server" Text="Número cédula cliente:"></asp:Label>
                      <asp:TextBox ID="txtNumCedula" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label4" runat="server" Text="Nombre cobertura:"></asp:Label>
                      <asp:TextBox ID="txtNombreCobertura" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label3" runat="server" Text="Número adicciones:"></asp:Label>
                      <asp:TextBox ID="txtNumAdicciones" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                      <br />
                      <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" class="btn-success" OnClick="btnMostrarDatos_Click"  /> 
                 &nbsp;
                     <asp:HyperLink ID="hpNuevaPoliza" runat="server" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaInserta.aspx">Ingresar nueva póliza</asp:HyperLink>
                 <br />
                 <br />
                 <asp:GridView ID="grdListaPoliza" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnPageIndexChanging="grdListaPoliza_PageIndexChanging">
                     <AlternatingRowStyle BackColor="#F7F7F7" />
                     <Columns>
                         <asp:BoundField DataField="nombre" HeaderText="Cobertura" />
                         <asp:BoundField DataField="nomCliente" HeaderText="Nombre cliente" />
                         <asp:BoundField DataField="ape1Cliente" HeaderText="Apellido cliente" />
                         <asp:BoundField DataField="numCedula" HeaderText="Número cédula" />
                         <asp:BoundField DataField="nomEmpleado" HeaderText="Nombre empleado" />
                         <asp:BoundField DataField="ape1Empleado" HeaderText="Apellido empleado" />
                         <asp:BoundField DataField="montoAsegurado" HeaderText="Monto asegurado" />
                         <asp:BoundField DataField="cantidadAdicciones" HeaderText="Cantidad adicciones" />
                         <asp:BoundField DataField="primaAntesImpuestos" HeaderText="Prima antes de impuestos" />
                         <asp:BoundField DataField="impuestos" HeaderText="Impuestos" />
                         <asp:BoundField DataField="primaFinal" HeaderText="Prima final" />
                         <asp:BoundField DataField="fechaRegistro" HeaderText="Fecha registro" />
                         <asp:BoundField DataField="nomSucursal" HeaderText="Sucursal" />
                         <asp:BoundField DataField="porcentajePrima" HeaderText="Porcentaje prima" />
                         <asp:HyperLinkField DataNavigateUrlFields="idRegistroPoliza" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaModifica.aspx?idRegistroPoliza={0}" Text="Modificar" />
                         <asp:HyperLinkField DataNavigateUrlFields="idRegistroPoliza" DataNavigateUrlFormatString="/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaElimina?idRegistroPoliza={0}" Text="Eliminar" />
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
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
