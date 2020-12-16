<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmPolizaElimina.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza.frmPolizaElimina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="poliza-Elimina">
        <div class="contenido-principal">
            <form id="frmPolizaElimina" runat="server" class="form-inline">
                 <h1>Mantenimiento pólizas - Eliminar.</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Cédula cliente:"></asp:Label>
                     <asp:TextBox ID="txtCedCliente" runat="server" class="form-control" Enabled="False" ></asp:TextBox>
                     <asp:HiddenField ID="hdIdRegistroPoliza" runat="server" />
                 </div>
                  <div class="form-group">
                      <asp:HiddenField ID="hdIdCliente" runat="server" />
                      <br />
                      <asp:Label ID="Label2" runat="server" Text="Cobertura poliza:"></asp:Label>
                      <asp:DropDownList ID="ddlCoberturaPoliza" runat="server" DataTextField="nombre" DataValueField="idCoberturaPoliza" Enabled="False"></asp:DropDownList>
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label3" runat="server" Text="Monto asegurado:"></asp:Label>
                      <asp:TextBox ID="txtMontoAsegurado" runat="server" class="form-control" TextMode="Number" Enabled="False" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label5" runat="server" Text="Cantidad adicciones:"></asp:Label>
                      <asp:TextBox ID="txtCantidadAdicciones" runat="server" class="form-control" ReadOnly="True" Enabled="False" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label6" runat="server" Text="Monto adicciones:"></asp:Label>
                      <asp:TextBox ID="txtMontoAdicciones" runat="server" class="form-control" ReadOnly="True" Enabled="False" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label7" runat="server" Text="Prima antes impuestos:"></asp:Label>
                      <asp:TextBox ID="txtPrimaAntesImpuestos" runat="server" class="form-control" ReadOnly="True" Enabled="False"></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label8" runat="server" Text="Impuestos:"></asp:Label>
                      <asp:TextBox ID="txtImpuestos" runat="server" class="form-control" ReadOnly="True" Enabled="False"></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label9" runat="server" Text="Prima final:"></asp:Label>
                      <asp:TextBox ID="txtPrimaFinal" runat="server" class="form-control" ReadOnly="True" Enabled="False"></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label10" runat="server" Text="Fecha registro:"></asp:Label>
                      <asp:TextBox ID="txtFechaRegistro" runat="server" class="form-control" TextMode="Date" Enabled="False" ></asp:TextBox>         
                      <asp:RequiredFieldValidator ID="rqVtxtFechaRegistro" runat="server" ErrorMessage="Debes ingresar la fecha de registro" ControlToValidate="txtFechaRegistro" Display="None"></asp:RequiredFieldValidator>
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label4" runat="server" Text="Empleado:"></asp:Label>
                      <asp:TextBox ID="txtEmpleado" runat="server" class="form-control" ReadOnly="True" Enabled="False" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:HiddenField ID="hdIdEmpleado" runat="server" />
                      <br />
                      <asp:Label ID="Label11" runat="server" Text="Sucursal:"></asp:Label>
                      <asp:TextBox ID="txtSucursal" runat="server" class="form-control" ReadOnly="True" Enabled="False" ></asp:TextBox> 
                  </div>
                  <div class="form-group">
                      <asp:HiddenField ID="hdIdSucursal" runat="server" />
                      <br />
                      <asp:Label ID="Label12" runat="server" Text="Porcentaje cobertura:"></asp:Label>
                      <asp:TextBox ID="txtPorcentajeCobertura" runat="server" class="form-control" ReadOnly="True" Enabled="False" ></asp:TextBox>         
                  </div>
                      <br />
                      <asp:Button ID="btnEliminarDatos" runat="server"  Text="Eliminar" class="btn-success" OnClick="btnEliminarDatos_Click"  /> 
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                 &nbsp;
                     <asp:HyperLink ID="hpListaPoliza" runat="server" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoPoliza/frmPolizaLista.aspx">Lista de datos.</asp:HyperLink>
                 <br />
                 <br />
                 <br />
                 <asp:ValidationSummary ID="vsEliminarPoliza" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </form>
         </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
