<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="Tipo.aspx.vb" Inherits="SVSG_web.Tipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" runat="server">
    <style type="text/css">
        .buttons{
            border-radius: 25px;
            box-shadow: 5px 5px 2px #888888;
        }

        .text{
            text-align:center 
        }

    </style>
    <div style="margin-left:auto; text-align:center;font-size:28px; font-weight:500; font-family:'Segoe UI'">
        Seleccione el tipo de documento
    </div>
    <br />
    <!--<div id="info_box" style="background-color:#f6efa5; width:70%; margin:0 auto; position:absolute; left:15%;" >
        
    </div>-->
        
    <br />
    <br />
    <table style="margin-left: auto; margin-right: auto; " cellspacing="25">
        <tr>
            <td><asp:Button ID="btn_procedimiento" runat="server" Text="Procedimiento" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_instructivo" runat="server" Text="Instructivo" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_formato" runat="server" Text="Formato" Height="100px" Width="175px" CssClass="buttons"  /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btn_listado" runat="server" Text="Listado" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_manual" runat="server" Text="Manual" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_registro" runat="server" Text="Registro" Height="100px" Width="175px" CssClass="buttons"  /></td>
        </tr>
        <tr>
            <td><asp:Button ID="btn_norma" runat="server" Text="Norma" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_catalogo" runat="server" Text="Catálogo" Height="100px" Width="175px" CssClass="buttons"  /></td>
            <td><asp:Button ID="btn_investigacion" runat="server" Text="Investigación" Height="100px" Width="175px" CssClass="buttons"  /></td>
        </tr>
    </table>

</asp:Content>
