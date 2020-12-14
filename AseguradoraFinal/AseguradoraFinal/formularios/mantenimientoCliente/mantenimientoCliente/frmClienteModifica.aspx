<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClienteModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientoCliente.mantenimientoCliente.frmClienteLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="cliente-Modifica">
        <div class="contenido-principal">
            <form id="form1" runat="server" class="form-inline">
                 <h1>Modificación de datos personales.</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Nombre Cobertura:"></asp:Label>
                     <asp:TextBox ID="txtCobertura" runat="server" class="form-control" ></asp:TextBox>            
                 </div>
                  <div class="form-group">
                      <asp:Label ID="Label2" runat="server" Text="Nombre Tipo Poliza:"></asp:Label>
                      <asp:TextBox ID="txtTipoPoliza" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                      <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" class="btn-success" OnClick="btnMostrarDatos_Click"  /> 
                 &nbsp;
                     <asp:HyperLink ID="hpNuevaCobertura" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaInserta.aspx">Ingresar nueva Cobertura</asp:HyperLink>
                 <br />
                 <br />
            </form>
        </div>
     </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
