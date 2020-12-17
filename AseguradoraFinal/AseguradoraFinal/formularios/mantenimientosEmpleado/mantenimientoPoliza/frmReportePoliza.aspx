<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmReportePoliza.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza.frmReportePoliza" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="adicciones-Lista">
        <div class="contenido-principal">
            <form id="form1" runat="server">
            <div class="principal">
            <div class="grupo-principal">
                    <asp:ScriptManager ID="scmReporteClientes" runat="server"></asp:ScriptManager>
                    <div>
                        <h1 class="auto-style1">Reporte de Clientes</h1>               
                          <p> Buscar por</p>
                    </div>
                    <asp:Label ID="Label1" runat="server" Text="Primer apellido:"></asp:Label>
                    <asp:TextBox ID="txtPriApellido" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Número cédula:"></asp:Label>
                    <asp:TextBox ID="txtCed" runat="server"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Nombre cobertura:"></asp:Label>
                    <asp:TextBox ID="txtCobertura" runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:Button ID="btVerReporte" runat="server" OnClick="btBuscar_Click" Text="Ver Reporte" />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
       
                    <br />
                    <br />  
                                </div>
                </div>
                   <rsweb:ReportViewer ID="rpvClientes" runat="server" Width="100%">
                  </rsweb:ReportViewer>
                </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
