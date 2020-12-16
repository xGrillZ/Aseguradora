<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesModifica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmClienteModifica" runat="server" class="form-inline">      
      <h1 class="auto-style1">Actualizar datos de Adicciones</h1>       
          <asp:HiddenField ID="hdIdAdiccion" runat="server" />
               <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text="Nombre de la Adicción"></asp:Label>
             <asp:DropDownList ID="ddlIdAdiccion" runat="server" CssClass="form-control" DataValueField="descripcion" DataTextField="nombre" Enabled="True"  ></asp:DropDownList>        
        <asp:RequiredFieldValidator ID="rqvIdAdiccion" runat="server"  ControlToValidate="ddlIdAdiccion" ErrorMessage="Debe ingresar el id de Adicción" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>

      <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Identificador Categoría"></asp:Label>
          <asp:DropDownList ID="ddlIdCategoria" runat="server" CssClass="form-control" DataValueField="idCategoriaAdiccion" DataTextField="descripcion" Enabled="True"  ></asp:DropDownList>
        <asp:RequiredFieldValidator ID="rqvIdCategoria" runat="server"  ControlToValidate="ddlIdCategoria" ErrorMessage="Debe ingresar el identificador de categoría" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
      
       
       <div class="form-group">
           <asp:Button ID="btAceptar" runat="server"  Text="Modificar" CssClass="btn-success" OnClick="btAceptar_Click" />
           <asp:HyperLink ID="hpRegresar" runat="server" CssClass="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoAdicciones/frmAdiccionesLista.aspx">Regresar a la lista</asp:HyperLink>
       </div>             
                                                                  
      <br />
      <asp:ValidationSummary ID="vsRegistroPersonas" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
