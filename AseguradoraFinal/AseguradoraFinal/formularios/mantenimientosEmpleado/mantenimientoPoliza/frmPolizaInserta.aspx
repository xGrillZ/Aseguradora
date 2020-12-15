<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmPolizaInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoPoliza.frmPolizaInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="poliza-Inserta">
        <div class="contenido-principal">
            <form id="frmPolizaInserta" runat="server" class="form-inline">
                 <h1>Mantenimiento pólizas - Insertar.</h1>
                 <div class="form-group">
                     <asp:Label ID="Label1" runat="server" Text="Cédula cliente:"></asp:Label>
                     <asp:TextBox ID="txtCedCliente" runat="server" class="form-control" ></asp:TextBox>            
                 </div>
                  <div class="form-group">
                      <asp:Label ID="Label2" runat="server" Text="Cobertura poliza:"></asp:Label>
                      <asp:TextBox ID="txtNumCedula" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label4" runat="server" Text="Adicción:"></asp:Label>
                      <asp:DropDownList ID="ddlAdiccion" runat="server"></asp:DropDownList>           
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label3" runat="server" Text="Monto asegurado:"></asp:Label>
                      <asp:TextBox ID="txtMontoAsegurado" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label5" runat="server" Text="Cantidad adicciones:"></asp:Label>
                      <asp:TextBox ID="txtCantidadAdicciones" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label6" runat="server" Text="Monto adicciones:"></asp:Label>
                      <asp:TextBox ID="txtMontoAdicciones" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label7" runat="server" Text="Prima antes impuestos:"></asp:Label>
                      <asp:TextBox ID="txtPrimaAntesImpuestos" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label8" runat="server" Text="Impuestos:"></asp:Label>
                      <asp:TextBox ID="txtImpuestos" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label9" runat="server" Text="Prima final:"></asp:Label>
                      <asp:TextBox ID="txtPrimaFinal" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label10" runat="server" Text="Fecha registro:"></asp:Label>
                      <asp:TextBox ID="txtFechaRegistro" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label11" runat="server" Text="Sucursal:"></asp:Label>
                      <asp:TextBox ID="txtSucursal" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label12" runat="server" Text="Porcentaje cobertura:"></asp:Label>
                      <asp:TextBox ID="txtPorcentajeCobertura" runat="server" class="form-control" ></asp:TextBox>         
                  </div>
                      <br />
                      <asp:Button ID="btnIngresarDatos" runat="server"  Text="Ingresar" class="btn-success" OnClick="btnIngresarDatos_Click"  /> 
                 &nbsp;
                     <asp:HyperLink ID="hpNuevaPoliza" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaInserta.aspx">Ingresar nueva póliza</asp:HyperLink>
                 <br />
                 <br />
                 <br />
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
