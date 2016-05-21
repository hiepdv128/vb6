Imports System.Collections

Public Class Question
    Private question As String
    Private answers As New List(Of Answer)

    Public Function getQuestion() As String
        Return question
    End Function

    Public Sub setQuestion(ByVal _question As String)
        question = _question
    End Sub

    Public Function getAnswers() As List(Of Answer)
        Return answers
    End Function

    Public Sub addAnswers(ByVal ans As Answer)
        answers.Add(ans)
    End Sub

End Class
