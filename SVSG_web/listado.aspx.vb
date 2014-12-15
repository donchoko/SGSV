Public Class listado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim context As New PublicacionesService.ListadoClient()
        Dim lista As List(Of SVSG_lib.Publicacion) = context.cargarLista(Session.Item("tipo").ToString(), Session.Item("seccion").ToString(), "vigente").Lista
        context.Close()
        If lista Is Nothing Then
            Response.Redirect("404.aspx")
        Else
            For Each p As SVSG_lib.Publicacion In lista
                Dim r As New TableRow()
                Dim c As New TableCell()
                Dim h As New LinkButton()
                h.Text = p.cod
                AddHandler h.Click, AddressOf lnk_publicacion_click
                h.Attributes.Add("text-align", "center")
                c.Controls.Add(h)
                c.Wrap = True
                'c.Text = p.cod
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = p.Documento.nombre
                c.Wrap = True
                c.Attributes.Add("text-align", "center")
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = p.documento_version
                c.Wrap = True
                c.Attributes.Add("text-align", "center")
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = p.fecha
                c.Wrap = True
                c.Attributes.Add("text-align", "center")
                r.Cells.Add(c)
                c = New TableCell()
                c.Text = p.Documento.alcance
                c.Wrap = True
                c.Attributes.Add("text-align", "center")
                r.Cells.Add(c)
                r.BackColor = Drawing.Color.White
                tbl_publicaciones.Rows.Add(r)
            Next
        End If
    End Sub

    Private Sub lnk_publicacion_click(ByVal sender As Object, ByVal e As System.EventArgs)
        Session.Add("cod", CType(sender, LinkButton).Text)
        Response.Redirect("Secciones.aspx")
    End Sub

End Class