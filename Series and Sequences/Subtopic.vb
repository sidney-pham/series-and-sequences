Public Class Subtopic
    'Private text As String

    Private question As String
    Public Property Text() As String
        Get
            Return question
        End Get
        Set(value As String)
            question = value
        End Set
    End Property

    Private heading As String
    Public Property Title() As String
        Get
            Return heading
        End Get
        Set(value As String)
            heading = value
        End Set
    End Property
End Class
