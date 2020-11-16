<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClienteInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.frmClienteInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

    <form id="frmClienteInserta" runat="server" class="form-inline">      
      <h1 class="auto-style1">Ingreso de nuevos asegurados</h1>       

       <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Primer Apellido"></asp:Label>      
          <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rqvPrimerApellido" runat="server"  ControlToValidate="txtPrimerApellido" ErrorMessage="Debe ingresar el primer apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>
       <div class="form-group">
           <asp:Label ID="Label4" runat="server" Text="Segundo Apellido"></asp:Label>                 
           <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rqvTxtSegundoApellido" runat="server"  ControlToValidate="txtSegundoApellido" ErrorMessage="Debe ingresar el segundo apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>           
       <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
             <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rqvTxtNombre" runat="server" ControlToValidate="txtNombre" CssClass="form-control" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>
       <div class="form-group">
          <asp:Label ID="Label6" runat="server" Text="Teléfono 1"></asp:Label>
          <asp:TextBox ID="txtTelefono1" runat="server" CssClass="form-control"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rqvTxtTelefono1" runat="server" ControlToValidate="txtTelefono1" CssClass="form-control" ErrorMessage="Debe ingresar el teléfono principal" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>
      
       <div class="form-group">
          <asp:Label ID="Label7" runat="server" Text="Teléfono 2"></asp:Label>
          <asp:TextBox ID="txtTelefono2" runat="server" CssClass="form-control"></asp:TextBox>
       </div>
        <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text="Tipo Cliente"></asp:Label> 
            <asp:DropDownList ID="ddlTipoCliente" runat="server"  CssClass="form-control" DataTextField="nombre" DataValueField="id_TipoCliente"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rqvddlTipoCliente" runat="server" ErrorMessage="Debe seleccionar el tipo de cliente" Display="None" ControlToValidate="ddlTipoCliente"></asp:RequiredFieldValidator>
        </div>

       <div class="form-group">
          <asp:Label ID="Label2" runat="server" Text="País Procedencia"></asp:Label>      
            <asp:DropDownList ID="lstPaisProcedencia" runat="server"  CssClass="form-control" DataTextField="nombre" DataValueField="id_PaisProcedencia" ></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rqvlstPaisProcedencia" runat="server" ErrorMessage="Debe seleccionar el pais de procedencia" Display="None" ControlToValidate="lstPaisProcedencia"></asp:RequiredFieldValidator>
        </div>
       <div class="form-group">
           <asp:Button ID="btAceptar" runat="server"  Text="Guardar" CssClass="btn-success" OnClick="btAceptar_Click" /> 
            <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/formularios/frmClienteLista.aspx">Regresar a la Lista</asp:HyperLink>
       </div>             
                                                                  
          
                                                                  
      <br />
      <asp:ValidationSummary ID="vsRegistroPersonas" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
