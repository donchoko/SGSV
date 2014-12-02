Imports System.Windows
Imports SVSG_lib

Public Class ListadoManager
    'Implements SVSG_lib.IListado

    Public Sub crear()
        Dim cd As CrearDocumento = New CrearDocumento()
        cd.Show()
    End Sub

    Public Sub modificar(ByVal codigo As String)
        Dim doc As SVSG_lib.Documento
        Try
            Dim client As New PublicacionService.ListadoClient()
            doc = client.cargarItem(codigo)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Dim pub As SVSG_lib.Publicacion
        For Each p In doc.Publicacion
            If p.vigencia = "vigente" Then
                pub = p
            End If
        Next

        If pub Is Nothing Then
            MessageBox.Show("No hay ninguna publicacion vigente de dicho documento")
        Else
            Dim md As ModificarDocumento = New ModificarDocumento(doc, pub)
            md.Show()
        End If

        
    End Sub

    Public Sub abrirHistorico()
        Dim h As Historico = New Historico()
        h.Show()
    End Sub

    Public Sub eliminar(nombre As String)
        Dim result As Integer = MessageBox.Show("Desea eliminar el documento " + nombre, "caption", MessageBoxButton.YesNo)
        If result = MessageBoxResult.Yes Then
            MessageBox.Show("Cancel pressed")
        ElseIf result = MessageBoxResult.No Then
            MessageBox.Show("No pressed")
        End If
    End Sub

    Public Function cargarLista(tipo As String, seccion As String, vigencia As String) As List(Of SVSG_lib.Publicacion)
        Dim client As New PublicacionService.ListadoClient()
        Dim l As Publicaciones
        l = client.cargarLista(tipo, seccion, vigencia)
        client.Close()
        Return l.Lista
    End Function




End Class
