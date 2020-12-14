<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmPolizaLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza.frmPolizaLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="poliza-Lista">
        <div class="contenido-principal">
            <form id="frmPolizaLista" runat="server" class="form-inline">
                 <h1>Lista pólizas.</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Primer apellido cliente:"></asp:Label>
                     <asp:TextBox ID="txtPriApeCliente" runat="server" class="form-control" ></asp:TextBox>            
                 </div>
                  <div class="form-group">
                      <asp:Label ID="Label2" runat="server" Text="Número cédula cliente:"></asp:Label>
                      <asp:TextBox ID="txtNumCedula" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label3" runat="server" Text="Número adicciones:"></asp:Label>
                      <asp:TextBox ID="txtNumAdicciones" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                      <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos" class="btn-success" OnClick="btnMostrarDatos_Click"  /> 
                 &nbsp;
                     <asp:HyperLink ID="hpNuevaPoliza" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaInserta.aspx">Ingresar nueva póliza</asp:HyperLink>
                 <br />
                 <br />
                 <asp:GridView ID="grdListaPoliza" runat="server">
                 </asp:GridView>
                 <br />
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
