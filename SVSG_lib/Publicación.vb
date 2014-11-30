Public Class Publicación

    Private _documento As Documento
    Private _version As String
    Private _detalle As String
    Private _archivo As Byte
    Private _fecha As Date
    Private _publicado_por
    Private _seccion As String
    Private _ambito As String
    Private _sis_gestion As String
    Private _procedencia As String
    Private _tipo_alcance As String

    Public Sub New(ByVal doc As Documento,
                   ByVal version As String,
                   ByVal detalle As String,
                   ByVal archivo As Byte,
                   ByVal fecha As Date,
                   ByVal publicado_por As String,
                   ByVal seccion As String,
                   ByVal ambito As String,
                   ByVal sis_gestion As String,
                   ByVal procedencia As String,
                   ByVal tipo_alcance As String)

        Me._documento = doc
        Me._version = version
        Me._detalle = detalle
        Me._archivo = archivo
        Me._publicado_por = publicado_por
        Me._seccion = seccion
        Me._ambito = ambito
        Me._sis_gestion = sis_gestion
        Me._procedencia = procedencia
        Me._tipo_alcance = tipo_alcance
    End Sub

    Public Property Documento() As Documento
        Get
            Return Me._documento
        End Get
        Set(value As Documento)
            Me._documento = value
        End Set
    End Property

    Public Property Version() As String
        Get
            Return _version
        End Get
        Set(value As String)
            Me._version = value
        End Set
    End Property

    Public Property Detalle() As String
        Get
            Return _detalle
        End Get
        Set(value As String)
            Me._detalle = value
        End Set
    End Property

    Public Property Archivo() As Byte
        Get
            Return _archivo
        End Get
        Set(value As Byte)
            Me._archivo = value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            Me._fecha = value
        End Set
    End Property

    Public Property PublicadoPor() As String
        Get
            Return _publicado_por
        End Get
        Set(value As String)
            Me._publicado_por = value
        End Set
    End Property

    Public Property Seccion() As String
        Get
            Return _seccion
        End Get
        Set(value As String)
            Me._seccion = value
        End Set
    End Property

    Public Property Ambito() As String
        Get
            Return _ambito
        End Get
        Set(value As String)
            Me._ambito = value
        End Set
    End Property

    Public Property SistemaDeGestion() As String
        Get
            Return _sis_gestion
        End Get
        Set(value As String)
            Me._sis_gestion = value
        End Set
    End Property

    Public Property Procedencia() As String
        Get
            Return _procedencia
        End Get
        Set(value As String)
            Me._procedencia = value
        End Set
    End Property

    Public Property TipoDeAlcance() As String
        Get
            Return _tipo_alcance
        End Get
        Set(value As String)
            Me._tipo_alcance = value
        End Set
    End Property
End Class
