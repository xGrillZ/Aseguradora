<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmAdiccionesElimina.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesElimina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="clientes-Inserta">
        <div class="contenido-principal">
            <form id="frmClienteElimina" runat="server" class="form-inline">      
              <h1 class="auto-style1">Eliminación de Adicciones</h1>       
                   <asp:HiddenField ID="hdIdAdiccion" runat="server" />

      
               <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Adicción"></asp:Label>
                    <asp:DropDownList ID="ddlNombreAdiccion" runat="server" class="form-control" DataValueField="idAdiccion" DataTextField="nombre" Enabled="False"  ></asp:DropDownList>        
                   </div>           

               <div class="form-group">
                   <asp:Button ID="btEliminar" runat="server"  Text="Eliminar" class="btn-success" OnClick="btEliminar_Click" />
                   <asp:HyperLink ID="hpRegresar" runat="server" CssClass="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoAdicciones/frmAdiccionesLista.aspx">Regresar a la lista.</asp:HyperLink>
               </div>             
                                                                  
              <br />  
              <asp:ValidationSummary ID="vsEliminaAdiccion" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
