﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="Tipo.aspx.vb" Inherits="SVSG_web.Tipo" %>
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
    <form id="seccion_form" runat="server" >
        
        
        <br />
        <br />
        <table style="margin-left: auto; margin-right: auto; " cellspacing="25">
            <tr>
                <td><asp:Button ID="Button3" runat="server" Text="Procedimiento" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button4" runat="server" Text="Instructivo" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button5" runat="server" Text="Formato" Height="100px" Width="175px" CssClass="buttons"  /></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button6" runat="server" Text="Listado" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button7" runat="server" Text="Manual" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button8" runat="server" Text="Registro" Height="100px" Width="175px" CssClass="buttons"  /></td>
            </tr>
            <tr>
                <td><asp:Button ID="Button11" runat="server" Text="Norma" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button12" runat="server" Text="Catálogo" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="Button13" runat="server" Text="Investigación" Height="100px" Width="175px" CssClass="buttons"  /></td>
           </tr>
        </table>
    </form>
</asp:Content>