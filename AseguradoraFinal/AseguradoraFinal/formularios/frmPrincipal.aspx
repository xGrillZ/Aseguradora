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
            <h1>Tipos seguros</h1>
            <h3>Contamos con una gran variedad de polizas con un precio accesible para mejorar tu calidad de vida</h3>
            <div class="polizaArticulo">
                <img src="../img/seguroVehiculo.png" class="imgPoliza"/>
                <h2>Auto</h2>
                <p>Adquiere diferentes beneficios por tu poliza vehicular, haz click para obtener más información</p>
            </div>
            <div class="polizaArticulo">
                <img src="../img/seguroVida.png" class="imgPoliza"/>
                <h2>Vida</h2>
                <p>asdasd</p>
            </div>
            <div class="polizaArticulo">
                <img src="../img/seguroPropiedad.png" class="imgPoliza"/>
                <h2>Propiedad</h2>
                <p>asdasd</p>
            </div>
            <div class="polizaArticulo">
                <img src="../img/seguroViajes.png" class="imgPoliza"/>
                <h2>Viajes</h2>
                <p>asdasd</p>
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scriptsPersonalizados" runat="server">
</asp:Content>
