Imports System.ServiceModel
Imports System.Runtime.Serialization

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IListado" in both code and config file together.
<ServiceContract()>
Public Interface IListado

    <OperationContract()>
    Function cargarLista(ByVal tipo_doc As String, ByVal seccion As String, ByVal vigencia As String) As Publicaciones

    <OperationContract()>
    Function crearDocumento(ByVal publicacion As Publicacion) As Boolean

    <OperationContract()>
    Function modificacionMenor(ByVal publicacion As Publicacion) As Boolean

    <OperationContract()>
    Function publicacionMayor(ByVal publicacion As Publicacion) As Boolean
End Interface

<DataContract()>
Public Class Publicaciones
    Private _lista As List(Of Publicacion)
    <DataMember()>
    Public Property Lista() As List(Of SVSG_lib.Publicacion)
        Get
            Return Me._lista
        End Get
        Set(value As List(Of SVSG_lib.Publicacion))
            Me._lista = value
        End Set
    End Property



End Class


