<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmCoberturaPolizaModifica.aspx.cs" Inherits="AseguradoraFinal.formularios.mantenimientosEmpleado.mantenimientoCoberturaPoliza.frmCoberturaPolizaModifica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                   <asp:HiddenField ID="hdidCoberturaPoliza" runat="server" />
               </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Descripción cobertura:"></asp:Label>                 
                   <asp:TextBox ID="txtDescCobertura" runat="server" class="form-control"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rqVtxtDescCobertura" runat="server"  ControlToValidate="txtDescCobertura" ErrorMessage="Debes ingresar la descripción de la cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>           
               <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Porcentaje cobertura:"></asp:Label>
                     <asp:TextBox ID="txtPorcentajeCobertura" runat="server" class="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="rqVtxtPorcentajeCobertura" runat="server" ControlToValidate="txtPorcentajeCobertura" class="form-control" ErrorMessage="Debes ingresar el porcentaje de la cobertura" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label6" runat="server" Text="Tipo Poliza"></asp:Label>
                   <asp:DropDownList ID="ddlTipoPoliza" runat="server"></asp:DropDownList>
                   <asp:RequiredFieldValidator ID="rqVddlTipoPoliza" runat="server" ControlToValidate="ddlTipoPoliza" class="form-control" ErrorMessage="Debes ingresar el tipo de póliza" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
               </div>
               <div class="form-group">
                   <asp:Button ID="btAceptar" runat="server"  Text="Guardar" class="btn-success" OnClick="btAceptar_Click" />
               </div>             
                                                                  
              <br />
              <asp:ValidationSummary ID="vsModificaCoberturaPoliza" runat="server" ShowMessageBox="True" ShowSummary="False" />
        
            </form>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
