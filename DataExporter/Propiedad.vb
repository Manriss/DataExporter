Public Class Propiedades
    Private _Category As String
    Private _Property As String
    Public Property Categoria As String
        Get
            Return _Category
        End Get
        Set(value As String)
            _Category = value
        End Set
    End Property
    Public Property Propiedad As String
        Get
            Return _Property
        End Get
        Set(value As String)
            _Property = value
        End Set
    End Property
End Class
