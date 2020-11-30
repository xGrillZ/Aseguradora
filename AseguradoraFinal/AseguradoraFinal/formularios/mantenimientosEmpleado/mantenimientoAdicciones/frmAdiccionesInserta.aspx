<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmClienteInserta" runat="server" class="form-inline">      
      <h1 class="auto-style1">Ingreso de adicciones</h1>       

      <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text="Identificador Adicción"></asp:Label>
             <asp:DropDownList ID="ddlIdAdiccion" runat="server" CssClass="form-control" DataValueField="id_Adiccion" DataTextField="id" Enabled="False"  ></asp:DropDownList>        
       </div>
      

       <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
           <asp:DropDownList ID="ddlNombreAdiccion" runat="server" CssClass="form-control" DataValueField="id_Adiccion" DataTextField="nombre" Enabled="False"  ></asp:DropDownList>        
       </div>           
       
        <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Código"></asp:Label>
          <asp:DropDownList ID="ddlCodigoAdiccion" runat="server" CssClass="form-control" DataValueField="id_CodigoAdiccion" DataTextField="codigo" Enabled="False"  ></asp:DropDownList>
        </div>
       <div class="form-group">
           <asp:Button ID="btIsertar" runat="server"  Text="Insertar" CssClass="btn-success" OnClick="btInsertar_Click" /> 
            <asp:HyperLink ID="hpRegresarLista" runat="server" CssClass="text-info" NavigateUrl="~/formularios/frmClienteLista.aspx">Regresar a la Lista</asp:HyperLink>
       </div>             
                                                                  
          
                                                                  
      <br />
      <asp:ValidationSummary ID="vsRegistroPersonas" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
