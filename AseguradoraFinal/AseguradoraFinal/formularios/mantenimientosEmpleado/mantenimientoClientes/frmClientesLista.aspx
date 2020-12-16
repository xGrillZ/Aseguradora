<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClientesLista.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoClientes.frmClientesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="clientes-Lista">
        <div class="contenido-principal">
            <form runat="server" class="form-inline">
            <h1>Busqueda de clientes</h1>
             <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Primer Apellido:"></asp:Label>
                   <asp:TextBox ID="txtPrimerApellido" runat="server" class="form-control" ></asp:TextBox>  
                   <asp:RegularExpressionValidator ID="reVtxtPrimerApellido" runat="server" ErrorMessage="El máximo de carácteres para el primer apellido es de 50." ControlToValidate="txtPrimerApellido" Display="None" ValidationExpression="^[\s\S]{0,50}$"></asp:RegularExpressionValidator>
                </div>
                 <div class="form-group">
                   <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                   <asp:TextBox ID="txtNombre" runat="server" class="form-control" ></asp:TextBox>  
                   <asp:RegularExpressionValidator ID="reVtxtNombre" runat="server" ErrorMessage="El máximo de carácteres para el nombre es de 50." ControlToValidate="txtNombre" Display="None" ValidationExpression="^[\s\S]{0,50}$"></asp:RegularExpressionValidator>
                </div>
                 <div class="form-group">
                   <asp:Label ID="Label3" runat="server" Text="Cédula:"></asp:Label>
                   <asp:TextBox ID="txtCedula" runat="server" class="form-control" ></asp:TextBox>   
                   <asp:RegularExpressionValidator ID="reVtxtCedula" runat="server" ErrorMessage="El máximo de carácteres para la cédula es de 20." ControlToValidate="txtPrimerApellido" Display="None" ValidationExpression="^[\s\S]{0,20}$"></asp:RegularExpressionValidator>
                </div>
                 <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Género:"></asp:Label>
                   <asp:TextBox ID="txtGenero" runat="server" class="form-control" ></asp:TextBox>   
                   <asp:RegularExpressionValidator ID="reVtxtGenero" runat="server" ErrorMessage="Debes de ingresar M para masculino o F para femenino." ControlToValidate="txtGenero" Display="None" ValidationExpression="^(M|F)$"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <br />
                    <asp:Button ID="btnMostrarDatos" runat="server"  Text="Mostrar datos." class="btn-success" OnClick="btnMostrarDatos_Click"  />  
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                    <asp:HyperLink ID="hpNuevoRegistro" runat="server" class="text-info" NavigateUrl="~/formularios/mantenimientoClientes/frmClientesInserta.aspx">Nuevo registro clientes.</asp:HyperLink>
                    <br />
                    <br />
                    <asp:GridView ID="grdListaClientes" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </div>
             </form>
           </div>
        </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
