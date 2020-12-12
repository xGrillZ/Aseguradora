<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmCoberturaPolizaInserta.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza.frmCoberturaPolizaInserta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <section class="coberturaPoliza-Inserta">
        <div class="contenidofrm">
            <form id="frmClienteInserta" runat="server" class="form-inline">

              <h1 class="auto-style1">Mantenimiento de Clientes - Insertar</h1>       

               <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Nombre Cobertura"></asp:Label>      
                  <asp:TextBox ID="txtNombreCobertura" runat="server" class="form-control"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rqVtxtNombreCobertura" runat="server"  ControlToValidate="txtNombreCobertura" ErrorMessage="Debes ingresar el nombre de cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Descripción Cobertura"></asp:Label>                 
                   <asp:TextBox ID="txtDescCobertura" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtDescCobertura" runat="server"  ControlToValidate="txtSegundoApellido" ErrorMessage="Debe ingresar la descripción de cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>           
               <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Porcentaje Cobertura"></asp:Label>
                     <asp:TextBox ID="txtPorcentaje" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rqVtxtPorcentaje" runat="server" ControlToValidate="txtPorcentaje" class="form-control" ErrorMessage="Debe ingresar el porcentaje de cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
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
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
