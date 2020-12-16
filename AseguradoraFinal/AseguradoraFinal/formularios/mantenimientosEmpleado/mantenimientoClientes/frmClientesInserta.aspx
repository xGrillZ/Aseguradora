<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmClientesInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoClientes.frmClientesInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="clientes-Inserta">
        <div class="contenido-principal">
            <form id="frmClienteInserta" runat="server" class="form-inline">      
              <h1 class="auto-style1">Ingreso de nuevos clientes.</h1>       

               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Nombre cliente:"></asp:Label>      
                  <asp:TextBox ID="txtNombreCliente" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtNombreCliente" runat="server"  ControlToValidate="txtNombreCliente" ErrorMessage="Debes ingresar el nombre del cliente." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtNombreCliente" runat="server" ErrorMessage="El nombre del cliente debe ser menor o igual a 50 carácteres." ControlToValidate="txtNombreCliente" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Primer apellido:"></asp:Label>                 
                   <asp:TextBox ID="txtPriApellido" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtPriApellido" runat="server"  ControlToValidate="txtPriApellido" ErrorMessage="Debes ingresar el primer apellido." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="reVtxtPriApellido" runat="server" ErrorMessage="El primer apellido debe ser menor o igual a 50 carácteres." ControlToValidate="txtPriApellido" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
               </div>           
               <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Segundo apellido:"></asp:Label>
                     <asp:TextBox ID="txtSegApellido" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rqVtxtSegApellido" runat="server" ControlToValidate="txtSegApellido" class="form-control" ErrorMessage="Debes ingresar el segundo apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ID="reVtxtSegApellido" runat="server" ErrorMessage="El segundo apellido debe ser menor o igual a 50 carácteres." ControlToValidate="txtSegApellido" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                  <asp:Label ID="Label6" runat="server" Text="Número cédula:"></asp:Label>
                  <asp:TextBox ID="txtNumCedula" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtNumCedula" runat="server" ControlToValidate="txtNumCedula" class="form-control" ErrorMessage="Debes ingresar el número de cédula." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtNumCedula" runat="server" ErrorMessage="El número de cédula debe ser menor o igual a 20 carácteres." ControlToValidate="txtNumCedula" Display="None" ValidationExpression="^[\s\S]{1,20}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                  <asp:Label ID="Label7" runat="server" Text="Genero:"></asp:Label>
                  <asp:TextBox ID="txtGenero" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtGenero" runat="server" ControlToValidate="txtGenero" class="form-control" ErrorMessage="Debes ingresar el género del cliente." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtGenero" runat="server" ErrorMessage="El género del cliente debe ser M para masculino o F para femenino." ControlToValidate="txtGenero" Display="None" ValidationExpression="^(M|F)$"></asp:RegularExpressionValidator>
               </div>
                <div class="form-group">
                  <asp:Label ID="Label1" runat="server" Text="Dirección física:"></asp:Label> 
                  <asp:TextBox ID="txtDireccionFisica" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtDireccionFisica" runat="server" ErrorMessage="Debes ingresar la dirección física del cliente." Display="None" ControlToValidate="txtDireccionFisica"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtDireccionFisica" runat="server" ErrorMessage="La dirección física debe ser menor o igual a 100 carácteres." ControlToValidate="txtDireccionFisica" Display="None" ValidationExpression="^[\s\S]{1,100}$"></asp:RegularExpressionValidator>
                </div>
               <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text="Teléfono principal:"></asp:Label>      
                  <asp:TextBox ID="txtPriTelefono" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtPriTelefono" runat="server" ControlToValidate="txtPriTelefono" class="form-control" ErrorMessage="Debes ingresar el teléfono principal." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtPriTelefono" runat="server" ErrorMessage="El teléfono principal debe ser menor o igual a 50 carácteres." ControlToValidate="txtPriTelefono" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                  <asp:Label ID="Label8" runat="server" Text="Teléfono secundario:"></asp:Label>      
                  <asp:TextBox ID="txtSegTelefono" runat="server" class="form-control"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="reVtxtSegTelefono" runat="server" ErrorMessage="El teléfono secundario debe ser menor o igual a 50 carácteres." ControlToValidate="txtSegTelefono" Display="None" ValidationExpression="^[\s\S]{0,50}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Insertar" class="btn-success" OnClick="btInsertar_Click" /> 
                   <asp:Button ID="btBuscar" runat="server"  Text="Buscar" class="btn-success" OnClick="btBuscar_Click" /> 
                   <asp:HyperLink ID="hpRegresarLista" runat="server" class="text-info" NavigateUrl="/formularios/mantenimientosEmpleado/mantenimientoClientes/frmClientesLista.aspx">Lista de datos.</asp:HyperLink>
               </div>                                                             
              <br />
              <asp:ValidationSummary ID="vsInsertaCliente" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
