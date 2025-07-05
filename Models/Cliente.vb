Public Class Cliente
    Private _ClienteId As Integer

    Private _Nombre As String

    Private _Apellidos As String

    Private _Email As String

    Private _Telefono As String

    'Constructor completo
    Public Sub New(ClienteID As Integer, Nombre As String, Apellidos As String, Email As String, Telefono As String)
        _ClienteId = ClienteID
        _Nombre = Nombre
        _Apellidos = Apellidos
        _Email = Email
        _Telefono = Telefono
    End Sub

    Public Property ClienteId As Integer
        Get
            Return _ClienteId
        End Get
        Set(value As Integer)
            _ClienteId = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

End Class
