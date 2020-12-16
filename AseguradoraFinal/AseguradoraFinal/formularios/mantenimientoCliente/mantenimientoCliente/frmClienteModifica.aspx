<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClienteModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientoCliente.mantenimientoCliente.frmClienteLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="cliente-Modifica">
        <div class="contenidofrm">
            <form id="frmClienteModifica" runat="server" class="form-inline">      
                 <h1>Modificación de datos personales.</h1>
                  <div class="form-group">
                      <asp:Label ID="Label4" runat="server" Text="Dirección física:"></asp:Label>
                      <asp:TextBox ID="txtDireccion" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label5" runat="server" Text="Primer teléfono:"></asp:Label>
                      <asp:TextBox ID="txtPriTel" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                  <div class="form-group">
                      <asp:Label ID="Label6" runat="server" Text="Segundo teléfono:"></asp:Label>
                      <asp:TextBox ID="txtSecTel" runat="server" class="form-control" ></asp:TextBox>            
                  </div>
                      <br />
                      <asp:Button ID="btnModificarDatos" runat="server"  Text="Modificar" class="btn-success" OnClick="btnModificarDatos_Click"  /> 
                 &nbsp;
                 <br />
                 <br />
            </form>
        </div>
     </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
