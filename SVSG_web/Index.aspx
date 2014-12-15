<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Index.aspx.vb" Inherits="SVSG_web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="width:90%; height:90%; margin:0 auto; background-color:#B8CBF5; position:absolute; left:5%; top:5% ;border-radius: 25px;box-shadow: 10px 10px 5px #888888;">
        <div id="banner" style="width:800px; height:160px; margin:0 auto;overflow: hidden;" >
            <div style="margin:auto">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/diosa.jpg" Height="150px" Width="130px" ImageAlign="Left" style="margin-left: 3px; margin-top: 10px"/>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/escudo.png" Height="145px" ImageAlign="Right" style="margin-right: 10px; margin-top: 10px" />
            </div>
            <div style="margin-left:auto; margin-right:auto; width:450px; margin-top:40px; text-align:center;" >
                <asp:Label ID="Label1" runat="server" Text="Sistema de Control de Documentos" Font-Bold="True" Font-Names="Segoe UI" Font-Size="X-Large"></asp:Label>
                <br /><asp:Label ID="Label2" runat="server" Text="Departamento de Ciencias Forenses" Font-Bold="True" Font-Names="Segoe UI" Font-Size="X-Large" Font-Underline="False"></asp:Label>
            </div>
        </div>
    <div style="overflow: hidden;">
        <div id="div_form"  style="width:40%; height:40%; margin-left: auto; margin-right: auto;">
            <form id="loginform" runat="server">
                <!--<asp:Login ID="log" runat="server" Width="398px" LoginButtonText="Iniciar sesión" PasswordLabelText="Contraseña:" PasswordRequiredErrorMessage="Se requiere un password para ingresar" TitleText="" UserNameLabelText="Usuario:" UserNameRequiredErrorMessage="Se requiere un nombre de usuario para ingresar">
                    <TextBoxStyle Font-Size="Large" />
                </asp:Login>-->
                <h3 style="text-align:center; font-family:'Segoe UI'">Inicie sesión para ingresar al sistema</h3>
                <br />
                <div style="background-color:#dce8fe ; margin:0 auto;border-radius: 25px;">
                    <table cellspacing="35" style="margin:auto">
                        <tr>
                            <td>Usuario:</td>
                            <td><asp:TextBox ID="txt_usuario" runat="server" Width="210px"></asp:TextBox></td>
                             
                        </tr>
                        <tr>
                            <td>Contraseña:</td>
                            
                            <td><asp:TextBox ID="txt_contraseña" runat="server" TextMode="Password" Width="210px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:CheckBox ID="check_terms" runat="server" Text="Por este medio acepto los terminos y condiciones de uso" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="btn_login" runat="server" Text="Iniciar sesión" Height="50px" Width="150px" />
                            </td>                           
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Label ID="lbl_warn" runat="server" Text=""/>
                            </td>                           
                        </tr>
                    </table> 
                    <br />
                </div>
            </form>
        </div>
    </div>
    
</body>
</html>