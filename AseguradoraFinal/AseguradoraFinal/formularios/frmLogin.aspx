<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="AseguradoraFinal.formularios.Logeo.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Seguros, El equipo del Siglo XXI</title>
    <link href="../css/Logeo.css" rel="stylesheet" />
    <link href="../lib/font-awesome/css/all.min.css" rel="stylesheet" />
    <link href="../lib/twitter-bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Poppins:600&display=swap" rel="stylesheet" />
</head>
<body>
   <img src="../img/wave.png" class="wave" />
        <div class="container">
            <div class="img">
                <img src="../img/aseguradoradibujo.svg" />
            </div>
            <div class="container-login">
                <form id="form1" runat="server">
                    <img class="avatar" src="../img/avatar.svg" />
                    <h2>Bienvenid@ a tu mejor protección</h2>
                    <div class="input-div one">
                        <div class="i">
                            <i class="fas fa-user"></i>
                        </div>
                        <div>
                            <h5><asp:Label ID="Label1" runat="server" Text="Correo Electrónico"></asp:Label></h5>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="input"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Debe ingresar el correo electrónico" Display="None"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Debes de ingresar un correo electrónico válido" ControlToValidate="txtCorreo" Display="None" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="El máximo de carácteres del correo electrónico es de 50" ControlToValidate="txtCorreo" Display="None" ValidationExpression="^[\s\S]{0,50}$"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="input-div two">
                        <div class="i">
                            <i class="fas fa-unlock"></i>
                        </div>
                        <div>
                            <h5><asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label></h5>
                            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" CssClass="input"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtContrasena" ErrorMessage="Debe ingresar una contraseña" Display="None"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="El máximo de carácteres de la contraseña es de 15" ControlToValidate="txtContrasena" Display="None" ValidationExpression="^[\s\S]{0,15}$"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <asp:Button ID="btnAceptar" class="btAceptar" runat="server" OnClick="btAceptar_Click" Text="Ingresar" /> 
                        <asp:Label ID="lblResultado" runat="server"></asp:Label>
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                        <br />
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </form>
            </div>
        </div>
    <script type="text/javascript" src="../Scripts/logeo.js"></script>
</body>
</html>
