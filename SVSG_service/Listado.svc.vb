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

            '1--
            If tipo_doc <> "*" And seccion = "*" And vigencia = "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.tipo = tipo_doc).ToList()
                End Using
            End If

            '-2-
            If tipo_doc = "*" And seccion <> "*" And vigencia = "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.seccion = seccion).ToList()
                End Using
            End If

            '--3
            If tipo_doc = "*" And seccion = "*" And vigencia <> "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.vigencia = vigencia).ToList()
                End Using
            End If

            '12-
            If tipo_doc <> "*" And seccion <> "*" And vigencia = "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.tipo = tipo_doc).Where(Function(pub) pub.seccion = seccion).ToList()
                End Using
            End If

            '1-3
            If tipo_doc <> "*" And seccion = "*" And vigencia <> "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.tipo = tipo_doc).Where(Function(pub) pub.vigencia = vigencia).ToList()
                End Using
            End If

            '-23
            If tipo_doc = "*" And seccion <> "*" And vigencia <> "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.seccion = seccion).Where(Function(pub) pub.vigencia = vigencia).ToList()
                End Using
            End If

            '123
            If tipo_doc <> "*" And seccion <> "*" And vigencia <> "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").Where(Function(pub) pub.tipo = tipo_doc).Where(Function(pub) pub.tipo = tipo_doc).Where(Function(pub) pub.vigencia = vigencia).ToList()
                End Using
            End If

            'todos
            If tipo_doc = "*" And seccion = "*" And vigencia = "*" Then
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publicaciones.Lista = context.Publicacion.Include("Documento").ToList()
                End Using
            End If

            'Using context As New SVSG_lib.SVSGEntities
            'context.Configuration.ProxyCreationEnabled = False
            'publicaciones.Lista = context.Publicacion.Include("Documento").ToList()
            'End Using
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
                    _publicacion.Documento.Publicacion = Nothing
                    context.Publicacion.Add(_publicacion)
                    context.SaveChanges()

                End Using
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If
    End Function

    Public Function modificacionMenor(item As Publicacion, ByVal cod_original As String, ByVal version_original As String) As Boolean Implements IListado.modificacionMenor
        If item Is Nothing Then
            Throw New ArgumentNullException("composite")
        Else
            Try
                Dim p As Publicacion
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    p = context.Publicacion.Include("Documento").Where(Function(pub) pub.cod = cod_original).Where(Function(pub) pub.documento_version = version_original).FirstOrDefault()
                End Using

                p.Documento.creado = item.Documento.creado
                p.Documento.encargado = item.Documento.encargado
                p.Documento.nombre = item.Documento.nombre
                p.Documento.alcance = item.Documento.alcance

                p.detalle += Environment.NewLine
                p.detalle += Environment.NewLine
                p.detalle += item.detalle
                p.procedencia = item.procedencia
                p.publicado_por = item.publicado_por
                p.seccion = item.seccion
                p.sistema_gestion = item.sistema_gestion
                p.tipo = item.tipo
                p.tipo_alcance = item.tipo_alcance

                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    context.Entry(p).State = System.Data.EntityState.Modified
                    context.SaveChanges()
                End Using
                Return True
            Catch ex As Exception
                Return False
            End Try

        End If
    End Function

    Public Function publicacionMayor(publicacion As Publicacion) As Boolean Implements IListado.publicacionMayor
        If publicacion Is Nothing Then
            Throw New ArgumentNullException("composite")
        Else
            Try
                Dim publi_vieja As Publicacion
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publi_vieja = context.Publicacion.Include("Documento").Where(Function(p) p.cod = publicacion.cod).Where(Function(p) p.vigencia = "vigente").FirstOrDefault()
                End Using

                If publi_vieja IsNot Nothing Then
                    publi_vieja.vigencia = "no vigente"
                    publicacion.Documento = publi_vieja.Documento
                    Using context As New SVSG_lib.SVSGEntities
                        context.Configuration.ProxyCreationEnabled = False
                        context.Entry(publi_vieja).State = System.Data.EntityState.Modified
                        context.Publicacion.Add(publicacion)
                        context.SaveChanges()
                    End Using
                Else
                    publicacion.Documento = Nothing
                    Using context As New SVSG_lib.SVSGEntities
                        context.Configuration.ProxyCreationEnabled = False
                        context.Publicacion.Add(publicacion)
                        context.SaveChanges()
                    End Using
                End If
                Return True
            Catch ex As Exception
                System.Console.Write(ex)
                Return False
            End Try
        End If
    End Function


    Public Function cargarItem(codigo As String) As Documento Implements IListado.cargarItem
        If codigo Is Nothing Then
            Throw New ArgumentNullException("composite")
        Else
            Try
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    Dim doc As Documento = context.Documento.Include("Publicacion").First(Function(c) c.cod = codigo)
                    Return doc
                End Using
            Catch ex As Exception
                Return Nothing

            End Try

        End If
    End Function

    Public Function eliminar(cod As String, ver As String) As Boolean Implements IListado.eliminar
        If cod Is Nothing And ver Is Nothing Then
            Throw New ArgumentNullException("composite")
            Return False
        Else
            Try
                Dim publi As Publicacion
                Using context As New SVSG_lib.SVSGEntities
                    context.Configuration.ProxyCreationEnabled = False
                    publi = context.Publicacion.Where(Function(p) p.cod = cod).Where(Function(p) p.documento_version = ver).First()
                End Using

                If publi IsNot Nothing Then
                    publi.vigencia = "no vigente"
                    Using context As New SVSG_lib.SVSGEntities
                        context.Configuration.ProxyCreationEnabled = False
                        context.Entry(publi).State = System.Data.EntityState.Modified
                        context.SaveChanges()
                    End Using
                Else
                    Throw New NullReferenceException("La publicación no pudo ser encontrada")
                End If



            Catch ex As Exception
                System.Console.Write(ex)
                Return False
            End Try
        End If
    End Function
End Class
