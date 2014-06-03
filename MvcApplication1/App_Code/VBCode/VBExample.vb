Public Class VBExample
    Private teamStr As String
    Public Sub New()
        TeamString = "Visual Basic Code"
    End Sub
    Public Property TeamString() As String
        Get
            Return teamStr
        End Get
        Set(ByVal Value As String)
            teamStr = Value
        End Set
    End Property
End Class