Imports System.ServiceModel
Imports System.Runtime.Serialization

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IListado" in both code and config file together.
<ServiceContract()>
Public Interface IListado

    <OperationContract()>
    Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As Publicaciones

End Interface

<DataContract()>
Public Class Publicaciones

    <DataMember()>
    Public Property Lista() As List(Of SVSG_lib.Publicacion)


End Class


