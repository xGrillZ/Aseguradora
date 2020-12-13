<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmClienteInserta" runat="server" class="form-inline">      
      <h1 class="auto-style1">Ingreso de Adicciones</h1>       


       <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
           <asp:TextBox ID="txtNombreAdiccion" runat="server" CssClass="form-control"  ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rqvtxtNombreAdiccion" runat="server" ErrorMessage="Debe ingresar el nombre de la adicción"  ControlToValidate="txtNombreAdiccion" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
           </div>           
       
       
        <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Identificador Categoría"></asp:Label>
          <asp:DropDownList ID="ddlIdCategoria" runat="server" CssClass="form-control" DataValueField="idAdiccion" DataTextField="descripcion" Enabled="True"  ></asp:DropDownList>
        <asp:RequiredFieldValidator ID="rqvIdCategoria" runat="server"  ControlToValidate="ddlIdCategoria" ErrorMessage="Debe ingresar el identificador de categoría" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
       <div class="form-group">
           <asp:Button ID="btInsertar" runat="server"  Text="Insertar" CssClass="btn-success" OnClick="btInsertar_Click" /> 
            <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoAdicciones/frmAdiccionesLista.aspx">Regresar a la Lista</asp:HyperLink>
       </div>             
                                                                  
          
                                                                  
      <br />
      <asp:ValidationSummary ID="vsRegistroPersonas" runat="server" ShowMessageBox="True" ShowSummary="False" />
     
     <asp:Label ID="lblMensaje" runat="server"></asp:Label> 
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
