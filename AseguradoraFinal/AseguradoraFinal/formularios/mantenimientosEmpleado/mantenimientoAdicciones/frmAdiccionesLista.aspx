<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
     <form runat="server" class="form-inline">

    <h1>Busqueda de Adicciones</h1>
     <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text=" Cédula de Identificación"></asp:Label>
         <asp:TextBox ID="txtnumCedula" runat="server" CssClass="form-control" OnTextChanged="txtnumCedula_TextChanged" ></asp:TextBox>         
       </div>
      

       <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
          <asp:TextBox ID="txtNombreCliente" runat="server" CssClass="form-control" OnTextChanged="txtNombreCliente_TextChanged" ></asp:TextBox>       
       </div>           
       
        <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Adicción"></asp:Label>
          <asp:TextBox ID="txtAdiccion" runat="server" CssClass="form-control" OnTextChanged="txtAdiccion_TextChanged" ></asp:TextBox> 
        </div>

        <div class="form-group">
             <br />
             <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click"  />  
            <asp:HyperLink ID="hpNuevoRegistro" runat="server" CssClass="text-info" NavigateUrl="~/formularios/frmAdiccionesInserta.aspx">Nuevo Registro</asp:HyperLink>
        </div>
        
    
    <br />
    <br />
    
    <br />
    
    <asp:GridView ID="grdListaAdicciones" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" AllowPaging="True" PageSize="20" OnPageIndexChanging="grdListaAdicciones_PageIndexChanging" OnSelectedIndexChanged="grdListaAdicciones_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="numCedula" HeaderText="Cedula" />
            <asp:BoundField DataField="ape1Cliente" HeaderText="Apellido 1" />
            <asp:BoundField DataField="ape2Cliente" HeaderText="Apellido 2" />
            <asp:BoundField DataField="nomCliente" HeaderText="Nombre" />
            <asp:BoundField DataField="Adiccion" HeaderText="Adicción" />
            <asp:BoundField DataField="correoElectronico" HeaderText="Correo Electrónico" />
            <asp:BoundField />
            <asp:BoundField DataField="categoriaAdiccion" HeaderText="Categoria Adiccion" />
            <asp:HyperLinkField DataNavigateUrlFields="id_Cliente" DataNavigateUrlFormatString="frmAdiccionesModifica.aspx?id_Cliente{0}" Text="Modificar" />
            <asp:HyperLinkField DataNavigateUrlFields="id_Cliente" DataNavigateUrlFormatString="frmAdiccionesElimina.aspx?id_Cliente={0}" Text="Eliminar" />
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
