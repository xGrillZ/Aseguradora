<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmCoberturaPolizaInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza.frmCoberturaPolizaInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="frmClienteInserta" runat="server" class="form-inline">      
      <h1 class="auto-style1">Mantenimiento de Clientes - Insertar</h1>       

       <div class="form-group">
          <asp:Label ID="Label3" runat="server" Text="Nombre Cobertura"></asp:Label>      
          <asp:TextBox ID="txtPrimerApellido" runat="server" class="form-control"></asp:TextBox>
          <asp:RequiredFieldValidator ID="rqvPrimerApellido" runat="server"  ControlToValidate="txtPrimerApellido" ErrorMessage="Debe ingresar el primer apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>
       <div class="form-group">
           <asp:Label ID="Label4" runat="server" Text="Descripción Cobertura"></asp:Label>                 
           <asp:TextBox ID="txtSegundoApellido" runat="server" class="form-control"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rqvTxtSegundoApellido" runat="server"  ControlToValidate="txtSegundoApellido" ErrorMessage="Debe ingresar el segundo apellido" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>           
       <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Porcentaje Cobertura"></asp:Label>
             <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rqvTxtNombre" runat="server" ControlToValidate="txtNombre" class="form-control" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
       </div>
        <div class="form-group">
          <asp:Label ID="Label1" runat="server" Text="Tipo Poliza"></asp:Label>
            <asp:DropDownList ID="ddlTipoPoliza" runat="server" class="form-control" DataTextField="nombre" DataValueField="idTipoPoliza"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="rqVddlTipoPoliza" runat="server" ErrorMessage="Debes seleccionar el tipo de Poliza" Display="None" ControlToValidate="ddlTipoPoliza"></asp:RequiredFieldValidator>
        </div>
       <div class="form-group">
           <asp:Button ID="btAceptar" runat="server"  Text="Guardar" class="btn-success" OnClick="btAceptar_Click" />           
       </div>             
                                                                  
      <br />
      <asp:ValidationSummary ID="vsRegistroPersonas" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
