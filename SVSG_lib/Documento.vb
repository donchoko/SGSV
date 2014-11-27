Public Class Documento

    Private _cod As Integer
    Private _nombre As String
    Private _alcance As String
    Private _encargado As String
    Private _creado As Date
    Private _publicaciones As List(Of Publicación)



    Public Sub New(ByVal cod As Integer,
                   ByVal nombre As String,
                   ByVal alcance As String,
                   ByVal encargado As String,
                   ByVal creado As Date,
                   ByVal publicaciones As List(Of Publicación)
                   )

        Me._cod = cod
        Me._nombre = nombre
        Me._alcance = alcance
        Me._encargado = encargado
        Me._creado = creado
        Me._publicaciones = publicaciones
    End Sub

    Public Sub New(ByVal cod As Integer,
                   ByVal nombre As String,
                   ByVal alcance As String,
                   ByVal encargado As String,
                   ByVal creado As Date)

        Me._cod = cod
        Me._nombre = nombre
        Me._alcance = alcance
        Me._encargado = encargado
        Me._creado = creado
    End Sub

    Public Property Codigo() As Integer
        Get
            Return _cod
        End Get
        Set(value As Integer)
            Me._cod = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property Alcance() As String
        Get
            Return _alcance
        End Get
        Set(value As String)
            Me._alcance = value
        End Set
    End Property

    Public Property EncargadoDeActualizacion() As String
        Get
            Return _encargado
        End Get
        Set(value As String)
            Me._encargado = value
        End Set
    End Property

    Public Property FechaDeCreacion() As Date
        Get
            Return _creado
        End Get
        Set(value As Date)
            Me._creado = value
        End Set
    End Property

    Public Property Publicaciones() As List(Of Publicación)
        Get
            Return _publicaciones
        End Get
        Set(value As List(Of Publicación))
            Me._publicaciones = value
        End Set
    End Property


End Class
