Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IListado" in both code and config file together.
<ServiceContract()>
Public Interface IListado

    <OperationContract()>
    Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As ListaPublicaciones

End Interface

<DataContract()>
Public Class ListaPublicaciones

    Private lista As List(Of SVSG_lib.Publicacion)

    Public Sub New()
        Me.lista = New List(Of SVSG_lib.Publicacion)
    End Sub

    <DataMember()>
    Public Property Publicaciones() As SVSG_lib.Publicacion

    Public Sub agregar(ByVal p As SVSG_lib.Publicacion)
        Me.lista.Add(p)
    End Sub
End Class
