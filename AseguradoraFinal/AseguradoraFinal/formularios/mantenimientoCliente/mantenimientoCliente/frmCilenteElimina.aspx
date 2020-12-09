<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCilenteElimina.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientoCliente.matenimientoCliente.frmCilenteElimina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
  <form id="frmClienteElimina" runat="server" class="form-inline">      
      <h1 class="auto-style1">Mantenimiento de Clientes - Eliminar</h1>       
           <asp:HiddenField ID="hdIdCliente" runat="server" />
       <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Primer Apellido"></asp:Label>      
          <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control" ></asp:TextBox>
          
       </div>
       <div class="form-group">
           <asp:Label ID="Label4" runat="server" Text="Segundo Apellido"></asp:Label>                 
           <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"  ></asp:TextBox>
          
       </div>           
       <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
             <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>
          
       </div>
       <div class="form-group">
          <asp:Label ID="Label6" runat="server" Text="Teléfono 1"></asp:Label>
          <asp:TextBox ID="txtTelefono1" runat="server" CssClass="form-control" ></asp:TextBox>
          
       </div>
      
       <div class="form-group">
          <asp:Label ID="Label7" runat="server" Text="Teléfono 2"></asp:Label>
          <asp:TextBox ID="txtTelefono2" runat="server" CssClass="form-control" ></asp:TextBox>
       </div>
        <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text="Tipo Cliente"></asp:Label>
          <asp:DropDownList ID="ddlTipoCliente" runat="server" CssClass="form-control" DataValueField="id_TipoCliente" DataTextField="nombre"  ></asp:DropDownList>
          
        </div>

       <div class="form-group">
          <asp:Label ID="Label2" runat="server" Text="País Procedencia"></asp:Label>
           <asp:ListBox ID="lstPaisProcedencia" runat="server" CssClass="form-control" DataValueField="id_PaisProcedencia" DataTextField="nombre"  ></asp:ListBox>
           
        </div>
       <div class="form-group">
           <asp:Button ID="btAceptar" runat="server"  Text="Guardar" CssClass="btn-success" OnClick="btAceptar_Click" />
           <asp:HyperLink ID="hpRegresar" runat="server" CssClass="text-info" NavigateUrl="~/formulariosBaseDatos/frmClienteLista.aspx">Regresar a la lista</asp:HyperLink>
       </div>             
                                                                  
      <br />      
        
    </form>
</body>
</html>
