<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SVSG.Master" CodeBehind="404.aspx.vb" Inherits="SVSG_web._404" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" runat="server">
    <h1 style="text-align:center; font-family:'Segoe UI' ">
        Error: No se ha podido cargar el contenido
    </h1>
    <br />
    <h2 style="text-align:center; font-family:'Segoe UI' ">
        Si el error se repite, por favor contacte al administrador
        <br />
        <asp:LinkButton id="btn_volver" runat="server" Text="Regresar al menu de secciones"></asp:LinkButton>
    </h2>
</asp:Content>
