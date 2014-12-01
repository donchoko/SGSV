Imports SVSG_lib

Public Class Manager

    Public Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As List(Of Publicacion)
        Dim client As New PublicacionService.ListadoClient()
        Return client.cargarLista(tipo_doc, seccion, vigencia).Lista
    End Function


End Class
