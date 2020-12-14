<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmSalir.aspx.cs" Inherits="AseguradoraFinal.formularios.frmSalir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <form id="opcionSalir" runat="server">
        <h1>Cierre de la sesión del usuario</h1>
        <p>¿Desea salir de la aplicación?</p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="btnSi" runat="server" OnClick="btnSi_Click" Text="Sí" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
        </p>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
