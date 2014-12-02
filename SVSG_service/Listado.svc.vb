Imports SVSG_lib

' NOTE: You can use the "Rename" command on the context menu to change the class name "Listado" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Listado.svc or Listado.svc.vb at the Solution Explorer and start debugging.
Public Class Listado
    Implements IListado

    Public Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As Publicaciones Implements IListado.cargarLista
        If tipo_doc Is Nothing Or seccion Is Nothing Or vigencia Is Nothing Then
            Throw New ArgumentNullException("composite")
        Else
            Dim publicaciones As New Publicaciones()

            Dim p As SVSG_lib.Publicacion = New SVSG_lib.Publicacion()
            If seccion <> "*" Then
                p.seccion = seccion
            End If

            If tipo_doc <> "*" Then
                p.tipo = tipo_doc
            End If

            If vigencia <> "*" Then
                p.vigencia = vigencia
            End If

            Using context As New SVSG_lib.SVSGEntities
                context.Configuration.ProxyCreationEnabled = False
                publicaciones.Lista = context.Publicacion.ToList()
            End Using
            Return publicaciones
        End If
    End Function

    Public Function crearDocumento(_publicacion As Publicacion) As Boolean Implements IListado.crearDocumento
        If _publicacion Is Nothing Then
            Throw New ArgumentNullException("composite")
        Else
            Try
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    context.Documento.Add(_publicacion.Documento)
                    context.Publicacion.Add(_publicacion)
                End Using
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
    End Function

    Public Function modificacionMenor(publicacion As Publicacion) As Boolean Implements IListado.modificacionMenor

    End Function

    Public Function publicacionMayor(publicacion As Publicacion) As Boolean Implements IListado.publicacionMayor

    End Function
End Class
