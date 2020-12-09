<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmClienteLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientoCliente.matenimientoCliente.frmClienteLista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <h1>Lista de Clientes</h1>
     <div class="form-group">
           <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
           <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control" ></asp:TextBox>            
        </div>
         <div class="form-group">
           <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
           <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>            
        </div>
         <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" CssClass="btn-success"  />      
    <form runat="server" class="form-inline">

    <h1>Busqueda de Adicciones</h1>
     <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text=" Cédula de Identificación"></asp:Label>
         <asp:TextBox ID="txtnumCedula" runat="server" CssClass="form-control" ></asp:TextBox>         
       </div>
      

       <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
          <asp:TextBox ID="txtNombreCliente" runat="server" CssClass="form-control" ></asp:TextBox>       
       </div>           
       
        <div class="form-group">
          <asp:Label ID="Label5" runat="server" Text="Adicción"></asp:Label>
          <asp:TextBox ID="txtAdiccion" runat="server" CssClass="form-control"  ></asp:TextBox> 
        </div>

         <div class="form-group">
          <asp:Label ID="Label6" runat="server" Text="Género"></asp:Label>
          <asp:TextBox ID="txtGenero" runat="server" CssClass="form-control"  ></asp:TextBox> 
        </div>

        <div class="form-group">
             <br />
             <asp:Button ID="Button1" runat="server"  Text="Mostrar datos" CssClass="btn-success" OnClick="btnMostrarDatos_Click"  />  
            &nbsp;<asp:HyperLink ID="hpNuevoRegistro" runat="server" CssClass="text-info" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoAdicciones/frmAdiccionesInserta.aspx">Nuevo Registro</asp:HyperLink>
        &nbsp;
             <asp:HyperLink ID="hpRegresaPrincial" runat="server" CssClass="text-info" NavigateUrl="~/formularios/frmPrincipal.aspx">Regresar a Página Principal</asp:HyperLink>
        </div>
        
    
         <br />
        
    
         <asp:GridView ID="grdAdicciones" runat="server" AutoGenerateColumns="False"  PageIndex="50" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
             <AlternatingRowStyle BackColor="#F7F7F7" />
             <Columns>
                 <asp:BoundField DataField="numCedula" HeaderText="Cédula" />
                 <asp:BoundField DataField="nomCliente" HeaderText="Nombre" />
                 <asp:BoundField DataField="ape1Cliente" HeaderText="Primer Apellido" />
                 <asp:BoundField DataField="ape2Cliente" HeaderText="Segundo Apellido" />
                 <asp:BoundField DataField="nombre" HeaderText="Adicción" />
                 <asp:BoundField DataField="genero" HeaderText="Género" />
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
</body>
</html>
