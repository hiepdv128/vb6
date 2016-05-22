Imports System.Collections

Public Class Question
    Private question As String
    Private answers As New List(Of Answer)
    Private indexOfAns As New ArrayList
    Private indexChecked As Integer

    Public Sub New()
        indexChecked = -1
        indexOfAns.Add(0)
        indexOfAns.Add(1)
        indexOfAns.Add(2)
        indexOfAns.Add(3)
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

    Public Function getIndexOfAns() As ArrayList
        Return indexOfAns
    End Function

    Public Sub setIndexChecked(index As Integer)
        indexChecked = index
    End Sub

    Public Function getIndexChecked() As Integer
        Return indexChecked
    End Function
End Class
