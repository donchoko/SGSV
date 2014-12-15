<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="Listado.aspx.vb" Inherits="SVSG_web.listado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" runat="server">

    <style type="text/css">
        .table_center{
            margin-left: auto; 
            margin-right: auto
        }
        
        .cell_center{
            text-align:center
        }

    </style>
    <div style="margin-left:auto; text-align:center;font-size:28px; font-weight:500; font-family:'Segoe UI'">
        Seleccione el documento que desea visualizar
    </div>
    <br />
    <div style="width:80%; margin:0 auto; overflow:hidden; left:10%; top:10%">
        <asp:Table ID="tbl_publicaciones" runat="server" BorderColor="Black" GridLines="Both" BorderStyle="Solid" CssClass="table_center">
            <asp:TableHeaderRow Font-Bold="true">
                <asp:TableCell Text="Código" BackColor="#66ccff" CssClass="cell_center"></asp:TableCell>
                <asp:TableCell Text="Nombre" BackColor="#66ccff" CssClass="cell_center"></asp:TableCell>
                <asp:TableCell Text="Version" BackColor="#66ccff" CssClass="cell_center"></asp:TableCell>
                <asp:TableCell Text="Rige desde" BackColor="#66ccff" CssClass="cell_center"></asp:TableCell>
                <asp:TableCell Text="Alcance" BackColor="#66ccff" CssClass="cell_center"></asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>

</asp:Content>
