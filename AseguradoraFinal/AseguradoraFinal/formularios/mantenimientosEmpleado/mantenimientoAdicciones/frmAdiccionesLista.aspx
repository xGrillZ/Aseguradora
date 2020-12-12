<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
     <form runat="server" class="form-inline">

    <h1>Busqueda de Adicciones</h1>

         


     <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text=" Nombre de la Adicción"></asp:Label>
         <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>         
       </div>
       
                          
       

        <div class="form-group">
             <br />
             <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click"  />  
            &nbsp;<asp:HyperLink ID="hpNuevoRegistro" runat="server" CssClass="text-info" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoAdicciones/frmAdiccionesInserta.aspx">Nuevo Registro</asp:HyperLink>
        &nbsp;
             <asp:HyperLink ID="hpRegresaPrincial" runat="server" CssClass="text-info" NavigateUrl="~/formularios/frmPrincipal.aspx">Regresar a Página Principal</asp:HyperLink>
        </div>
        
    
         <br />
        
    
         <asp:GridView ID="grdAdicciones" runat="server" AutoGenerateColumns="False"  PageIndex="50" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <Columns>
                 <asp:BoundField DataField="idAdiccion" HeaderText="Id" />
                 <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                 <asp:BoundField DataField="codigo" HeaderText="Código" />
                 <asp:BoundField DataField="descripcion" HeaderText="Descripción" />
                 <asp:HyperLinkField Text="Modificar" DataNavigateUrlFields="idAdiccion" DataNavigateUrlFormatString="frmAdiccionesModifica.aspx?idAdiccion={0}" />
                 <asp:HyperLinkField Text="Eliminar" DataNavigateUrlFields="idAdiccion" DataNavigateUrlFormatString="frmAdiccionesElimina.aspx?idAdiccion={0}" />
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
    <br />
    
    <br />
    
</form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
