<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/AseguradoraPagMaestra.Master" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="AseguradoraFinal.formularios.frmPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/Principal.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <div class="container-principal">
        <section class="contenido-header">
            <div class="container">
                    <div class="texto">
                        <h1>Seguros, El equipo del Siglo XXI</h1>
                        <h2>¡Nos preocupamos por tu salud!</h2>
                        <asp:HyperLink ID="contactoAseguradora" runat="server" class="contactoAseguradora">Contacto</asp:HyperLink>
                    </div>
                    <img src="../img/imgPrincipal.png" class="imgPrincipal"/>
            </div>
        </section>
    </div>
    <div class="wave">
        <div style="height: 150px; overflow: hidden;" >
            <svg viewBox="0 0 500 150" preserveAspectRatio="none" style="height: 100%; width: 100%;">
                <path d="M0.00,49.98 C149.99,150.00 349.20,-49.98 500.00,49.98 L500.00,150.00 L0.00,150.00 Z" style="stroke: none; fill: #fff;"></path>
            </svg>
        </div>
    </div>
    <section class="info-seguros">
        <div class="contenedor-infoseguros">
            <h2>PRUEBA</h2>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
