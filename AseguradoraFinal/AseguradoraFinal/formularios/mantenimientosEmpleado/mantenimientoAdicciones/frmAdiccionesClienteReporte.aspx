<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAdiccionesClienteReporte.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoAdicciones.frmAdiccionesClienteReporte" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scmReporteAdiccionesClientes" runat="server"></asp:ScriptManager>
        <div>
            <h1 class="auto-style1">Reporte de adicciones por cliente</h1>               
              <p> Buscar por</p>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Primer Apellido:"></asp:Label>
        <asp:TextBox ID="txtPrimerApellido" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Button ID="btVerReporte" runat="server" OnClick="btBuscar_Click" Text="Ver Reporte" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
       
        <br />
        <br />       
   <rsweb:ReportViewer ID="rpvAdiccionesClientes" runat="server" Width="100%">
  </rsweb:ReportViewer>
    </form>
</body>
</html>
