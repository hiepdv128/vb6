Public Class Answer
    Private content As String
    Private correct As Boolean
    Private checked As Boolean

    Public Function getContent() As String
        Return content
    End Function

    Public Function getCorrect() As Boolean
        Return correct
    End Function

    Public Function getChecked() As Boolean
        Return checked
    End Function

    Public Sub setChecked(checked_ As Boolean)
        checked = checked_
    End Sub

    Public Sub setContent(content_ As String)
        content = content_
    End Sub

    Public Sub setCorrect(correct_ As Boolean)
        correct = correct_
    End Sub


End Class
