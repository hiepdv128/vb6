Imports System.Collections

Public Class Question
    Private question As String
    Private answers As New List(Of Answer)
    Private indexChecked As Integer

    Public Sub New()
        indexChecked = -1
    End Sub

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

    Public Sub setIndexChecked(index As Integer)
        indexChecked = index
    End Sub

    Public Function getIndexChecked() As Integer
        Return indexChecked
    End Function
End Class
