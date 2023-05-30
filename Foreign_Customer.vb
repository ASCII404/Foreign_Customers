Public Class Foreign_Customer
    Private _id As Integer
    Private _name As String
    Private _age As Integer
    Private _country As String

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal age As Integer, ByVal country As String)
        _id = id
        _name = name
        _age = age
        _country = country
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Country As String
        Get
            Return _country
        End Get
        Set(value As String)
            _country = value
        End Set
    End Property
End Class
