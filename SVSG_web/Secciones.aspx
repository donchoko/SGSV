<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="Secciones.aspx.vb" Inherits="SVSG_web.Secciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contenido" ContentPlaceHolderID="contenido" runat="server">
    <style type="text/css">
        .buttons{
            border-radius: 25px;
            box-shadow: 5px 5px 2px #888888;
        }

        .text{
            text-align:center 
        }

    </style>
    <div style="margin-left:auto; text-align:center;font-size:30px; font-weight:500; font-family:'Segoe UI'">
        Secciones
    </div>
    <br />
    <table cellspacing="25" style="margin:auto">
        <tr>
            <td><asp:Button ID="btn_jefatura" runat="server" Text="Jefatura Departamental" Height="100px" Width="175px" CssClass="buttons"/></td>
            <td><asp:Button ID="btn_gica" runat="server" Text="GICA" Height="100px" Width="175px" CssClass="buttons"/></td>
        </tr>
    </table>
    <br />
    <br />
    <table style="margin-left: auto; margin-right: auto; " cellspacing="25">
        <tr>
            <td><asp:Button ID="btn_quim_analitica" runat="server" Text="Química analítica" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_bioquim" runat="server" Text="Bioquímica" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_pericias" runat="server" Text="Pericias físicas" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_ing_forense" runat="server" Text="Ingeniería forense" Height="100px" Width="175px" CssClass="buttons"  /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btn_doc_dudosos" runat="server" Text="Documentos dudosos" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_biologia" runat="server" Text="Biología" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_img_sonido" runat="server" Text="Imagen y sonido forense" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_toxi" runat="server" Text="Toxicología" Height="100px" Width="175px" CssClass="buttons"  /></td>
        </tr>
    </table>
</asp:Content>
