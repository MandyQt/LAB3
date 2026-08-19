Public Class AdminForm
    Private currentUserId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        currentUserId = userId
    End Sub
End Class