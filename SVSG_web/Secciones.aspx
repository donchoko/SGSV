<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="Secciones.aspx.vb" Inherits="SVSG_web.Secciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contenido" ContentPlaceHolderID="contenido" runat="server">
    <style type="text/css">
        .buttons{
            border-radius: 25px;
            box-shadow: 5px 5px 2px #888888;
        }
    </style>
    <form id="seccion_form" runat="server" >
        <table cellspacing="25" style="margin-left: auto; margin-right: auto; ">
            <tr>
                <td><asp:Button ID="Button1" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"/></td>
                <td><asp:Button ID="Button2" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"/></td>
            </tr>
        </table>
        <br />
        <br />
        <table style="margin-left: auto; margin-right: auto; " cellspacing="25">
            <tr>
                <td><asp:Button ID="Button3" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button4" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button5" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"  /></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button6" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button7" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button8" runat="server" Text="Button" Height="100px" Width="150px" CssClass="buttons"  /></td>
            </tr>
        </table>
    </form>
</asp:Content>
