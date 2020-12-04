<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="AseguradoraFinal.formularios.Logeo.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Correo Electrónico"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rqvCorreoElectronico" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Debe ingresar el correo electrónico"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="rqvContrasena" runat="server" ControlToValidate="txtContrasena" ErrorMessage="Debe ingresar una contraseña"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btAceptar" runat="server" OnClick="btAceptar_Click" Text="Aceptar" />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
</form>
</body>
</html>
