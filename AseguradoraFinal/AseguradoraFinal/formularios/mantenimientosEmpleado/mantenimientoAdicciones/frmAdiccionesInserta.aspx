<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmClienteInserta" runat="server" class="form-inline">      
      <h1 class="auto-style1">Ingreso de Adicciones</h1>       

              <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text="Identificador Adicción"></asp:Label>
             <asp:DropDownList ID="ddlIdAdiccion" runat="server" CssClass="form-control" DataValueField="id_Adiccion" DataTextField="id" Enabled="False"  ></asp:DropDownList>        
        <asp:RequiredFieldValidator ID="rqvIdAdiccion" runat="server"  ControlToValidate="ddlIdAdiccion" ErrorMessage="Debe ingresar el id de Adicción" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
      

       <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
           <asp:DropDownList ID="ddlNombreAdiccion" runat="server" CssClass="form-control" DataValueField="nombre" DataTextField="nombre" Enabled="False"  ></asp:DropDownList>        
      <asp:RequiredFieldValidator ID="rqvNombre" runat="server"  ControlToValidate="ddlNombreAdiccion" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
           </div>           
       
        <div class="form-group">
          <asp:Label ID="Label4" runat="server" Text="Código"></asp:Label>
          <asp:DropDownList ID="ddlCodigoAdiccion" runat="server" CssClass="form-control" DataValueField="id_CodigoAdiccion" DataTextField="codigo" Enabled="False"  ></asp:DropDownList>
       <asp:RequiredFieldValidator ID="rqvCodigoAdiccion" runat="server"  ControlToValidate="ddlCodigoAdiccion" ErrorMessage="Debe ingresar el código" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
            </div>
        <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Identificador Categoría"></asp:Label>
          <asp:DropDownList ID="ddlIdCategoria" runat="server" CssClass="form-control" DataValueField="id_Categoria" DataTextField="categoria" Enabled="False"  ></asp:DropDownList>
        <asp:RequiredFieldValidator ID="rqvIdCategoria" runat="server"  ControlToValidate="ddlIdCategoria" ErrorMessage="Debe ingresar el identificador de categoría" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
        </div>
       <div class="form-group">
           <asp:Button ID="btInsertar" runat="server"  Text="Insertar" CssClass="btn-success" OnClick="btInsertar_Click" /> 
            <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoAdicciones/frmAdiccionesLista.aspx">Regresar a la Lista</asp:HyperLink>
       </div>             
                                                                  
          
                                                                  
      <br />
      <asp:ValidationSummary ID="vsRegistroPersonas" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
