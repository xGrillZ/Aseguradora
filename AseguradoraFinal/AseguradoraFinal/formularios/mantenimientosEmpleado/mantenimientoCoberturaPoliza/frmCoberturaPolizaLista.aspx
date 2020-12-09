<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmCoberturaPolizaLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza.frmCoberturaPolizaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="form1" runat="server">
    <div class="form-inline">
         <h1>Lista Cobertura Poliza</h1>
         <div class="form-group">
             <asp:Label ID="Label1" runat="server" Text="Nombre Cobertura:"></asp:Label>
             <asp:TextBox ID="txtCobertura" runat="server" CssClass="form-control" ></asp:TextBox>            
         </div>
          <div class="form-group">
              <asp:Label ID="Label2" runat="server" Text="Nombre Tipo Poliza:"></asp:Label>
              <asp:TextBox ID="txtTipoPoliza" runat="server" CssClass="form-control" ></asp:TextBox>            
          </div>
              <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click"  /> 
         <br />
         <br />
         <asp:GridView ID="grdListaCoberturaPoliza" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdListaCoberturaPoliza_PageIndexChanging">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <Columns>
                 <asp:BoundField DataField="nombre" HeaderText="Cobertura" />
                 <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                 <asp:BoundField DataField="porcentaje" HeaderText="Porcentaje" />
                 <asp:BoundField DataField="nombreTipoPoliza" HeaderText="Tipo Poliza" />
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
    </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
