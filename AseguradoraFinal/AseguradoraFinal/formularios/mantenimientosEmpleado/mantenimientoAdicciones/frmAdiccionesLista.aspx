<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
     <form runat="server" class="form-inline">

    <h1>Busqueda de Adicciones</h1>
     <div class="form-group">
           <asp:Label ID="Label1" runat="server" Text="Primer Apellido:"></asp:Label>
           <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control" ></asp:TextBox>            
        </div>
         <div class="form-group">
           <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
           <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>            
        </div>
        <div class="form-group">
             <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click"  />  
            <asp:HyperLink ID="hpNuevoRegistro" runat="server" CssClass="text-info" NavigateUrl="~/formularios/frmClienteInserta.aspx">Nuevo Registro</asp:HyperLink>
        </div>
        
    
    <br />
    <br />
    
    <br />
    
    <asp:GridView ID="grdListaClientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="20" OnPageIndexChanging="grdListaClientes_PageIndexChanging" OnSelectedIndexChanged="grdListaClientes_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="primerApellido" HeaderText="Apellido 1" />
            <asp:BoundField DataField="segundoApellido" HeaderText="Apellido 2" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField />
            <asp:BoundField DataField="nombrePaisProcedencia" HeaderText="Nacionalidad" />
            <asp:HyperLinkField DataNavigateUrlFields="id_Cliente" DataNavigateUrlFormatString="frmClienteModifica.aspx?id_Cliente{0}" Text="Modificar" />
            <asp:HyperLinkField DataNavigateUrlFields="id_Cliente" DataNavigateUrlFormatString="frmClienteElimina.aspx?id_Cliente={0}" Text="Eliminar" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    
</form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
