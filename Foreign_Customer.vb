Public Class Foreign_Customer
    Private id As Integer
    Private name As String
    Private age As Integer
    Private country As String

    Public Sub New(ByVal Id, ByVal Name, ByVal Age, ByVal Country)
        Me.name = Name
        Me.id = Id
        Me.age = Age
        Me.country = Country
    End Sub

    Public Property Customer_ID As Integer
        Get
            Return Me.id
        End Get
        Set(value As Integer)
            Me.id = value
        End Set
    End Property

    Public Property Customer_Name As String
        Get
            Return Me.name
        End Get
        Set(value As String)
            Me.name = value
        End Set
    End Property

    Public Property Customer_Age As Integer
        Get
            Return Me.age
        End Get
        Set(value As Integer)
            Me.age = value
        End Set
    End Property

    Public Property Customer_Country As String
        Get
            Return Me.country
        End Get
        Set(value As String)
            Me.country = value
        End Set
    End Property

End Class
