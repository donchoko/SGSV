Imports SVSG_lib

Public Class ServiceManager

    Public Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As List(Of Publicacion)
        Dim client As New PublicacionService.ListadoClient()
        Dim l As Publicaciones
        l = client.cargarLista(tipo_doc, seccion, vigencia)
        client.Close()
        Return l.Lista


    End Function


End Class
