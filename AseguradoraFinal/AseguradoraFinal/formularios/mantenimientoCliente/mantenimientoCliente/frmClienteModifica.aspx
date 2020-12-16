<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClienteModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientoCliente.mantenimientoCliente.frmClienteLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="cliente-Modifica">
        <div class="contenidofrm">
            <form id="frmClienteModifica" runat="server" class="form-inline">      
                 <h1>Modificación de datos personales.</h1>
                <div class="principal">
                <div class="grupo-principal">
                  <div class="form-group">
                      <asp:Label ID="Label4" runat="server" Text="Dirección física:"></asp:Label>
                      <asp:TextBox ID="txtDireccion" runat="server" class="form-control" ></asp:TextBox>    
                      <asp:RequiredFieldValidator ID="rqVtxtDireccion" runat="server" ErrorMessage="Debes ingresar una dirección física."></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="reVtxtDireccion" runat="server" ErrorMessage="El máximo de carácteres para la dirección física es de 100." ControlToValidate="txtDireccion" Display="None" ValidationExpression="^[\s\S]{0,100}$"></asp:RegularExpressionValidator>
                  </div>
                    <br />
                  <div class="form-group">
                      <asp:Label ID="Label5" runat="server" Text="Primer teléfono:"></asp:Label>
                      <asp:TextBox ID="txtPriTel" runat="server" class="form-control" ></asp:TextBox> 
                      <asp:RequiredFieldValidator ID="rqVtxtPriTel" runat="server" ErrorMessage="Debes ingresar el teléfono principal."></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="reVtxtPriTel" runat="server" ErrorMessage="El máximo de carácteres para el teléfono principal es de 50." ControlToValidate="txtPriTel" Display="None" ValidationExpression="^[\s\S]{0,50}$"></asp:RegularExpressionValidator>
                  </div>
                    <br />
                  <div class="form-group">
                      <asp:Label ID="Label6" runat="server" Text="Segundo teléfono:"></asp:Label>
                      <asp:TextBox ID="txtSecTel" runat="server" class="form-control" ></asp:TextBox>
                      <asp:RegularExpressionValidator ID="reVtxtSecTel" runat="server" ErrorMessage="El máximo de carácteres dpara el teléfono secundario es de 50" ControlToValidate="txtSecTel" Display="None" ValidationExpression="^[\s\S]{0,50}$"></asp:RegularExpressionValidator>
                  </div>
                      <br />
                  <div class="form-group">
                      <asp:Button ID="btnModificarDatos" runat="server"  Text="Modificar" class="btn-success" OnClick="btnModificarDatos_Click"  /> 
                 &nbsp;
                  </div>
                 <br />
                 <br />
                </div>
                </div>
            </form>
        </div>
     </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
