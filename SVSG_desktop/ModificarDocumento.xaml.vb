Public Class ModificarDocumento
    Public Sub New(ByVal doc As SVSG_lib.Documento, ByVal publi As SVSG_lib.Publicacion)


        ' This call is required by the designer.
        InitializeComponent()
        colocarDatos(doc, publi)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub colocarDatos(ByVal doc As SVSG_lib.Documento, ByVal publi As SVSG_lib.Publicacion)
        txt_cod.Text = doc.cod
        txt_version.Text = publi.documento_version
        txt_nombre.Text = doc.nombre
        txt_responsable.Text = doc.creado
        txt_alcance.Text = doc.alcance

        doc.Publicacion.OrderByDescending(Function(p) p.fecha)

        For Each p As SVSG_lib.Publicacion In doc.Publicacion
            txt_historico.Content = p.documento_version + Environment.NewLine + p.fecha + Environment.NewLine + p.detalle + Environment.NewLine
        Next

    End Sub
End Class
