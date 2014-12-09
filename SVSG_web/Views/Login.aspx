<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="SVSG_web.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <div style="width:800px; height:600px; margin:-300px 0 0 -400px; background-color:#B8CBF5; position:absolute; left:50%; top:50%;
    border-radius: 25px;box-shadow: 10px 10px 5px #888888;">
        <div id="banner" style="width:800px; height:160px; margin:0 auto;overflow: hidden;" >
            <div style="margin:auto">
                <asp:Image ID="diosa" runat="server" ImageUrl="~/Diosa de la Justicia.png" Height="150px" Width="130px" ImageAlign="Left" style="margin-left: 3px; margin-top: 10px"/>
                <asp:Image ID="logo" runat="server" ImageUrl="~/escudo_oij.png" Height="160px" ImageAlign="Right" style="margin-right: 10px; margin-top: 10px" />
            </div>
            <div style="margin-left:auto; margin-right:auto; width:400px; margin-top:40px" >
                <asp:Label ID="lbl_site_name" runat="server" Text="Sistema de Control de Documentos del Sistema de Gestión" Font-Bold="True"></asp:Label>
            </div>
        </div>
        <div id="contenido" style="width:800px; height:440px">
            <div id="div_form"  style="width:400px; height:130px; margin:65px 0 0 200px; top:50%; left:50%">
                <form id="loginform" runat="server">
                    <asp:Login ID="log" runat="server" Width="398px" LoginButtonText="Iniciar sesión" PasswordLabelText="Contraseña:" PasswordRequiredErrorMessage="Se requiere un password para ingresar" TitleText="" UserNameLabelText="Usuario:" UserNameRequiredErrorMessage="Se requiere un nombre de usuario para ingresar">
                        <TextBoxStyle Font-Size="Large" />
                    </asp:Login>
                </form>
            </div>
        </div>
        <!---->
    </div>
</body>
</html>
