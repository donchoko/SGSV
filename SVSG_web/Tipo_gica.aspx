<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="Tipo_gica.aspx.vb" Inherits="SVSG_web.Tipo_gica" %>
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
    <div id="info_box" style="background-color:#f6efa5; width:70%; margin:0 auto; overflow:hidden; left:15%; border-radius:25px; box-shadow: 5px 5px 2px #888888;" >  
        <br />
        <h4 style="text-align:center"> Los siguientes documentos han sido publicados o modificados:</h4>
        <asp:Table ID="tbl_info" runat="server" BorderColor="Black" BorderStyle="Solid" GridLines="Both" CssClass="table_center">
            <asp:TableHeaderRow Font-Bold="true">
                <asp:TableCell Text="Código"></asp:TableCell>
                <asp:TableCell Text="Nombre"></asp:TableCell>
                <asp:TableCell Text="Version"></asp:TableCell>
                <asp:TableCell Text="Rige desde"></asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <br />
    </div>
        
    <br />
    <br />
    <br />
    <div style="clear:both">
        <table style="margin-left: auto; margin-right: auto; " cellspacing="25">
            <tr>
                <td><asp:Button ID="btn_diagrama_proceso" runat="server" Text="Diagrama de Proceso" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="btn_politica_sistema" runat="server" Text="Política del Sistema" Height="100px" Width="175px" CssClass="buttons"  /></td>
                <td><asp:Button ID="btn_objetivo_sistema" runat="server" Text="Objetivos del Sistema" Height="100px" Width="175px" CssClass="buttons"  /></td>
            </tr>
        
        </table>
    </div>
    <div style="text-align:center">
        <asp:LinkButton id="btn_volver" runat="server" Text="Regresar al menu de secciones"></asp:LinkButton>
    </div>
    
</asp:Content>
