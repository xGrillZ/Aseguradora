<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmCoberturaPolizaModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza.frmCoberturaPolizaModifica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="coberturaPoliza-Modifica">
        <div class="contenidofrm">
              <form id="frmCoberturaPolizaModifica" runat="server" class="form-inline">      
              <h1 class="auto-style1">Mantenimiento de Cobertura Póliza - Modificar</h1>       
          
               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Nombre cobertura:"></asp:Label>      
                  <asp:TextBox ID="txtNombreCobertura" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtNombreConbertura" runat="server"  ControlToValidate="txtNombreCobertura" ErrorMessage="Debes ingresar el nombre de la cobertura." ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="reVtxtNombreCobertura" runat="server" ErrorMessage="El nombre de la cobertura debe ser menor o igual a 50 carácteres." ControlToValidate="txtNombreCobertura" Display="None" ValidationExpression="^[\s\S]{1,50}$"></asp:RegularExpressionValidator>
                  <asp:HiddenField ID="hdidCoberturaPoliza" runat="server" />
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Descripción cobertura:"></asp:Label>                 
                   <asp:TextBox ID="txtDescCobertura" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtDescCobertura" runat="server"  ControlToValidate="txtDescCobertura" ErrorMessage="Debes ingresar la descripción de la cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="La descripción de la cobertura debe ser menor o igual a 100 carácteres." ControlToValidate="txtDescCobertura" Display="None" ValidationExpression="^[\s\S]{1,100}$"></asp:RegularExpressionValidator>
               </div>           
               <div class="form-group">
                   <asp:Label ID="Label5" runat="server" Text="Porcentaje cobertura:"></asp:Label>
                   <asp:TextBox ID="txtPorcentajeCobertura" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtPorcentajeCobertura" runat="server" ControlToValidate="txtPorcentajeCobertura" class="form-control" ErrorMessage="Debes ingresar el porcentaje de la cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="reVtxtPorcentajeCobertura" runat="server" ErrorMessage="El porcentaje de la cobertura debe ser menor o igual a 100%." ControlToValidate="txtPorcentajeCobertura" Display="None" ValidationExpression="^[\s\S]{1,100}$"></asp:RegularExpressionValidator>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label6" runat="server" Text="Tipo Poliza"></asp:Label>
                   <asp:DropDownList ID="ddl_TipoPoliza" runat="server" class="form-control" DataTextField="nombre" DataValueField="idTipoPoliza"></asp:DropDownList>
                   <asp:RequiredFieldValidator ID="rqVddlTipoPoliza" runat="server" ControlToValidate="ddl_TipoPoliza" class="form-control" ErrorMessage="Debes ingresar el tipo de póliza" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Guardar" class="btn-success" OnClick="btAceptar_Click" />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:HyperLink ID="hpListaCoberturaPoliza" runat="server" NavigateUrl="~/formularios/mantenimientosEmpleado/mantenimientoCoberturaPoliza/frmCoberturaPolizaLista.aspx">Lista datos</asp:HyperLink>
               </div>             
                                                                  
              <br />
              <asp:ValidationSummary ID="vsModificaCoberturaPoliza" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
