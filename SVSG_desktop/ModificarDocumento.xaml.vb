Public Class ModificarDocumento
    Public Sub New(ByVal documento As SVSG_lib.Documento, ByVal publi As SVSG_lib.Publicacion)


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub colocarDatos(ByVal doc As SVSG_lib.Documento, ByVal publi As SVSG_lib.Publicacion)
        txt_cod.Text = doc.cod
        txt_nombre.Text = doc.nombre
        txt_responsable.Text = doc.creado
        Dim p_vigente As SVSG_lib.Publicacion


    End Sub
End Class
