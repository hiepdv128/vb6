Public Class Answer
    Private content As String
    Private correct As Boolean

    Public Function getContent() As String
        Return content
    End Function

    Public Function getCorrect() As Boolean
        Return correct
    End Function

    Public Sub setContent(content_ As String)
        content = content_
    End Sub

    Public Sub setCorrect(correct_ As Boolean)
        correct = correct_
    End Sub

End Class
